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

namespace UN5_Event_Editor
{
    public partial class EditEventKind : Form
    {
        public EditEventKind()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            numUnk1.Value = Form1.eventKindList[index].unk1;
            cmbEventID.SelectedIndex = (int)Form1.eventKindList[index].eventID;
            numUnk2.Value = Form1.eventKindList[index].unk2;
            numUnk3.Value = Form1.eventKindList[index].unk3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            var eventKind = Form1.eventKindList[index];
            eventKind.unk1 = (uint)numUnk1.Value;
            eventKind.eventID = (uint)cmbEventID.SelectedIndex;
            eventKind.unk2 = (uint)numUnk2.Value;
            eventKind.unk3 = (uint)numUnk3.Value;
            MemoryStream ms = new MemoryStream();
            for(int i = 0; i < Form1.eventKindList.Count; i++)
            {
                byte[] eventKindBlock = EventKind.Write(Form1.eventKindList[i]);
                ms.Write(eventKindBlock, 0, eventKindBlock.Length);
            }
            Form1.ccsList[1].blocks[5].Data = ms.ToArray();
        }
    }
}
