using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UN5_Event_Editor
{
    public partial class AddNewEvent : Form
    {
        Teste form;
        int index;
        public AddNewEvent(Teste teste, int i)
        {
            InitializeComponent();
            form = teste;
            index = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eventID = cmbEventID.SelectedItem.ToString();
            string trigger = cmbTrigger.SelectedItem.ToString();
            if(button1.Text == "Add")
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(eventID);
                switch (trigger)
                {
                    case "Kind":
                        Form1.eventKindList.Add(new EventKind() { eventID = (uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.eventKindList.Count - 1}");
                        break;
                    case "Other":
                        Form1.bootOtherFlagList.Add(new BootOtherFlag() { eventID = (uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootOtherFlagList.Count - 1}");
                        break;
                    case "Event":
                        Form1.eventFlagList.Add(new EventFlag() { eventID = (uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.eventFlagList.Count - 1}");
                        break;
                    case "Talk":
                        Form1.bootTalkList.Add(new BootTalk() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootTalkList.Count - 1}");
                        break;
                    case "Stage":
                        Form1.bootStageList.Add(new BootStage() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootStageList.Count - 1}");
                        break;
                    case "Sphere":
                        Form1.bootTalkList.Add(new BootTalk() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootTalkList.Count - 1}");
                        break;
                    case "Spc":
                        Form1.bootSpcList.Add(new BootSpc() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootSpcList.Count - 1}");
                        break;
                    case "Time":
                        Form1.bootTimeList.Add(new BootTime() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootTimeList.Count - 1}");
                        break;
                    case "Item":
                        Form1.bootItemList.Add(new BootItem() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootItemList.Count - 1}");
                        break;
                    case "Plch":
                        Form1.bootPlchList.Add(new BootPlch() { eventID =(uint)cmbEventID.SelectedIndex });
                        item.SubItems.Add($"{Form1.bootPlchList.Count - 1}");
                        break;
                    default:
                        break;
                }
                item.SubItems.Add(trigger);
                form.listView1.Items.Insert(index, item);
            }
            else
            {
                switch (trigger)
                {
                    case "Kind":
                        Form1.eventKindList.Add(new EventKind() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.eventKindList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Other":
                        Form1.bootOtherFlagList.Add(new BootOtherFlag() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootOtherFlagList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Event":
                        Form1.eventFlagList.Add(new EventFlag() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.eventFlagList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Talk":
                        Form1.bootTalkList.Add(new BootTalk() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootTalkList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Stage":
                        Form1.bootStageList.Add(new BootStage() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootStageList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Sphere":
                        Form1.bootTalkList.Add(new BootTalk() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootTalkList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Spc":
                        Form1.bootSpcList.Add(new BootSpc() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootSpcList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Time":
                        Form1.bootTimeList.Add(new BootTime() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootTimeList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Item":
                        Form1.bootItemList.Add(new BootItem() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootItemList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    case "Plch":
                        Form1.bootPlchList.Add(new BootPlch() { eventID = (uint)cmbEventID.SelectedIndex });
                        form.listView1.Items[index].SubItems[1].Text = eventID;
                        form.listView1.Items[index].SubItems[2].Text = $"{Form1.bootPlchList.Count - 1}";
                        form.listView1.Items[index].SubItems[3].Text = trigger;
                        break;
                    default:
                        break;
                }
            }
            form.UpdateListAndBlocks();
            this.Close();
        }
    }
}
