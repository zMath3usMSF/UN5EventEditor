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
    public partial class EditPlchList : Form
    {
        public EditPlchList()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            numUnk1.Value = Form1.plchList[index].unk1;
            cmbEventID.SelectedIndex = (int)Form1.plchList[index].eventID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            Form1.plchList[index].unk1 = (uint)numUnk1.Value;
            Form1.plchList[index].eventID = (uint)cmbEventID.SelectedIndex;
            listBox1.Items[index] = $"{index}: {cmbEventID.Items[cmbEventID.SelectedIndex]}";
            MemoryStream ms = new MemoryStream();
            for (int i = 0; i < Form1.plchList.Count; i++)
            {
                byte[] currentPlchBlock = Plch.Write(Form1.plchList[i]);
                ms.Write(currentPlchBlock, 0, currentPlchBlock.Length);
            }
            Form1.ccsList[1].blocks[8].Data = ms.ToArray();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void addNewPlchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: {cmbEventID.Items[0]}");
            Form1.plchList.Add(new Plch());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
