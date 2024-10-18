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
    public partial class EditCharData : Form
    {
        public EditCharData()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Reset();
        }
        private void Reset()
        {
            int index = listBox1.SelectedIndex;
            txtCharName.Text = Form1.charDataList[index].charName;
            rchCharDescription.Text = Form1.charDataList[index].charDescription;
            txtCharCCS.Text = Form1.charDataList[index].charCCS;
            txtANM1.Text = Form1.charDataList[index].charANM1;
            txtANM2.Text = Form1.charDataList[index].charANM2;
            txtANM3.Text = Form1.charDataList[index].charANM3;
            txtANM4.Text = Form1.charDataList[index].charANM4;
            txtANM5.Text = Form1.charDataList[index].charANM5;
        }
        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> charNames = new List<string>();
            for(int i = 0; i < Form1.charDataList.Count; i++)
            {
                charNames.Add(Form1.charDataList[i].charName);
                charNames.Add(Form1.charDataList[i].charDescription);
            }
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllLines(Path.Combine(desktop, "CharNames.txt"), charNames.ToArray());
        }

        private void importNamesToTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
                listBox1.Items.Clear();
                string txtFile = ofd.FileName;
                List<string> charNames = new List<string>();
                string[] txtLines = File.ReadAllLines(txtFile);
                List<byte[]> newList = new List<byte[]>();
                for(int i = 0; i < Form1.charDataList.Count; i++)
                {
                    Form1.charDataList[i].charName = txtLines[i * 2];
                    Form1.charDataList[i].charDescription = txtLines[i * 2 + 1];
                    listBox1.Items.Add($"{i}: {Form1.charDataList[i].charName}");
                }
                for (int i = 0; i < Form1.charDataList.Count; i++)
                {
                    newList.Add(CharData.Write(this, i));
                }
                MemoryStream ms = new MemoryStream();
                byte[] headerBytes = Encoding.UTF8.GetBytes($"1000|{newList.Count}|");
                ms.Write(headerBytes, 0, headerBytes.Length);
                for (int i = 0; i < newList.Count; i++)
                {
                    ms.Write(newList[i], 0, newList[i].Length);
                }
                Form1.ccsList[1].blocks[16].Data = ms.ToArray();
                Form1.charDataBlocksList = newList;
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllBytes(Path.Combine(desktop, "output.bin"), ms.ToArray());
                listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            }
            listBox1.SelectedIndex = 0;
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            CharData.Update(this, index);
            Form1.charDataBlocksList[index] = CharData.Write(this, index);
            listBox1.Items[index] = $"{index}: {txtCharName.Text}";
            MemoryStream ms = new MemoryStream();
            byte[] headerBytes = Encoding.UTF8.GetBytes($"1000|{Form1.charDataBlocksList.Count}|");
            ms.Write(headerBytes, 0, headerBytes.Length);
            for(int i = 0; i < Form1.charDataBlocksList.Count; i++)
            {
                ms.Write(Form1.charDataBlocksList[i], 0, Form1.charDataBlocksList[i].Length);
            }
            CCSF.SetBlockData(Form1.ccsList[1], "chardata", ms.ToArray());
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void addNewCharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.charDataList.Add(new CharData());
            listBox1.Items.Add($"{listBox1.Items.Count}: {Form1.charDataList[listBox1.Items.Count].charName}");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            int index = listBox1.SelectedIndex;
            Form1.charDataBlocksList.Add(CharData.Write(this, index));
        }
    }
}
