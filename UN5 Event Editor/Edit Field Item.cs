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
    public partial class EditFieldItem : Form
    {
        public EditFieldItem()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            cmbObject.SelectedIndexChanged += CmbObject_SelectedIndexChanged;
        }

        private void CmbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDisarm.Enabled = cmbObject.SelectedIndex == 0 ? true : false;
            cmbVerify.Enabled = cmbObject.SelectedIndex == 0 ? false : true;
            cmbVerify.SelectedIndex = cmbObject.SelectedIndex == 0 ? 0 : 1;
            cmbDisarm.SelectedIndex = cmbObject.SelectedIndex == 0 ? 1 : 0;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            cmbDisarm.Enabled = cmbObject.SelectedIndex == 0 ? true : false;
            cmbVerify.Enabled = cmbObject.SelectedIndex == 0 ? false : true;
            cmbItemID.SelectedIndex = (int)Form1.fieldItemList[index].itemID;
            cmbObject.SelectedIndex = (int)Form1.fieldItemList[index].objID;
            cmbStageID.SelectedIndex = (int)Form1.fieldItemList[index].stageID;
            numPosX.Value = Form1.fieldItemList[index].posX;
            numPosY.Value = Form1.fieldItemList[index].posY;
            numPosZ.Value = Form1.fieldItemList[index].posZ;
            numRotX.Value = Form1.fieldItemList[index].rotX;
            cmbDisarm.SelectedIndex = (int)Form1.fieldItemList[index].disarm;
            cmbVerify.SelectedIndex = (int)Form1.fieldItemList[index].verify;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numStageID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Form1.fieldItemList[index].itemID = (uint)cmbItemID.SelectedIndex;
            Form1.fieldItemList[index].objID = (uint)cmbObject.SelectedIndex;
            Form1.fieldItemList[index].stageID = (uint)cmbStageID.SelectedIndex;
            Form1.fieldItemList[index].posX = (int)numPosX.Value;
            Form1.fieldItemList[index].posY = (int)numPosY.Value;
            Form1.fieldItemList[index].posZ = (int)numPosZ.Value;
            Form1.fieldItemList[index].rotX = (int)numRotX.Value;
            Form1.fieldItemList[index].disarm = (uint)cmbDisarm.SelectedIndex;
            Form1.fieldItemList[index].verify = (uint)cmbVerify.SelectedIndex;
            MemoryStream ms = new MemoryStream();
            byte[] countBytes = Encoding.UTF8.GetBytes($"{Form1.fieldItemList.Count}");
            ms.Write(countBytes, 0, countBytes.Length);
            ms.WriteByte(0x23);
            for (int i = 0; i < Form1.fieldItemList.Count; i++)
            {
                byte[] fieldItemBlock = FieldItem.Write(Form1.fieldItemList[i]);
                ms.Write(fieldItemBlock, 0, fieldItemBlock.Length);
            }
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllBytes(Path.Combine(desktop, "fieldItem.bin"), ms.ToArray());
            Form1.ccsList[1].blocks[17].Data = ms.ToArray();
        }

        private void addNewFieldItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: Konoha Gate");
            Form1.fieldItemList.Add(new FieldItem() { ID = (uint)Form1.fieldItemList.Count });
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
