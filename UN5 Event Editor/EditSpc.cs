using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UN5_Event_Editor
{
    public partial class EditSpc : Form
    {
        public EditSpc()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            numUnk1.Value = Form1.spcList[index].unk1;
            cmbEventID.SelectedIndex = (int)Form1.spcList[index].eventID;
            cmbCharacter.SelectedIndex = (int)Form1.spcList[index].charID;
            cmbAutoTalk.SelectedIndex = (int)Form1.spcList[index].isTeam;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checks if the specified Character is in the team or not before executing the Event.\nIf the result of the check does not match the expected condition, the event will not be executed.");
        }

        private void addNewSpcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
