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
    public partial class Edit_Boot_Talk : Form
    {
        public Edit_Boot_Talk()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int index = listBox1.SelectedIndex;
            numEventFlag.Value = (int)Form1.bootTalkList[index].eventFlag;
            cmbEventID.SelectedIndex = (int)Form1.bootTalkList[index].eventID;
            cmbCharID.SelectedIndex = (int)Form1.bootTalkList[index].charID;
            numStageID.Value = (int)Form1.bootTalkList[index].stageID;
            cmbAutoTalk.SelectedIndex = (int)Form1.bootTalkList[index].autoTalk;
            numUnkFlag2.Value = (int)Form1.bootTalkList[index].flag2;
        }

        private void addNewTalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: {cmbCharID.Items[0]}");
            Form1.bootTalkList.Add(new BootTalk());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            Form1.bootTalkList[index].eventFlag = (uint)numEventFlag.Value;
            Form1.bootTalkList[index].eventID = (uint)cmbEventID.SelectedIndex;
            Form1.bootTalkList[index].charID = (uint)cmbCharID.SelectedIndex;
            listBox1.Items[index] = $"{index}: {cmbCharID.Items[cmbCharID.SelectedIndex]}";
            Form1.bootTalkList[index].stageID = (uint)numStageID.Value;
            Form1.bootTalkList[index].autoTalk = (uint)cmbAutoTalk.SelectedIndex;
            Form1.bootTalkList[index].flag2 = (uint)numUnkFlag2.Value;
            MemoryStream ms = new MemoryStream();
            for(int i = 0; i < Form1.bootTalkList.Count; i++)
            {
                byte[] currentBootTalkBlock = BootTalk.Write(Form1.bootTalkList[i]);
                ms.Write(currentBootTalkBlock, 0, currentBootTalkBlock.Length);
            }
            Form1.ccsList[1].blocks[14].Data = ms.ToArray();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
    }
}
