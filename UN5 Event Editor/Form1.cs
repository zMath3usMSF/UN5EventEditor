using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UN5_Event_Editor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UN5_Event_Editor
{
    public partial class Form1 : Form
    {
        public static bool isNA2 = false;
        public static List<CCSF> ccsList = new List<CCSF>();
        public static List<CharData> charDataList = new List<CharData>();
        public static List<byte[]> charDataBlocksList = new List<byte[]>();
        public static List<BootTalk> bootTalkList = new List<BootTalk>();
        public static List<EventFlag> eventFlagList = new List<EventFlag>();
        public static List<EventKind> eventKindList = new List<EventKind>();
        public static List<BootPlch> bootPlchList = new List<BootPlch>();
        public static List<Bitmap> itemIconsList = new List<Bitmap>();
        public static List<Item> itemList = new List<Item>();
        public static List<string[]> itemInfo = new List<string[]>();
        public static List<FieldItem> fieldItemList = new List<FieldItem>();
        public static List<string> textList = new List<string>();
        public static List<BootOtherFlag> bootOtherFlagList = new List<BootOtherFlag>();
        public static List<BootSpc> bootSpcList = new List<BootSpc>();
        public static List<BootStage> bootStageList = new List<BootStage>();
        public static List<BootSphere> bootSphereList = new List<BootSphere>();
        public static List<BootItem> bootItemList = new List<BootItem>();
        public static List<BootTime> bootTimeList = new List<BootTime>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openCCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the EVENT.CCS File";
            ofd.Filter = "EVENT.CCS File|EVENT.CCS";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ccsList.Clear();
                CCSF ccs = new CCSF();
                string directory = Path.GetDirectoryName(ofd.FileName);
                string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                if (File.Exists(Path.Combine(directory, fileName) + "TXT.CCS"))
                {
                    ccs.OpenCCS(Path.Combine(directory, fileName) + "TXT.CCS");
                    ccsList.Add(ccs);
                }
                else
                {
                    MessageBox.Show("File \"EVENTTXT.CCS\" not found, opening in \"Narutimate Accel 2\" mode.");
                    ccsList.Add(ccs);
                    isNA2 = true;
                }
                ccs = new CCSF();
                ccs.OpenCCS(ofd.FileName);
                ccsList.Add(ccs);
                btnEditBattleData.Enabled = true;
                btnEditCharData.Enabled = true;
                btnEditScriptList.Enabled = true;
                btnEditItemList.Enabled = true;
                btnEditFieldItemList.Enabled = true;
                btnTest.Enabled = true;
                saveCCSToolStripMenuItem.Enabled = true;
                pictureBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBattleData form = new EditBattleData();
            MemoryStream ms = new MemoryStream(CCSF.GetBlockData(ccsList[isNA2 == true ? 1 : 0], isNA2 == true ? "battledata": "battledatatxt"));
            if(form.battleDataList.Count == 0)
            {
                for (int i = 0; i < ms.Length / 0xA4; i++)
                {
                    byte[] battleDataBlock = new byte[0xA4];
                    ms.Read(battleDataBlock, 0, 0xA4);
                    BattleData battleData = BattleData.Read(battleDataBlock);
                    form.battleDataBlocksList.Add(battleDataBlock);
                    form.battleDataList.Add(battleData);
                    form.listBox1.Items.Add($"{i}: {battleData.battleName}");
                }
            }
            form.listBox1.SelectedIndex = 0;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCharData charDataEditor = new EditCharData();
            if(charDataList.Count == 0)
            {
                ReadCharDataBlocks();
            }
            for(int i = 0; i < charDataList.Count; i++)
            {
                charDataEditor.listBox1.Items.Add($"{i}: {charDataList[i].charName}");
            }
            charDataEditor.listBox1.SelectedIndex = 0;
            charDataEditor.Show();
        }
        public static void ReadCharDataBlocks()
        {
            MemoryStream ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "chardata"));
            string magic = Util.ReadStringFromMemory(ms, 0x7C, (int)ms.Length, "UTF-8");
            int charDataCount = int.Parse(Util.ReadStringFromMemory(ms, 0x7C, (int)ms.Length, "UTF-8"));
            for (int i = 0; i < charDataCount; i++)
            {
                byte[] charDataBlock = new byte[0x128];
                ms.Read(charDataBlock, 0, charDataBlock.Length);
                charDataBlocksList.Add(charDataBlock);
                charDataList.Add(CharData.Read(charDataBlock));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EditScriptList form = new EditScriptList();
            if(ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(CCSF.GetBlockData(ccsList[1], "ccs_tbl"), CCSF.GetBlockData(ccsList[1], "event_id"));
            }
            form.addList();
            form.listBox1.SelectedIndex = 0;
            form.Show();
        }
        private void saveCCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "EVENT.CCS File|EVENT.CCS";
            sfd.FileName = "EVENT.CCS";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(sfd.FileName);
                if (isNA2 == true)
                {
                    CCSF.WriteCCS(ccsList[0], Path.Combine(path, "EVENT.CCS"));
                }
                else
                {
                    CCSF.WriteCCS(ccsList[1], Path.Combine(path, "EVENT.CCS"));
                    CCSF.WriteCCS(ccsList[0], Path.Combine(path, "EVENTTXT.CCS"));
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (itemIconsList.Count == 0)
            {
                Bitmap advItem = new Bitmap("textures/advitem.png");
                int pieceHeight = 32;
                int pieceWidth = 32;
                int numRows = advItem.Height / pieceHeight;
                int numCols = advItem.Width / pieceWidth;
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numCols; col++)
                    {
                        Rectangle pieceRect = new Rectangle(col * pieceWidth, row * pieceHeight, pieceWidth, pieceHeight);
                        Bitmap piece = new Bitmap(pieceWidth, pieceHeight);

                        using (Graphics g = Graphics.FromImage(piece))
                        {
                            g.DrawImage(advItem, new Rectangle(0, 0, pieceWidth, pieceHeight), pieceRect, GraphicsUnit.Pixel);
                        }

                        itemIconsList.Add(piece);
                    }
                }
            }
            if(itemList.Count == 0)
            {
                ReadItemBlocks();
            }
            EditItem form = new EditItem();
            for (int i = 3; i < itemInfo.Count; i++)
            {
                form.listBox1.Items.Add($"{i - 3}: {itemInfo[i][0]}");
            }
            form.CreateIcon();
            form.Show();
            form.listBox1.SelectedIndex = 0;
        }
        public static void ReadItemBlocks()
        {
            MemoryStream ms = new MemoryStream(CCSF.GetBlockData(ccsList[isNA2 == true ? 1 : 0], isNA2 == true ? "item" : "itemtxt"));
            int count = int.Parse(Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8"));
            for (int i = 0; i < count; i++)
            {
                byte[] itemBlock = new byte[0x1C];
                ms.Read(itemBlock, 0, itemBlock.Length);
                itemList.Add(Item.Read(itemBlock));
            }
            string encoding = isNA2 == true ? "shift-jis" : "ISO-8859-1";
            for (int i = 0; i < count + 3; i++)
            {
                string itemName = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, encoding);
                string itemDescription = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, encoding);
                itemInfo.Add(new string[] { itemName, itemDescription });
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditFieldItem form = new EditFieldItem();
            if (itemList.Count == 0)
            {
                ReadItemBlocks();
            }
            if(form.cmbItemID.Items.Count == 0)
            {
                for(int i = 3; i < itemInfo.Count; i++)
                {
                    form.cmbItemID.Items.Add(itemInfo[i][0]);
                }
            }
            if(fieldItemList.Count == 0)
            {
                MemoryStream ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "fielditem"));
                int count = int.Parse(Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8"));
                for (int i = 0; i < count; i++)
                {
                    byte[] currentItemFieldBlock = new byte[0x1C];
                    ms.Read(currentItemFieldBlock, 0, currentItemFieldBlock.Length);
                    fieldItemList.Add(FieldItem.Read(currentItemFieldBlock));
                }
            }
            for(int i = 0; i < fieldItemList.Count; i++)
            {
                int stageID = (int)fieldItemList[i].stageID;
                form.listBox1.Items.Add($"{i}: {form.cmbStageID.Items[stageID]}");
            }
            form.listBox1.SelectedIndex = 0;
            form.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Teste form = new Teste();
            int maxValue = 0;
            if (ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(CCSF.GetBlockData(ccsList[1], "ccs_tbl"), CCSF.GetBlockData(ccsList[1], "event_id"));
            }
            MemoryStream ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootstage"));
            if (bootStageList.Count == 0)
            {
                byte[] stageBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(stageBlock, 0, stageBlock.Length);
                    bootStageList.Add(BootStage.Read(stageBlock));
                    if (bootStageList[i].activation > 4)
                    {
                        MessageBox.Show($"{bootStageList[i].treeIndex}");
                    }
                }
            }
            foreach(var stage in bootStageList)
            {
                maxValue = Math.Max(maxValue, (int)stage.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootevkind"));
            if (eventKindList.Count == 0)
            {
                byte[] eventKindBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(eventKindBlock, 0, eventKindBlock.Length);
                    eventKindList.Add(EventKind.Read(eventKindBlock));
                }
            }
            foreach (var kind in eventKindList)
            {
                maxValue = Math.Max(maxValue, (int)kind.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "boottalk"));
            if (bootTalkList.Count == 0)
            {
                byte[] bootTalkBlock = new byte[0xA];
                for (int i = 0; i < ms.Length / 0xA; i++)
                {
                    ms.Read(bootTalkBlock, 0, bootTalkBlock.Length);
                    bootTalkList.Add(BootTalk.Read(bootTalkBlock));
                }
            }
            foreach (var talk in bootTalkList)
            {
                maxValue = Math.Max(maxValue, (int)talk.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "boototherflag"));
            if (bootOtherFlagList.Count == 0)
            {
                byte[] otherFlagBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(otherFlagBlock, 0, otherFlagBlock.Length);
                    bootOtherFlagList.Add(BootOtherFlag.Read(otherFlagBlock));
                }
            }
            foreach (var other in bootOtherFlagList)
            {
                maxValue = Math.Max(maxValue, (int)other.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "booteventflag"));
            if (eventFlagList.Count == 0)
            {
                byte[] eventFlagBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(eventFlagBlock, 0, eventFlagBlock.Length);
                    eventFlagList.Add(EventFlag.Read(eventFlagBlock));
                }
            }
            foreach (var eventf in eventFlagList)
            {
                maxValue = Math.Max(maxValue, (int)eventf.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootplch"));
            if (bootPlchList.Count == 0)
            {
                byte[] plchBlock = new byte[0x4];
                for (int i = 0; i < ms.Length / 0x4; i++)
                {
                    ms.Read(plchBlock, 0, plchBlock.Length);
                    bootPlchList.Add(BootPlch.Read(plchBlock));
                }
            }
            foreach (var plch in bootPlchList)
            {
                maxValue = Math.Max(maxValue, (int)plch.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootsphere"));
            if (bootSphereList.Count == 0)
            {
                byte[] sphereBlock = new byte[0x18];
                for (int i = 0; i < ms.Length / 0x18; i++)
                {
                    ms.Read(sphereBlock, 0, sphereBlock.Length);
                    bootSphereList.Add(BootSphere.Read(sphereBlock));
                }
            }
            foreach (var sphere in bootSphereList)
            {
                maxValue = Math.Max(maxValue, (int)sphere.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootitem"));
            if (bootItemList.Count == 0)
            {
                byte[] bootItemBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(bootItemBlock, 0, bootItemBlock.Length);
                    bootItemList.Add(BootItem.Read(bootItemBlock));
                }
            }
            foreach (var item in bootItemList)
            {
                maxValue = Math.Max(maxValue, (int)item.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "boottime"));
            if (bootTimeList.Count == 0)
            {
                byte[] bootTimeBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(bootTimeBlock, 0, bootTimeBlock.Length);
                    bootTimeList.Add(BootTime.Read(bootTimeBlock));
                    if (bootTimeList[i].treeIndex >= maxValue)
                    {
                        maxValue = (int)bootTimeList[i].treeIndex;
                    }
                }
            }
            foreach (var time in bootTimeList)
            {
                maxValue = Math.Max(maxValue, (int)time.treeIndex);
            }
            ms = new MemoryStream(CCSF.GetBlockData(ccsList[1], "bootspc"));
            if (bootSpcList.Count == 0)
            {
                byte[] spcBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(spcBlock, 0, spcBlock.Length);
                    bootSpcList.Add(BootSpc.Read(spcBlock));
                }
            }
            foreach (var spc in bootSpcList)
            {
                maxValue = Math.Max(maxValue, (int)spc.treeIndex);
            }
            for (int i = 0; i < maxValue + 1; i++)
            {
                ListViewItem item = new ListViewItem($"");
                form.listView1.Items.Add(item);
            }
            for (int i = 0; i < eventKindList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)eventKindList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)eventKindList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Kind");
                form.listView1.Items[(int)eventKindList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootTalkList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootTalkList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootTalkList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Talk");
                form.listView1.Items[(int)bootTalkList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootOtherFlagList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootOtherFlagList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootOtherFlagList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Other");
                form.listView1.Items[(int)bootOtherFlagList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootStageList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootStageList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootStageList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Stage");
                form.listView1.Items[(int)bootStageList[i].treeIndex] = item;
            }
            for (int i = 0; i < eventFlagList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)eventFlagList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)eventFlagList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Event");
                form.listView1.Items[(int)eventFlagList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootPlchList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootPlchList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootPlchList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Player");
                form.listView1.Items[(int)bootPlchList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootSphereList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootSphereList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootSphereList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Sphere");
                form.listView1.Items[(int)bootSphereList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootItemList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootItemList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootItemList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Item");
                form.listView1.Items[(int)bootItemList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootTimeList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootTimeList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootTimeList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Time");
                form.listView1.Items[(int)bootTimeList[i].treeIndex] = item;
            }
            for (int i = 0; i < bootSpcList.Count; i++)
            {
                ListViewItem item = new ListViewItem($"{(int)bootSpcList[i].treeIndex}");
                item.SubItems.Add($"{ScriptList.event_id[(int)bootSpcList[i].eventID]}");
                item.SubItems.Add($"{i}");
                item.SubItems.Add("Team");
                form.listView1.Items[(int)bootSpcList[i].treeIndex] = item;
            }
            form.cmbEventEventID.Items.AddRange(ScriptList.event_id.ToArray());
            if (form.listView1.Items.Count != 0)
            {
                form.listView1.Items[0].Selected = true;
            }
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UN5 EVENT.CCS Editor, version 1.0\n\nMade by zMath3usMSF.");
        }
    }
}
