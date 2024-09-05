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

namespace UN5_Event_Editor
{
    public partial class EditOtherFlag : Form
    {
        public EditOtherFlag()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int index = listBox1.SelectedIndex;
            numUnk1.Value = Form1.otherFlagList[index].unk1;
            cmbEventID.SelectedIndex = (int)Form1.otherFlagList[index].eventID;
            numUnk2.Value = Form1.otherFlagList[index].unk2;
            numUnk3.Value = Form1.otherFlagList[index].unk3;
            numUnk4.Value = Form1.otherFlagList[index].unk4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            Form1.otherFlagList[index].unk1 = (uint)numUnk1.Value;
            Form1.otherFlagList[index].eventID = (uint)cmbEventID.SelectedIndex;
            listBox1.Items[index] = $"{index}: {cmbEventID.Items[(int)Form1.otherFlagList[index].eventID]}";
            Form1.otherFlagList[index].unk2 =(uint)numUnk2.Value;
            Form1.otherFlagList[index].unk3 =(uint)numUnk3.Value;
            Form1.otherFlagList[index].unk4 =(uint)numUnk4.Value;
            MemoryStream ms = new MemoryStream();
            for(int i = 0; i < Form1.otherFlagList.Count; i++)
            {
                byte[] otherFlagBlock = BootOtherFlag.Write(Form1.otherFlagList[i]);
                ms.Write(otherFlagBlock, 0, otherFlagBlock.Length);
            }
            Form1.ccsList[1].blocks[5].Data = ms.ToArray();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void addNewOtherFlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.otherFlagList.Add(new BootOtherFlag());
            listBox1.Items.Add($"{listBox1.Items.Count}: {cmbEventID.Items[(int)Form1.otherFlagList[listBox1.Items.Count].eventID]}");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            MemoryStream ms = new MemoryStream();
            for (int i = 0; i < Form1.otherFlagList.Count; i++)
            {
                byte[] otherFlagBlock = BootOtherFlag.Write(Form1.otherFlagList[i]);
                ms.Write(otherFlagBlock, 0, otherFlagBlock.Length);
            }
            Form1.ccsList[1].blocks[5].Data = ms.ToArray();
        }
    }
}
