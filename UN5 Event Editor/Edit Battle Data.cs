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
using UN5_Event_Editor;

namespace UN5_Event_Editor
{
    public partial class EditBattleData : Form
    {
        public List<BattleData> battleDataList = new List<BattleData>();
        public List<byte[]> battleDataBlocksList = new List<byte[]>();
        public EditBattleData()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int index = listBox1.SelectedIndex;
            txtBattleName.Text = battleDataList[index].battleName;
            numRyoLose.Value = battleDataList[index].RyoLose;
            numRyoWin.Value = battleDataList[index].RyoWin;
            cmbDifficulty.SelectedIndex = (int)battleDataList[index].Difficulty;
            cmbAllowRetry.SelectedIndex = (int)battleDataList[index].AllowRetry;
            cmbGameOver.SelectedIndex = (int)battleDataList[index].GameOver;
            numTime.Value = battleDataList[index].Time;
            cmbPlayer1.SelectedIndex = (int)battleDataList[index].Player1ID;
            cmbPlayer2.SelectedIndex = (int)battleDataList[index].Player2ID;
            cmbSuport1.SelectedIndex =(int)battleDataList[index].Suporte1ID;
            cmbSuport2.SelectedIndex =(int)battleDataList[index].Suporte2ID;
            cmbCondition1.SelectedIndex = (int)battleDataList[index].Condition1;
            cmbCondition2.SelectedIndex = (int)battleDataList[index].Condition2;
            cmbCondition3.SelectedIndex = (int)battleDataList[index].Condition3;
            cmbCondition4.SelectedIndex = (int)battleDataList[index].Condition4;
            cmbJutsu1Player1.SelectedIndex = (int)battleDataList[index].Jutsu1Player1;
            cmbJutsu2Player1.SelectedIndex = (int)battleDataList[index].Jutsu2Player1;
            cmbJutsu1Player2.SelectedIndex = (int)battleDataList[index].Jutsu1Player2;
            cmbJutsu2Player2.SelectedIndex = (int)battleDataList[index].Jutsu2Player2;
            cmbPlayer1UltimateJutsu1.SelectedIndex = (int)battleDataList[index].Ultimate1Player1;
            cmbPlayer1UltimateJutsu2.SelectedIndex = (int)battleDataList[index].Ultimate2Player1;
            cmbPlayer1UltimateJutsu3.SelectedIndex = (int)battleDataList[index].Ultimate3Player1;
            cmbPlayer2UltimateJutsu1.SelectedIndex = (int)battleDataList[index].Ultimate1Player2;
            cmbPlayer2UltimateJutsu2.SelectedIndex = (int)battleDataList[index].Ultimate2Player2;
            cmbPlayer2UltimateJutsu3.SelectedIndex = (int)battleDataList[index].Ultimate3Player2;
            cmbStage.SelectedIndex = (int)battleDataList[index].Stage;
            cmbSelectMode.SelectedIndex = (int)battleDataList[index].SelectionMode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            battleDataBlocksList[index] = BattleData.Write(this);
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MemoryStream ms = new MemoryStream();
            for(int i = 0; i < battleDataBlocksList.Count; i++)
            {
                ms.Write(battleDataBlocksList[i], 0, battleDataBlocksList[i].Length);
            }
            if(Form1.isNA2 == true)
            {
                CCSF.SetBlockData(Form1.ccsList[1], "battledata", ms.ToArray());
            }
            else
            {
                CCSF.SetBlockData(Form1.ccsList[0], "battledatatxt", ms.ToArray());
            }
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count}: ");
            battleDataList.Add(new BattleData());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            battleDataBlocksList.Add(BattleData.Write(this));
        }
    }
}
