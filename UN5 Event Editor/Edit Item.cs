using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UN5_Event_Editor
{

    public partial class EditItem : Form
    {
        private ComboBox comboBox;
        public EditItem()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }
        public void CreateIcon()
        {
            comboBox = new ComboBox
            {
                Location = new Point(317, 27),
                DrawMode = DrawMode.OwnerDrawFixed,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 64,
                Height = 32,
                ItemHeight = 32
            };
            comboBox.DropDownHeight = 256;
            comboBox.DrawItem += ComboBox_DrawItem;
            for (int i = 0; i < Form1.itemIconsList.Count; i++)
            {
                comboBox.Items.Add(Form1.itemIconsList[i]);
            }
            comboBox.SelectedIndex = 0;
            comboBox.Visible = false;
            Controls.Add(comboBox);
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            comboBox.Visible = true;
            panel1.Visible = true;
            comboBox.SelectedIndex = (int)Form1.itemList[index].iconID;
            txtName.Text = Form1.itemInfo[index + 3][0];
            rchDescription.Text = Form1.itemInfo[index + 3][1];
            numUnk1.Value = Form1.itemList[index].unk1;
            cmbCategory.SelectedIndex = (int)Form1.itemList[index].category;
            numPurchasePrice.Value = Form1.itemList[index].normalPurchasePrice;
            numSunaPurchasePrice.Value = Form1.itemList[index].sunaPurchasePrice;
            numSellingPrice.Value = Form1.itemList[index].sellingPrice;
            numStockLimit.Value = Form1.itemList[index].inventoryLimit;
            cmbEnabled.SelectedIndex = (int)Form1.itemList[index].enabled;
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var image = (Image)comboBox.Items[e.Index];
            e.DrawBackground();
            e.Graphics.DrawImage(image, e.Bounds.X, e.Bounds.Y, 32, 32);
            e.DrawFocusRectangle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = $"{index}: {txtName.Text}";
            var itemList = Form1.itemList[index];
            var itemInfo = Form1.itemInfo[index + 3];
            itemList.iconID = (uint)comboBox.SelectedIndex;
            itemInfo[0] = txtName.Text;
            itemInfo[1] = rchDescription.Text;
            itemList.unk1 = (uint)numUnk1.Value;
            itemList.category = (uint)cmbCategory.SelectedIndex;
            itemList.normalPurchasePrice = (uint)numPurchasePrice.Value;
            itemList.sunaPurchasePrice = (uint)numSunaPurchasePrice.Value;
            itemList.sellingPrice = (uint)numSellingPrice.Value;
            itemList.inventoryLimit = (uint)numStockLimit.Value;
            itemList.enabled = (uint)cmbEnabled.SelectedIndex;

            MemoryStream ms = new MemoryStream();
            string encoding = Form1.isNA2 == true ? "shift-jis" : "ISO-8859-1";
            byte[] itemInfoCountBytes = Encoding.GetEncoding(encoding).GetBytes($"{Form1.itemInfo.Count - 3}");
            ms.Write(itemInfoCountBytes, 0, itemInfoCountBytes.Length);
            ms.WriteByte(0x23);
            for (int i = 0; i <  Form1.itemList.Count; i++)
            {
                byte[] itemBlock = Item.Write(Form1.itemList[i]);
                ms.Write(itemBlock, 0, itemBlock.Length);
            }
            for (int i = 0; i <  Form1.itemInfo.Count; i++)
            {
                byte[] itemNameBytes = Encoding.GetEncoding(encoding).GetBytes(Form1.itemInfo[i][0]);
                byte[] itemDescriptionBytes = Encoding.GetEncoding(encoding).GetBytes(Form1.itemInfo[i][1]);
                ms.Write(itemNameBytes, 0, itemNameBytes.Length);
                ms.WriteByte(0x23);
                ms.Write(itemDescriptionBytes, 0, itemDescriptionBytes.Length);
                ms.WriteByte(0x23);
            }
            while(ms.Length % 4 != 0)
            {
                ms.WriteByte(0x0);
            }
            Form1.ccsList[0].blocks[4].Data = ms.ToArray();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            listBox1.SelectedIndexChanged +=ListBox1_SelectedIndexChanged;
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: ");
            Form1.itemList.Add(new Item() { ID = (uint)Form1.itemList.Count});
            Form1.itemInfo.Add(new string[] { "", "" });
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
