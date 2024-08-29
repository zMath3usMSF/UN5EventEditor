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

namespace UN5_Event_Editor
{
    public partial class Form1 : Form
    {
        public static List<CCSF> ccsList = new List<CCSF>();
        public static List<CharData> charDataList = new List<CharData>();
        public static List<byte[]> charDataBlocksList = new List<byte[]>();
        public static List<BootTalk> bootTalkList = new List<BootTalk>();
        public static List<EventFlag> eventFlagList = new List<EventFlag>();
        public static List<EventKind> eventKindList = new List<EventKind>();
        public static List<Plch> plchList = new List<Plch>();
        public static List<Bitmap> itemIconsList = new List<Bitmap>();
        public static List<Item> itemList = new List<Item>();
        public static List<string[]> itemInfo = new List<string[]>();

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
                bool isNA2 = false;
                ccsList.Clear();
                CCSF ccs = new CCSF();
                CCSFTXT.textList.Clear();

                string directory = Path.GetDirectoryName(ofd.FileName);
                string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                if (File.Exists(Path.Combine(directory, fileName) + "TXT.CCS"))
                {
                    ccs.OpenCCS(Path.Combine(directory, fileName) + "TXT.CCS");
                    ccsList.Add(ccs);
                    CCSFTXT.ReadCCSFTXT(ccsList[0].blocks[3].Data, "ISO-8859-1");
                }
                else
                {
                    ccsList.Add(ccs);
                    isNA2 = true;
                }

                ccs = new CCSF();
                ccs.OpenCCS(ofd.FileName);
                ccsList.Add(ccs);
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBattleData battleDataEditor = new EditBattleData();
            if(battleDataEditor.battleDataList.Count == 0)
            {
                for (int i = 0; i < ccsList[0].blocks[3].Data.Length / 0xA4; i++)
                {
                    byte[] currentBattleDataBlock = new byte[0xA4];
                    Array.Copy(ccsList[0].blocks[3].Data, i * 0xA4, currentBattleDataBlock, 0, 0xA4);
                    BattleData battleData = BattleData.Read(currentBattleDataBlock);
                    battleDataEditor.battleDataBlocksList.Add(currentBattleDataBlock);
                    battleDataEditor.battleDataList.Add(battleData);
                    battleDataEditor.listBox1.Items.Add($"{i}: {battleData.battleName}");
                }
            }
            battleDataEditor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCharData charDataEditor = new EditCharData();
            if(charDataList.Count == 0)
            {
                MemoryStream ms = new MemoryStream(ccsList[1].blocks[16].Data);
                List<char> chars = new List<char>();
                int count = 0;
                while (count != 2)
                {
                    char currentChar = (char)ms.ReadByte();
                    chars.Add(currentChar);
                    if (currentChar == '|')
                    {
                        count++;
                    }
                }
                string header = string.Concat(chars.ToArray());
                int charDataCount = int.Parse(header.Split('|')[1]);
                for (int i = 0; i < charDataCount; i++)
                {
                    byte[] charDataBlock = new byte[0x128];
                    ms.Read(charDataBlock, 0, charDataBlock.Length);
                    charDataBlocksList.Add(charDataBlock);
                    charDataList.Add(CharData.Read(charDataBlock));
                }
            }
            for(int i = 0; i < charDataList.Count; i++)
            {
                charDataEditor.listBox1.Items.Add($"{i}: {charDataList[i].charName}");
            }
            charDataEditor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditScriptList form = new EditScriptList();
            if(ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(ccsList[1].blocks[17].Data, ccsList[1].blocks[18].Data);
            }
            form.addList();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit_Boot_Talk form = new Edit_Boot_Talk();
            MemoryStream ms = new MemoryStream(ccsList[1].blocks[16].Data);
            if (charDataList.Count == 0)
            {
                List<char> chars = new List<char>();
                int count = 0;
                while (count != 2)
                {
                    char currentChar = (char)ms.ReadByte();
                    chars.Add(currentChar);
                    if (currentChar == '|')
                    {
                        count++;
                    }
                }
                string header = string.Concat(chars.ToArray());
                int charDataCount = int.Parse(header.Split('|')[1]);
                for (int i = 0; i < charDataCount; i++)
                {
                    byte[] charDataBlock = new byte[0x128];
                    ms.Read(charDataBlock, 0, charDataBlock.Length);
                    charDataBlocksList.Add(charDataBlock);
                    charDataList.Add(CharData.Read(charDataBlock));
                }
            }
            if (ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(ccsList[1].blocks[17].Data, ccsList[1].blocks[18].Data);
            }
            if(bootTalkList.Count == 0)
            {
                ms = new MemoryStream(ccsList[1].blocks[14].Data);
                byte[] bootTalkBlock = new byte[0xA];
                for (int i = 0; i < ms.Length / 0xA; i++)
                {
                    ms.Read(bootTalkBlock, 0, bootTalkBlock.Length);
                    bootTalkList.Add(BootTalk.Read(bootTalkBlock));
                }
            }
            for(int i = 0; i < bootTalkList.Count; i++)
            {
                form.listBox1.Items.Add($"{i}: {charDataList[(int)bootTalkList[i].charID].charName}");
            }
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            for(int i = 0; i < charDataList.Count; i++)
            {
                form.cmbCharID.Items.Add(charDataList[i].charName);
            }
            form.Show();
        }

        private void saveCCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCSF.WriteCCS(ccsList[1]);
            CCSF.WriteCCS(ccsList[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditEventFlag form = new EditEventFlag();
            MemoryStream ms = new MemoryStream(ccsList[1].blocks[4].Data);
            if (eventFlagList.Count == 0)
            {
                byte[] eventFlagBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(eventFlagBlock, 0, eventFlagBlock.Length);
                    eventFlagList.Add(EventFlag.Read(eventFlagBlock));
                }
            }
            if (ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(ccsList[1].blocks[17].Data, ccsList[1].blocks[18].Data);
            }
            for (int i = 0; i < eventFlagList.Count; i++)
            {
                form.listBox1.Items.Add($"{i}: {ScriptList.event_id[(int)eventFlagList[i].eventID]}");
            }
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditEventKind form = new EditEventKind();
            MemoryStream ms = new MemoryStream(ccsList[1].blocks[5].Data);
            if (eventKindList.Count == 0)
            {
                byte[] eventKindBlock = new byte[0x8];
                for (int i = 0; i < ms.Length / 0x8; i++)
                {
                    ms.Read(eventKindBlock, 0, eventKindBlock.Length);
                    eventKindList.Add(EventKind.Read(eventKindBlock));
                }
            }
            if (ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(ccsList[1].blocks[17].Data, ccsList[1].blocks[18].Data);
            }
            for (int i = 0; i < eventKindList.Count; i++)
            {
                form.listBox1.Items.Add($"{i}: {ScriptList.event_id[(int)eventKindList[i].eventID]}");
            }
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditPlchList form = new EditPlchList();
            MemoryStream ms = new MemoryStream(ccsList[1].blocks[8].Data);
            if (plchList.Count == 0)
            {
                byte[] plchBlock = new byte[0x4];
                for (int i = 0; i < ms.Length / 0x4; i++)
                {
                    ms.Read(plchBlock, 0, plchBlock.Length);
                    plchList.Add(Plch.Read(plchBlock));
                }
            }
            if (ScriptList.ccs_tbl.Count == 0)
            {
                ScriptList.Read(ccsList[1].blocks[17].Data, ccsList[1].blocks[18].Data);
            }
            for (int i = 0; i < plchList.Count; i++)
            {
                form.listBox1.Items.Add($"{i}: {ScriptList.event_id[(int)plchList[i].eventID]}");
            }
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            form.Show();
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
                MemoryStream ms = new MemoryStream(ccsList[0].blocks[4].Data);
                int count = int.Parse(Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8"));
                for (int i = 0; i < count; i++)
                {
                    byte[] itemBlock = new byte[0x1C];
                    ms.Read(itemBlock, 0, itemBlock.Length);
                    itemList.Add(Item.Read(itemBlock));
                }
                for (int i = 0; i < count + 3; i++)
                {
                    string itemName = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "ISO-8859-1");
                    string itemDescription = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "ISO-8859-1");
                    itemInfo.Add(new string[] { itemName, itemDescription });
                }
            }
            EditItem form = new EditItem();
            for (int i = 3; i < itemInfo.Count; i++)
            {
                form.listBox1.Items.Add($"{i - 3}: {itemInfo[i][0]}");
            }
            form.Show();
        }
    }
}
