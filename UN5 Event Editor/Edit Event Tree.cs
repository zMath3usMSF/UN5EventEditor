using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UN5_Event_Editor
{
    public partial class Teste : Form
    {
        private ListViewItem draggedItem;
        private Timer scrollTimer;
        private const int ScrollSpeed = 10;
        public Teste()
        {
            InitializeComponent();
            listView1.ItemDrag += ListView_ItemDrag;
            listView1.DragOver += ListView_DragOver;
            listView1.DragDrop += ListView_DragDrop;
            scrollTimer = new Timer
            {
                Interval = 100
            };
            scrollTimer.Tick += ScrollTimer_Tick;

            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;

            listView1.MouseClick += ListView1_MouseClick;
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(listView1.SelectedIndices.Count == 0)
                {
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[2].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[2].Enabled = true;
                }
                contextMenuStrip1.Show(listView1, e.Location);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1)
            {
                if (Form1.charDataList.Count == 0)
                {
                    Form1.ReadCharDataBlocks();
                }
                if(cmbTalkCharID.Items.Count == 0)
                {
                    for (int i = 0; i < Form1.charDataList.Count; i++)
                    {
                        cmbTalkCharID.Items.Add(Form1.charDataList[i].charName);
                    }
                }
                if (Form1.itemList.Count == 0)
                {
                    Form1.ReadItemBlocks();
                }
                if (cmbItemItemID.Items.Count == 0)
                {
                    for (int i = 3; i < Form1.itemInfo.Count; i++)
                    {
                        cmbItemItemID.Items.Add(Form1.itemInfo[i][0]);
                    }
                }
                grpKind.Visible = false;
                grpOther.Visible = false;
                grpEvent.Visible = false;
                grpTalk.Visible = false;
                grpStage.Visible = false;
                grpSphere.Visible = false;
                grpSpc.Visible = false;
                grpTime.Visible = false;
                grpItem.Visible = false;
                int index = listView1.SelectedIndices[0];
                string type = listView1.Items[index].SubItems[3].Text;
                switch (type)
                {
                    case "Kind":
                        grpKind.Visible = true;
                        for (int i = 0; i <  Form1.eventKindList.Count; i++)
                        {
                            if (index == Form1.eventKindList[i].treeIndex)
                            {
                                cmbKind.SelectedIndex = (int)Form1.eventKindList[i].kind;
                            }
                        }
                        break;
                    case "Other":
                        grpOther.Visible = true;
                        for (int i = 0; i <  Form1.bootOtherFlagList.Count; i++)
                        {
                            if (index == Form1.bootOtherFlagList[i].treeIndex)
                            {
                                numOtherProgressFlag.Value = Form1.bootOtherFlagList[i].progressFlag;
                                numOtherValue.Value = Form1.bootOtherFlagList[i].value;
                                cmbOtherConditional.SelectedIndex = (int)Form1.bootOtherFlagList[i].conditional;
                            }
                        }
                        break;
                    case "Event":
                        grpEvent.Visible = true;
                        for (int i = 0; i <  Form1.eventFlagList.Count; i++)
                        {
                            var cEvent = Form1.eventFlagList[i];
                            if (index == Form1.eventFlagList[i].treeIndex)
                            {
                                cmbEventEventID.SelectedIndex = (int)Form1.eventFlagList[i].eventIDCheck;
                                cmbEventState.SelectedIndex = cEvent.valueState[cEvent.value];
                                cmbEventConditional.SelectedIndex = (int)Form1.eventFlagList[i].conditional;
                            }
                        }
                        break;
                    case "Talk":
                        grpTalk.Visible = true;
                        for (int i = 0; i <  Form1.bootTalkList.Count; i++)
                        {
                            if (index == Form1.bootTalkList[i].treeIndex)
                            {
                                cmbTalkCharID.SelectedIndex = (int)Form1.bootTalkList[i].charID;
                                cmbTalkStageID.SelectedIndex = (int)Form1.bootTalkList[i].stageID;
                                cmbTalkAutoTalk.SelectedIndex = (int)Form1.bootTalkList[i].autoTalk;
                            }
                        }
                        break;
                    case "Stage":
                        grpStage.Visible = true;
                        for (int i = 0; i <  Form1.bootStageList.Count; i++)
                        {
                            if (index == Form1.bootStageList[i].treeIndex)
                            {
                                cmbStageStageID.SelectedIndex = (int)Form1.bootStageList[i].stageID;
                                cmbStageActivation.SelectedIndex = (int)Form1.bootStageList[i].activation;
                            }
                        }
                        break;
                    case "Sphere":
                        grpSphere.Visible = true;
                        for (int i = 0; i <  Form1.bootSphereList.Count; i++)
                        {
                            if (index == Form1.bootSphereList[i].treeIndex)
                            {
                                cmbSphereStageID.SelectedIndex = (int)Form1.bootSphereList[i].stageID;
                                numSpherePosX.Value = Form1.bootSphereList[i].posX;
                                numSpherePosY.Value = Form1.bootSphereList[i].posY;
                                numSpherePosZ.Value = Form1.bootSphereList[i].posZ;
                                numSphereScale.Value = Form1.bootSphereList[i].scale;
                                cmbSphereActivation.SelectedIndex = (int)Form1.bootSphereList[i].activationMode;
                                cmbSphereConfirmation.SelectedIndex = (int)Form1.bootSphereList[i].confirmationMode;
                            }
                        }
                        break;
                    case "Team":
                        grpSpc.Visible = true;
                        for (int i = 0; i <  Form1.bootSpcList.Count; i++)
                        {
                            if (index == Form1.bootSpcList[i].treeIndex)
                            {
                                cmbSpcCharacter.SelectedIndex = (int)Form1.bootSpcList[i].charID;
                                cmbSpcTeam.SelectedIndex = (int)Form1.bootSpcList[i].isTeam;
                            }
                        }
                        break;
                    case "Time":
                        grpTime.Visible = true;
                        for (int i = 0; i <  Form1.bootTimeList.Count; i++)
                        {
                            if (index == Form1.bootTimeList[i].treeIndex)
                            {
                                numTimeUnk2.Value = Form1.bootTimeList[i].unk2;
                            }
                        }
                        break;
                    case "Item":
                        grpItem.Visible = true;
                        for (int i = 0; i <  Form1.bootItemList.Count; i++)
                        {
                            if (index == Form1.bootItemList[i].treeIndex)
                            {
                                cmbItemItemID.SelectedIndex = (int)Form1.bootItemList[i].itemID;
                                numStockCount.Value = Form1.bootItemList[i].stockCount;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void ListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            draggedItem = e.Item as ListViewItem;
            if (draggedItem != null)
            {
                DoDragDrop(draggedItem, DragDropEffects.Move);
            }
        }

        private void ListView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

            Point point = listView1.PointToClient(new Point(e.X, e.Y));

            StartScroll(point);
        }

        private void ListView_DragDrop(object sender, DragEventArgs e)
        {
            scrollTimer.Stop();

            Point point = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem targetItem = listView1.GetItemAt(point.X, point.Y);

            if (draggedItem != null && targetItem != null && targetItem != draggedItem)
            {
                List<ListViewItem> selectedItems = new List<ListViewItem>();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    selectedItems.Add(item);
                }

                int targetIndex = listView1.Items.IndexOf(targetItem);

                foreach (ListViewItem item in selectedItems)
                {
                    listView1.Items.Remove(item);
                }

                if (targetIndex > listView1.Items.Count)
                {
                    targetIndex = listView1.Items.Count;
                }

                foreach (ListViewItem item in selectedItems)
                {
                    listView1.Items.Insert(targetIndex, item);
                    targetIndex++;
                }

                listView1.SelectedItems.Clear();
                foreach (ListViewItem item in selectedItems)
                {
                    item.Selected = true;
                }

                draggedItem = null;

                UpdateListAndBlocks();
            }
        }
        public void UpdateListAndBlocks()
        {
            MemoryStream mKind = new MemoryStream();
            MemoryStream mOther = new MemoryStream();
            MemoryStream mEvent = new MemoryStream();
            MemoryStream mTalk = new MemoryStream();
            MemoryStream mStage = new MemoryStream();
            MemoryStream mSphere = new MemoryStream();
            MemoryStream mSpc = new MemoryStream();
            MemoryStream mTime = new MemoryStream();
            MemoryStream mItem = new MemoryStream();
            MemoryStream mPlch = new MemoryStream();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = $"{i}";
                string type = listView1.Items[i].SubItems[3].Text;
                int flagIndex;
                switch (type)
                {
                    case "Kind":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if(Form1.eventKindList[flagIndex] != null)
                        {
                            Form1.eventKindList[flagIndex].treeIndex = (uint)i;
                            byte[] kindBlock = EventKind.Write(Form1.eventKindList[flagIndex]);
                            mKind.Write(kindBlock, 0, 0x8);
                        }
                        break;
                    case "Other":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootOtherFlagList[flagIndex] != null)
                        {
                            Form1.bootOtherFlagList[flagIndex].treeIndex = (uint)i;
                            byte[] otherBlock = BootOtherFlag.Write(Form1.bootOtherFlagList[flagIndex]);
                            mOther.Write(otherBlock, 0, 0x8);
                        }
                        break;
                    case "Event":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.eventFlagList[flagIndex] != null)
                        {
                            Form1.eventFlagList[flagIndex].treeIndex = (uint)i;
                            byte[] eventBlock = EventFlag.Write(Form1.eventFlagList[flagIndex]);
                            mEvent.Write(eventBlock, 0, 0x8);
                        }
                        break;
                    case "Talk":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootTalkList[flagIndex] != null)
                        {
                            Form1.bootTalkList[flagIndex].treeIndex = (uint)i;
                            byte[] talkBlock = BootTalk.Write(Form1.bootTalkList[flagIndex]);
                            mTalk.Write(talkBlock, 0, 0xA);
                        }
                        break;
                    case "Stage":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootStageList[flagIndex] != null)
                        {
                            Form1.bootStageList[flagIndex].treeIndex = (uint)i;
                            byte[] stageBlock = BootStage.Write(Form1.bootStageList[flagIndex]);
                            mStage.Write(stageBlock, 0, 0x8);
                        }
                        break;
                    case "Sphere":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootSphereList[flagIndex] != null)
                        {
                            Form1.bootSphereList[flagIndex].treeIndex = (uint)i;
                            byte[] sphereBlock = BootSphere.Write(Form1.bootSphereList[flagIndex]);
                            mSphere.Write(sphereBlock, 0, 0x18);
                        }
                        break;
                    case "Team":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootSpcList[flagIndex] != null)
                        {
                            Form1.bootSpcList[flagIndex].treeIndex = (uint)i;
                            byte[] spcBlock = BootSpc.Write(Form1.bootSpcList[flagIndex]);
                            mSpc.Write(spcBlock, 0, 0x8);
                        }
                        break;
                    case "Time":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootTimeList[flagIndex] != null)
                        {
                            Form1.bootTimeList[flagIndex].treeIndex = (uint)i;
                            byte[] timeBlock = BootTime.Write(Form1.bootTimeList[flagIndex]);
                            mTime.Write(timeBlock, 0, 0x8);
                        }
                        break;
                    case "Item":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootItemList[flagIndex] != null)
                        {
                            Form1.bootItemList[flagIndex].treeIndex = (uint)i;
                            byte[] itemBlock = BootItem.Write(Form1.bootItemList[flagIndex]);
                            mItem.Write(itemBlock, 0, 0x8);
                        }
                        break;
                    case "Player":
                        flagIndex = int.Parse(listView1.Items[i].SubItems[2].Text);
                        if (Form1.bootPlchList[flagIndex] != null)
                        {
                            Form1.bootPlchList[flagIndex].treeIndex = (uint)i;
                            byte[] plchBlock = BootPlch.Write(Form1.bootPlchList[flagIndex]);
                            mPlch.Write(plchBlock, 0, 0x4);
                        }
                        break;
                    default:
                        break;
                }
            }
            CCSF.SetBlockData(Form1.ccsList[1], "bootevkind", mKind.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "boototherflag", mOther.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "booteventflag", mEvent.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "boottalk", mTalk.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "bootstage", mStage.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "bootsphere", mSphere.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "bootspc", mSpc.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "boottime", mTime.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "bootitem", mItem.ToArray());
            CCSF.SetBlockData(Form1.ccsList[1], "bootplch", mPlch.ToArray());
        }
        private void StartScroll(Point cursorPosition)
        {
            int borderDistance = 30;

            if (cursorPosition.Y < borderDistance)
            {
                listView1.TopItem = listView1.Items[Math.Max(0, listView1.TopItem.Index - ScrollSpeed)];
                scrollTimer.Start();
            }
            else if (cursorPosition.Y > listView1.ClientSize.Height - borderDistance)
            {
                listView1.TopItem = listView1.Items[Math.Min(listView1.Items.Count - 1, listView1.TopItem.Index + ScrollSpeed)];
                scrollTimer.Start();
            }
            else
            {
                scrollTimer.Stop();
            }
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            if (draggedItem != null)
            {
                Point cursorPosition = listView1.PointToClient(MousePosition);
                StartScroll(cursorPosition);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            string type = listView1.Items[index].SubItems[3].Text;
            MemoryStream ms = new MemoryStream();
            switch (type)
            {
                case "Kind":
                    ms = new MemoryStream();
                    foreach (var kind in Form1.eventKindList)
                    {
                        if (kind.treeIndex == index)
                        {
                            kind.kind = (uint)cmbKind.SelectedIndex;
                        }
                        byte[] kindBlock = EventKind.Write(kind);
                        ms.Write(kindBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "bootevkind", ms.ToArray());
                    break;
                case "Other":
                    ms = new MemoryStream();
                    foreach (var other in Form1.bootOtherFlagList)
                    {
                        if (other.treeIndex == index)
                        {
                            other.progressFlag = (uint)numOtherProgressFlag.Value;
                            other.value = (uint)numOtherValue.Value;
                            other.conditional = (uint)cmbOtherConditional.SelectedIndex;
                        }
                        byte[] otherBlock = BootOtherFlag.Write(other);
                        ms.Write(otherBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "boototherflag", ms.ToArray());
                    break;
                case "Event":
                    ms = new MemoryStream();
                    foreach (var eventf in Form1.eventFlagList)
                    {
                        if (eventf.treeIndex == index)
                        {
                            List<uint> list = eventf.valueState.Keys.ToList();
                            eventf.eventIDCheck = (uint)cmbEventEventID.SelectedIndex;
                            eventf.value = list[cmbEventState.SelectedIndex];
                            eventf.conditional = (uint)cmbEventConditional.SelectedIndex;
                        }
                        byte[] eventBlock = EventFlag.Write(eventf);
                        ms.Write(eventBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "booteventflag", ms.ToArray());
                    break;
                case "Talk":
                    ms = new MemoryStream();
                    foreach (var talk in Form1.bootTalkList)
                    {
                        if (talk.treeIndex == index)
                        {
                            talk.charID = (uint)cmbTalkCharID.SelectedIndex;
                            talk.stageID = (uint)cmbTalkStageID.SelectedIndex;
                            talk.autoTalk = (uint)cmbTalkAutoTalk.SelectedIndex;
                        }
                        byte[] talkBlock = BootTalk.Write(talk);
                        ms.Write(talkBlock, 0, 0xA);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "boottalk", ms.ToArray());
                    break;
                case "Stage":
                    ms = new MemoryStream();
                    foreach (var stage in Form1.bootStageList)
                    {
                        if (stage.treeIndex == index)
                        {
                            stage.stageID = (uint)cmbStageStageID.SelectedIndex;
                            stage.activation = (uint)cmbStageActivation.SelectedIndex;
                        }
                        byte[] stageBlock = BootStage.Write(stage);
                        ms.Write(stageBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "bootstage", ms.ToArray());
                    break;
                case "Sphere":
                    ms = new MemoryStream();
                    foreach (var sphere in Form1.bootSphereList)
                    {
                        if (sphere.treeIndex == index)
                        {
                            sphere.posX = (int)numSpherePosX.Value;
                            sphere.posY = (int)numSpherePosY.Value;
                            sphere.posZ = (int)numSpherePosZ.Value;
                            sphere.scale = (uint)numSphereScale.Value;
                            sphere.stageID = (uint)cmbSphereStageID.SelectedIndex;
                            sphere.activationMode = (uint)cmbSphereActivation.SelectedIndex;
                            sphere.confirmationMode = (uint)cmbSphereConfirmation.SelectedIndex;
                        }
                        byte[] sphereBlock = BootSphere.Write(sphere);
                        ms.Write(sphereBlock, 0, 0x18);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "bootsphere", ms.ToArray());
                    break;
                case "Team":
                    ms = new MemoryStream();
                    foreach (var spc in Form1.bootSpcList)
                    {
                        if (spc.treeIndex == index)
                        {
                            spc.charID = (uint)cmbSpcCharacter.SelectedIndex;
                            spc.isTeam = (uint)cmbSpcTeam.SelectedIndex;
                        }
                        byte[] spcBlock = BootSpc.Write(spc);
                        ms.Write(spcBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "bootspc", ms.ToArray());
                    break;
                case "Time":
                    ms = new MemoryStream();
                    foreach (var time in Form1.bootTimeList)
                    {
                        if (time.treeIndex == index)
                        {
                            time.unk2 = (int)numTimeUnk2.Value;
                        }
                        byte[] timeBlock = BootTime.Write(time);
                        ms.Write(timeBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "boottime", ms.ToArray());
                    break;
                case "Item":
                    ms = new MemoryStream();
                    foreach (var item in Form1.bootItemList)
                    {
                        if (item.treeIndex == index)
                        {
                            item.itemID = (uint)cmbItemItemID.SelectedIndex;
                            item.stockCount = (uint)numStockCount.Value;
                        }
                        byte[] itemBlock = BootItem.Write(item);
                        ms.Write(itemBlock, 0, 0x8);
                    }
                    CCSF.SetBlockData(Form1.ccsList[1], "bootitem", ms.ToArray());
                    break;
                default:
                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            AddNewEvent form = new AddNewEvent(this, index);
            form.Text = "Edit Event:";
            form.button1.Text = "Edit";
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            string eventID = listView1.Items[index].SubItems[1].Text;
            int eventIDIndex = ScriptList.event_id.FindIndex(s => s == eventID);
            form.cmbEventID.SelectedIndex = eventIDIndex;
            string triggerID = listView1.Items[index].SubItems[3].Text;
            int triggerIDIndex = form.cmbTrigger.FindString(triggerID);
            form.cmbTrigger.SelectedIndex = triggerIDIndex;
            form.ShowDialog();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.SelectedIndexChanged -= ListView1_SelectedIndexChanged;
            List<ListViewItem> selectedItems = new List<ListViewItem>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (ListViewItem itemR in selectedItems)
            {
                int index = itemR.Index;
                int flagIndex = int.Parse(itemR.SubItems[2].Text);
                string type = itemR.SubItems[3].Text;
                int count = 0;
                switch (type)
                {
                    case "Kind":
                        listView1.Items.RemoveAt(index);
                        Form1.eventKindList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Other":
                        listView1.Items.RemoveAt(index);
                        Form1.bootOtherFlagList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Event":
                        listView1.Items.RemoveAt(index);
                        Form1.eventFlagList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Talk":
                        listView1.Items.RemoveAt(index);
                        Form1.bootTalkList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Stage":
                        listView1.Items.RemoveAt(index);
                        Form1.bootStageList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Sphere":
                        listView1.Items.RemoveAt(index);
                        Form1.bootSphereList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Team":
                        listView1.Items.RemoveAt(index);
                        Form1.bootSpcList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Time":
                        listView1.Items.RemoveAt(index);
                        Form1.bootTimeList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Item":
                        listView1.Items.RemoveAt(index);
                        Form1.bootItemList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    case "Player":
                        listView1.Items.RemoveAt(index);
                        Form1.bootPlchList.RemoveAt(flagIndex);
                        foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>()
                                                                   .Where(j => j.SubItems[3].Text == type))
                        {
                            item.SubItems[2].Text = $"{count}";
                            count++;
                        }
                        break;
                    default:
                        break;
                }
            }
            UpdateListAndBlocks();
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            AddNewEvent form = new AddNewEvent(this, index);
            form.cmbEventID.Items.AddRange(ScriptList.event_id.ToArray());
            form.cmbEventID.SelectedIndex = 0;
            form.cmbTrigger.SelectedIndex = 0;
            form.ShowDialog();
        }

        private void cmbKind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }
    }
}
