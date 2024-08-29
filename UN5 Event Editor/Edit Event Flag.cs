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
    public partial class EditEventFlag : Form
    {
        public EditEventFlag()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            numUnkFlag1.Value = Form1.eventFlagList[index].unk1;
            cmbEventID.SelectedIndex = (int)Form1.eventFlagList[index].eventID;
            numUnkFlag2.Value = Form1.eventFlagList[index].unk2;
            numUnk3.Value = Form1.eventFlagList[index].unk3;
            numUnk4.Value = Form1.eventFlagList[index].unk4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Form1.eventFlagList[index].unk1 = (uint)numUnkFlag1.Value;
            Form1.eventFlagList[index].eventID = (uint)cmbEventID.SelectedIndex;
            Form1.eventFlagList[index].unk2 = (uint)numUnkFlag2.Value;
            Form1.eventFlagList[index].unk3 = (uint)numUnk3.Value;
            Form1.eventFlagList[index].unk4 = (uint)numUnk4.Value;
            MemoryStream ms = new MemoryStream();
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                byte[] eventFlagBlock = EventFlag.Write(Form1.eventFlagList[i]);
                ms.Write(eventFlagBlock, 0, eventFlagBlock.Length);
            }
            Form1.ccsList[1].blocks[4].Data = ms.ToArray();
        }
    }
}
