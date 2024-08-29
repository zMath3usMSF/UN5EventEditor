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
    public partial class EditScriptList : Form
    {
        public EditScriptList()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int index = listBox1.SelectedIndex;
            txtCCS_TBL.Text = ScriptList.ccs_tbl[index];
            txtEvent_ID.Text = ScriptList.event_id[index];
        }

        public void addList()
        {
            for (int i = 0; i < ScriptList.ccs_tbl.Count; i++)
            {
                listBox1.Items.Add($"{i}: {ScriptList.event_id[i]}");
            }
        }

        private void addNewScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: ");
            ScriptList.ccs_tbl.Add("");
            ScriptList.event_id.Add("");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            string ccs = txtCCS_TBL.Text;
            ScriptList.ccs_tbl[index] = txtCCS_TBL.Text;
            ScriptList.event_id[index] = txtEvent_ID.Text;
            listBox1.Items[index] = $"{index}: {txtEvent_ID.Text}";
            MemoryStream ms = new MemoryStream();
            byte[] ccs_tblCountBytes = Encoding.UTF8.GetBytes(ScriptList.ccs_tbl.Count.ToString());
            ms.Write(ccs_tblCountBytes, 0, ccs_tblCountBytes.Length);
            ms.WriteByte(0x23);
            for(int i = 0; i < ScriptList.ccs_tbl.Count; i++)
            {
                byte[] currentCCS_TBL = ScriptList.WriteCCS_TBL(ScriptList.ccs_tbl[i]);
                ms.Write(currentCCS_TBL, 0, currentCCS_TBL.Length);
            }
            Form1.ccsList[1].blocks[17].Data = ms.ToArray();
            ms = new MemoryStream();
            byte[] event_idCountBytes = Encoding.UTF8.GetBytes(ScriptList.event_id.Count.ToString());
            ms.Write(event_idCountBytes, 0, event_idCountBytes.Length);
            ms.WriteByte(0x23);
            for (int i = 0; i < ScriptList.event_id.Count; i++)
            {
                byte[] currentEvent_ID = ScriptList.WriteEvent_ID(ScriptList.event_id[i]);
                ms.Write(currentEvent_ID, 0, currentEvent_ID.Length);
            }
            Form1.ccsList[1].blocks[18].Data = ms.ToArray();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
    }
}
