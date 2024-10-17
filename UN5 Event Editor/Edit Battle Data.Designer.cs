namespace UN5_Event_Editor
{
    partial class EditBattleData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBattleData));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.battleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBattleName = new System.Windows.Forms.TextBox();
            this.lblBattleName = new System.Windows.Forms.Label();
            this.lblRyoLose = new System.Windows.Forms.Label();
            this.lblRyoWin = new System.Windows.Forms.Label();
            this.numRyoLose = new System.Windows.Forms.NumericUpDown();
            this.numRyoWin = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkedCharacter1 = new System.Windows.Forms.Label();
            this.lblLinkedCharacter2 = new System.Windows.Forms.Label();
            this.cmbCondition1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCondition2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCondition3 = new System.Windows.Forms.ComboBox();
            this.lblCondition3 = new System.Windows.Forms.Label();
            this.cmbCondition4 = new System.Windows.Forms.ComboBox();
            this.lblCondition4 = new System.Windows.Forms.Label();
            this.cmbJutsu1Player1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJutsu2Player1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJutsu2Player2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbJutsu1Player2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.cmbSuport1 = new System.Windows.Forms.ComboBox();
            this.cmbSuport2 = new System.Windows.Forms.ComboBox();
            this.cmbGameOver = new System.Windows.Forms.ComboBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.cmbSelectMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAllowRetry = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlayer1UltimateJutsu1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPlayer1UltimateJutsu2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPlayer1UltimateJutsu3 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2UltimateJutsu3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPlayer2UltimateJutsu2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPlayer2UltimateJutsu1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRyoLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRyoWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 345);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.battleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // battleToolStripMenuItem
            // 
            this.battleToolStripMenuItem.Name = "battleToolStripMenuItem";
            this.battleToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.battleToolStripMenuItem.Text = "Add New Battle";
            this.battleToolStripMenuItem.Click += new System.EventHandler(this.battleToolStripMenuItem_Click);
            // 
            // txtBattleName
            // 
            this.txtBattleName.Location = new System.Drawing.Point(81, 7);
            this.txtBattleName.MaxLength = 128;
            this.txtBattleName.Name = "txtBattleName";
            this.txtBattleName.Size = new System.Drawing.Size(552, 20);
            this.txtBattleName.TabIndex = 2;
            // 
            // lblBattleName
            // 
            this.lblBattleName.AutoSize = true;
            this.lblBattleName.Location = new System.Drawing.Point(7, 10);
            this.lblBattleName.Name = "lblBattleName";
            this.lblBattleName.Size = new System.Drawing.Size(68, 13);
            this.lblBattleName.TabIndex = 3;
            this.lblBattleName.Text = "Battle Name:";
            // 
            // lblRyoLose
            // 
            this.lblRyoLose.AutoSize = true;
            this.lblRyoLose.Location = new System.Drawing.Point(7, 35);
            this.lblRyoLose.Name = "lblRyoLose";
            this.lblRyoLose.Size = new System.Drawing.Size(119, 13);
            this.lblRyoLose.TabIndex = 4;
            this.lblRyoLose.Text = "Minimum money on win:";
            // 
            // lblRyoWin
            // 
            this.lblRyoWin.AutoSize = true;
            this.lblRyoWin.Location = new System.Drawing.Point(207, 35);
            this.lblRyoWin.Name = "lblRyoWin";
            this.lblRyoWin.Size = new System.Drawing.Size(122, 13);
            this.lblRyoWin.TabIndex = 5;
            this.lblRyoWin.Text = "Maximum money on win:";
            // 
            // numRyoLose
            // 
            this.numRyoLose.Location = new System.Drawing.Point(132, 33);
            this.numRyoLose.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numRyoLose.Name = "numRyoLose";
            this.numRyoLose.Size = new System.Drawing.Size(51, 20);
            this.numRyoLose.TabIndex = 6;
            // 
            // numRyoWin
            // 
            this.numRyoWin.Location = new System.Drawing.Point(335, 33);
            this.numRyoWin.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numRyoWin.Name = "numRyoWin";
            this.numRyoWin.Size = new System.Drawing.Size(51, 20);
            this.numRyoWin.TabIndex = 7;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(408, 35);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 8;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Very Easy",
            "Easy",
            "Normal",
            "Hard",
            "Very Hard",
            "Insane",
            "Ultimate"});
            this.cmbDifficulty.Location = new System.Drawing.Point(464, 32);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(81, 21);
            this.cmbDifficulty.TabIndex = 9;
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(592, 33);
            this.numTime.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(41, 20);
            this.numTime.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(553, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(7, 64);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer1.TabIndex = 12;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player 2:";
            // 
            // lblLinkedCharacter1
            // 
            this.lblLinkedCharacter1.AutoSize = true;
            this.lblLinkedCharacter1.Location = new System.Drawing.Point(8, 89);
            this.lblLinkedCharacter1.Name = "lblLinkedCharacter1";
            this.lblLinkedCharacter1.Size = new System.Drawing.Size(100, 13);
            this.lblLinkedCharacter1.TabIndex = 16;
            this.lblLinkedCharacter1.Text = "Linked Character 1:";
            // 
            // lblLinkedCharacter2
            // 
            this.lblLinkedCharacter2.AutoSize = true;
            this.lblLinkedCharacter2.Location = new System.Drawing.Point(329, 89);
            this.lblLinkedCharacter2.Name = "lblLinkedCharacter2";
            this.lblLinkedCharacter2.Size = new System.Drawing.Size(100, 13);
            this.lblLinkedCharacter2.TabIndex = 18;
            this.lblLinkedCharacter2.Text = "Linked Character 2:";
            // 
            // cmbCondition1
            // 
            this.cmbCondition1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition1.FormattingEnabled = true;
            this.cmbCondition1.Items.AddRange(new object[] {
            "None.",
            "Win the fight.",
            "Fight until time ends.",
            "Finish in 30 timer counts.",
            "Finish in 60 timer counts.",
            "Finish using a throw.",
            "Finish while opponent is mid-air.",
            "Finish using Ultimate Jutsu.",
            "Finished while Awakened.",
            "Finish using Jutsu.",
            "Finish when opponent\'s Chakra is at 0.",
            "Finish with attack by Linked Character.",
            "Finish with Chakra at or above level 1.",
            "Finish with Chakra at or above level 2.",
            "Finish with Chakra at or above level 3.",
            "Health is at 10% or below.",
            "Finish with at least 30% Health.",
            "Finish with at least 50% Health.",
            "Finish with at least 80% Health.",
            "Start with opponent\'s Health at 30%.",
            "Start with opponent\'s Health at 50%.",
            "Land all attacks.",
            "No jumping.",
            "No Jutsu.",
            "No Ultimate Jutsu.",
            "No guarding opponent attacks.",
            "Opponents must not use Ultimate Jutsu.",
            "Evade all attacks.",
            "With no Linked Character.",
            "No attacks while on the ground.",
            "Must attack using items.",
            "Wall climb for 4 timer counts.",
            "Wall climb for 6 timer counts.",
            "Stand on water for at least 60 timer counts total.",
            "Do not cease attacks for over 1 timer count.",
            "Do not cease attacks for over 3 timer counts.",
            "Use Substitution Jutsu 3 times.",
            "Use Substitution Jutsu 6 times.",
            "Simultaneously strike each other 3 times.",
            "Do a Rebound 3 times.",
            "Do an Extra Hit 3 times.",
            "Do an Extra Hit 6 times.",
            "Use at least 3 Ninja Tools.",
            "Possess at least 3 items.",
            "Destroy at least 3 objects.",
            "Destroy at least 5 objects.",
            "Destroy at least 7 objects.",
            "Use a 5-hit combo.",
            "Use a 10-hit combo.",
            "Use a 15-hit combo.",
            "Use a 20-hit combo.",
            "Use a 25-hit combo.",
            "Use a 30-hit combo.",
            "Use a 35-hit combo.",
            "Use a 40-hit combo.",
            "Use a 45-hit combo.",
            "Use a 50-hit combo.",
            "Throw down an opponent at least 3 times.",
            "Throw down an opponent at least 6 times.",
            "Taunt the opponent.",
            "Activate Awakened Mode.",
            "Use a normal or linked Ultimate Jutsu.",
            "Use a Reversal Ultimate Jutsu.",
            "Use an Awakening Ultimate Jutsu.",
            "Call on a Linked Character.",
            "Slow Speed.",
            "Low Attack Power.",
            "Low Defense Power.",
            "Low Recovery Power.",
            "Start poisoned.",
            "Start with 10% Health.",
            "Start without Chakra.",
            "No gravitational force.",
            "Opponent Speed is fast. (Level 1)",
            "Opponent Speed is fast. (Level 2)",
            "Opponent Speed is fast. (Level 3)",
            "Opponent Attack Power is strong. (Level 1)",
            "Opponent Attack Power is strong. (Level 2)",
            "Opponent Attack Power is strong. (Level 3)",
            "Opponent Defense Power is strong. (Level 1)",
            "Opponent Defense Power is strong. (Level 2)",
            "Opponent Defense Power is strong. (Level 3)",
            "Opponent\'s Health continuously recovers.",
            "Opponent\'s Chakra continuously recovers.",
            "Opponent attacks reduce your Chakra.",
            "Start with opponent\'s Health at 50%.",
            "Cannot use Chakra.",
            "Reduced size.",
            "All Ultimate Jutsu prohibited.",
            "Normal Ultimate Jutsu only.",
            "Linked Ultimate Jutsu only.",
            "With Nine-Tailed Chakra.",
            "Nine-Tailed Naruto in Fourth Awakened Mode."});
            this.cmbCondition1.Location = new System.Drawing.Point(76, 221);
            this.cmbCondition1.Name = "cmbCondition1";
            this.cmbCondition1.Size = new System.Drawing.Size(232, 21);
            this.cmbCondition1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Condition 1:";
            // 
            // cmbCondition2
            // 
            this.cmbCondition2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition2.FormattingEnabled = true;
            this.cmbCondition2.Items.AddRange(new object[] {
            "None.",
            "Win the fight.",
            "Fight until time ends.",
            "Finish in 30 timer counts.",
            "Finish in 60 timer counts.",
            "Finish using a throw.",
            "Finish while opponent is mid-air.",
            "Finish using Ultimate Jutsu.",
            "Finished while Awakened.",
            "Finish using Jutsu.",
            "Finish when opponent\'s Chakra is at 0.",
            "Finish with attack by Linked Character.",
            "Finish with Chakra at or above level 1.",
            "Finish with Chakra at or above level 2.",
            "Finish with Chakra at or above level 3.",
            "Health is at 10% or below.",
            "Finish with at least 30% Health.",
            "Finish with at least 50% Health.",
            "Finish with at least 80% Health.",
            "Start with opponent\'s Health at 30%.",
            "Start with opponent\'s Health at 50%.",
            "Land all attacks.",
            "No jumping.",
            "No Jutsu.",
            "No Ultimate Jutsu.",
            "No guarding opponent attacks.",
            "Opponents must not use Ultimate Jutsu.",
            "Evade all attacks.",
            "With no Linked Character.",
            "No attacks while on the ground.",
            "Must attack using items.",
            "Wall climb for 4 timer counts.",
            "Wall climb for 6 timer counts.",
            "Stand on water for at least 60 timer counts total.",
            "Do not cease attacks for over 1 timer count.",
            "Do not cease attacks for over 3 timer counts.",
            "Use Substitution Jutsu 3 times.",
            "Use Substitution Jutsu 6 times.",
            "Simultaneously strike each other 3 times.",
            "Do a Rebound 3 times.",
            "Do an Extra Hit 3 times.",
            "Do an Extra Hit 6 times.",
            "Use at least 3 Ninja Tools.",
            "Possess at least 3 items.",
            "Destroy at least 3 objects.",
            "Destroy at least 5 objects.",
            "Destroy at least 7 objects.",
            "Use a 5-hit combo.",
            "Use a 10-hit combo.",
            "Use a 15-hit combo.",
            "Use a 20-hit combo.",
            "Use a 25-hit combo.",
            "Use a 30-hit combo.",
            "Use a 35-hit combo.",
            "Use a 40-hit combo.",
            "Use a 45-hit combo.",
            "Use a 50-hit combo.",
            "Throw down an opponent at least 3 times.",
            "Throw down an opponent at least 6 times.",
            "Taunt the opponent.",
            "Activate Awakened Mode.",
            "Use a normal or linked Ultimate Jutsu.",
            "Use a Reversal Ultimate Jutsu.",
            "Use an Awakening Ultimate Jutsu.",
            "Call on a Linked Character.",
            "Slow Speed.",
            "Low Attack Power.",
            "Low Defense Power.",
            "Low Recovery Power.",
            "Start poisoned.",
            "Start with 10% Health.",
            "Start without Chakra.",
            "No gravitational force.",
            "Opponent Speed is fast. (Level 1)",
            "Opponent Speed is fast. (Level 2)",
            "Opponent Speed is fast. (Level 3)",
            "Opponent Attack Power is strong. (Level 1)",
            "Opponent Attack Power is strong. (Level 2)",
            "Opponent Attack Power is strong. (Level 3)",
            "Opponent Defense Power is strong. (Level 1)",
            "Opponent Defense Power is strong. (Level 2)",
            "Opponent Defense Power is strong. (Level 3)",
            "Opponent\'s Health continuously recovers.",
            "Opponent\'s Chakra continuously recovers.",
            "Opponent attacks reduce your Chakra.",
            "Start with opponent\'s Health at 50%.",
            "Cannot use Chakra.",
            "Reduced size.",
            "All Ultimate Jutsu prohibited.",
            "Normal Ultimate Jutsu only.",
            "Linked Ultimate Jutsu only.",
            "With Nine-Tailed Chakra.",
            "Nine-Tailed Naruto in Fourth Awakened Mode."});
            this.cmbCondition2.Location = new System.Drawing.Point(76, 248);
            this.cmbCondition2.Name = "cmbCondition2";
            this.cmbCondition2.Size = new System.Drawing.Size(232, 21);
            this.cmbCondition2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Condition 2:";
            // 
            // cmbCondition3
            // 
            this.cmbCondition3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition3.FormattingEnabled = true;
            this.cmbCondition3.Items.AddRange(new object[] {
            "None.",
            "Win the fight.",
            "Fight until time ends.",
            "Finish in 30 timer counts.",
            "Finish in 60 timer counts.",
            "Finish using a throw.",
            "Finish while opponent is mid-air.",
            "Finish using Ultimate Jutsu.",
            "Finished while Awakened.",
            "Finish using Jutsu.",
            "Finish when opponent\'s Chakra is at 0.",
            "Finish with attack by Linked Character.",
            "Finish with Chakra at or above level 1.",
            "Finish with Chakra at or above level 2.",
            "Finish with Chakra at or above level 3.",
            "Health is at 10% or below.",
            "Finish with at least 30% Health.",
            "Finish with at least 50% Health.",
            "Finish with at least 80% Health.",
            "Start with opponent\'s Health at 30%.",
            "Start with opponent\'s Health at 50%.",
            "Land all attacks.",
            "No jumping.",
            "No Jutsu.",
            "No Ultimate Jutsu.",
            "No guarding opponent attacks.",
            "Opponents must not use Ultimate Jutsu.",
            "Evade all attacks.",
            "With no Linked Character.",
            "No attacks while on the ground.",
            "Must attack using items.",
            "Wall climb for 4 timer counts.",
            "Wall climb for 6 timer counts.",
            "Stand on water for at least 60 timer counts total.",
            "Do not cease attacks for over 1 timer count.",
            "Do not cease attacks for over 3 timer counts.",
            "Use Substitution Jutsu 3 times.",
            "Use Substitution Jutsu 6 times.",
            "Simultaneously strike each other 3 times.",
            "Do a Rebound 3 times.",
            "Do an Extra Hit 3 times.",
            "Do an Extra Hit 6 times.",
            "Use at least 3 Ninja Tools.",
            "Possess at least 3 items.",
            "Destroy at least 3 objects.",
            "Destroy at least 5 objects.",
            "Destroy at least 7 objects.",
            "Use a 5-hit combo.",
            "Use a 10-hit combo.",
            "Use a 15-hit combo.",
            "Use a 20-hit combo.",
            "Use a 25-hit combo.",
            "Use a 30-hit combo.",
            "Use a 35-hit combo.",
            "Use a 40-hit combo.",
            "Use a 45-hit combo.",
            "Use a 50-hit combo.",
            "Throw down an opponent at least 3 times.",
            "Throw down an opponent at least 6 times.",
            "Taunt the opponent.",
            "Activate Awakened Mode.",
            "Use a normal or linked Ultimate Jutsu.",
            "Use a Reversal Ultimate Jutsu.",
            "Use an Awakening Ultimate Jutsu.",
            "Call on a Linked Character.",
            "Slow Speed.",
            "Low Attack Power.",
            "Low Defense Power.",
            "Low Recovery Power.",
            "Start poisoned.",
            "Start with 10% Health.",
            "Start without Chakra.",
            "No gravitational force.",
            "Opponent Speed is fast. (Level 1)",
            "Opponent Speed is fast. (Level 2)",
            "Opponent Speed is fast. (Level 3)",
            "Opponent Attack Power is strong. (Level 1)",
            "Opponent Attack Power is strong. (Level 2)",
            "Opponent Attack Power is strong. (Level 3)",
            "Opponent Defense Power is strong. (Level 1)",
            "Opponent Defense Power is strong. (Level 2)",
            "Opponent Defense Power is strong. (Level 3)",
            "Opponent\'s Health continuously recovers.",
            "Opponent\'s Chakra continuously recovers.",
            "Opponent attacks reduce your Chakra.",
            "Start with opponent\'s Health at 50%.",
            "Cannot use Chakra.",
            "Reduced size.",
            "All Ultimate Jutsu prohibited.",
            "Normal Ultimate Jutsu only.",
            "Linked Ultimate Jutsu only.",
            "With Nine-Tailed Chakra.",
            "Nine-Tailed Naruto in Fourth Awakened Mode."});
            this.cmbCondition3.Location = new System.Drawing.Point(398, 220);
            this.cmbCondition3.Name = "cmbCondition3";
            this.cmbCondition3.Size = new System.Drawing.Size(235, 21);
            this.cmbCondition3.TabIndex = 25;
            // 
            // lblCondition3
            // 
            this.lblCondition3.AutoSize = true;
            this.lblCondition3.Location = new System.Drawing.Point(7, 251);
            this.lblCondition3.Name = "lblCondition3";
            this.lblCondition3.Size = new System.Drawing.Size(63, 13);
            this.lblCondition3.TabIndex = 24;
            this.lblCondition3.Text = "Condition 3:";
            // 
            // cmbCondition4
            // 
            this.cmbCondition4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition4.FormattingEnabled = true;
            this.cmbCondition4.Items.AddRange(new object[] {
            "None.",
            "Win the fight.",
            "Fight until time ends.",
            "Finish in 30 timer counts.",
            "Finish in 60 timer counts.",
            "Finish using a throw.",
            "Finish while opponent is mid-air.",
            "Finish using Ultimate Jutsu.",
            "Finished while Awakened.",
            "Finish using Jutsu.",
            "Finish when opponent\'s Chakra is at 0.",
            "Finish with attack by Linked Character.",
            "Finish with Chakra at or above level 1.",
            "Finish with Chakra at or above level 2.",
            "Finish with Chakra at or above level 3.",
            "Health is at 10% or below.",
            "Finish with at least 30% Health.",
            "Finish with at least 50% Health.",
            "Finish with at least 80% Health.",
            "Start with opponent\'s Health at 30%.",
            "Start with opponent\'s Health at 50%.",
            "Land all attacks.",
            "No jumping.",
            "No Jutsu.",
            "No Ultimate Jutsu.",
            "No guarding opponent attacks.",
            "Opponents must not use Ultimate Jutsu.",
            "Evade all attacks.",
            "With no Linked Character.",
            "No attacks while on the ground.",
            "Must attack using items.",
            "Wall climb for 4 timer counts.",
            "Wall climb for 6 timer counts.",
            "Stand on water for at least 60 timer counts total.",
            "Do not cease attacks for over 1 timer count.",
            "Do not cease attacks for over 3 timer counts.",
            "Use Substitution Jutsu 3 times.",
            "Use Substitution Jutsu 6 times.",
            "Simultaneously strike each other 3 times.",
            "Do a Rebound 3 times.",
            "Do an Extra Hit 3 times.",
            "Do an Extra Hit 6 times.",
            "Use at least 3 Ninja Tools.",
            "Possess at least 3 items.",
            "Destroy at least 3 objects.",
            "Destroy at least 5 objects.",
            "Destroy at least 7 objects.",
            "Use a 5-hit combo.",
            "Use a 10-hit combo.",
            "Use a 15-hit combo.",
            "Use a 20-hit combo.",
            "Use a 25-hit combo.",
            "Use a 30-hit combo.",
            "Use a 35-hit combo.",
            "Use a 40-hit combo.",
            "Use a 45-hit combo.",
            "Use a 50-hit combo.",
            "Throw down an opponent at least 3 times.",
            "Throw down an opponent at least 6 times.",
            "Taunt the opponent.",
            "Activate Awakened Mode.",
            "Use a normal or linked Ultimate Jutsu.",
            "Use a Reversal Ultimate Jutsu.",
            "Use an Awakening Ultimate Jutsu.",
            "Call on a Linked Character.",
            "Slow Speed.",
            "Low Attack Power.",
            "Low Defense Power.",
            "Low Recovery Power.",
            "Start poisoned.",
            "Start with 10% Health.",
            "Start without Chakra.",
            "No gravitational force.",
            "Opponent Speed is fast. (Level 1)",
            "Opponent Speed is fast. (Level 2)",
            "Opponent Speed is fast. (Level 3)",
            "Opponent Attack Power is strong. (Level 1)",
            "Opponent Attack Power is strong. (Level 2)",
            "Opponent Attack Power is strong. (Level 3)",
            "Opponent Defense Power is strong. (Level 1)",
            "Opponent Defense Power is strong. (Level 2)",
            "Opponent Defense Power is strong. (Level 3)",
            "Opponent\'s Health continuously recovers.",
            "Opponent\'s Chakra continuously recovers.",
            "Opponent attacks reduce your Chakra.",
            "Start with opponent\'s Health at 50%.",
            "Cannot use Chakra.",
            "Reduced size.",
            "All Ultimate Jutsu prohibited.",
            "Normal Ultimate Jutsu only.",
            "Linked Ultimate Jutsu only.",
            "With Nine-Tailed Chakra.",
            "Nine-Tailed Naruto in Fourth Awakened Mode."});
            this.cmbCondition4.Location = new System.Drawing.Point(398, 247);
            this.cmbCondition4.Name = "cmbCondition4";
            this.cmbCondition4.Size = new System.Drawing.Size(235, 21);
            this.cmbCondition4.TabIndex = 27;
            // 
            // lblCondition4
            // 
            this.lblCondition4.AutoSize = true;
            this.lblCondition4.Location = new System.Drawing.Point(326, 251);
            this.lblCondition4.Name = "lblCondition4";
            this.lblCondition4.Size = new System.Drawing.Size(63, 13);
            this.lblCondition4.TabIndex = 26;
            this.lblCondition4.Text = "Condition 4:";
            // 
            // cmbJutsu1Player1
            // 
            this.cmbJutsu1Player1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJutsu1Player1.FormattingEnabled = true;
            this.cmbJutsu1Player1.Items.AddRange(new object[] {
            "(Default)",
            "(Default)",
            "Multi Shadow Clone Jutsu",
            "Rasengan",
            "Ultra Fire Bullet ",
            "Chidori",
            "Leaf Whirlwind",
            "Leaf Great Hurricane",
            "Sand Burial",
            "Sand Shower ",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal",
            "8 Trigrams Palm Storm Dance",
            "Rotation",
            "This Fairy Tale is for Real!!",
            "Clone Combo",
            "",
            "",
            "",
            "",
            "A Thousand Needles of Death",
            "Crystal Ice Mirrors",
            "Water Style: Water Dragon Jutsu",
            "Demon Slash",
            "8 Trigrams 64 Palms Guard",
            "Super Healing Medicine",
            "Twin Swallow Cut",
            "Sacred Dance Shuriken",
            "Donburi Throw",
            "Spiky Human Boulder",
            "16-hit Combo",
            "Ninja Wolfsbane",
            "Man Beast Clone",
            "Tunneling Fang ",
            "Insect Paralysis Jutsu",
            "Insect Pillar Jutsu",
            "Puppet: Manji Shot",
            "Pair of Maidens",
            "Giant Rumbling Fan Wind Wall",
            "Wind Scythe Jutsu",
            "",
            "",
            "",
            "",
            "Fire Style: Dragon Flame Bombs",
            "Earth Style: Mud Wall",
            "",
            "",
            "",
            "",
            "",
            "",
            "Ninja Hound Summoning",
            "Demon Wind Bomb",
            "",
            "",
            "",
            "",
            "Double Last Resort",
            "Swirling Sand Rasengan",
            "Kachofuketsu",
            "Fragment of a Legend",
            "Dazzling Battle: Beast Scroll Replicas",
            "Temple of Nirvana Technique",
            "",
            "",
            "",
            "",
            "Earth Style Barrier: Earth Dome Prison",
            "Earth Style: Sphere of Graves",
            "Spiral Spider Web",
            "Giant Spider Drop",
            "Musical Manipulation: Tied Madness",
            "Musical Manipulation: Single Burial ",
            "Multiple Fists Barrage",
            "Explosive Destruction Formation",
            "Thorn",
            "Larch Dance ",
            "Instant Light ",
            "Rasengan",
            "Sexy Jutsu",
            "Ninja Tools Toss!",
            "Fierce Palm",
            "Windmill",
            "Wood Style: Universe",
            "Wood Style: Adamantine Forest Call",
            "Infinite Darkness Jutsu",
            "Water Style: Water Wall",
            "",
            "",
            "",
            "",
            "Snake Stomp",
            "Marauding Snakes",
            "Nine-Tailed Fox Power",
            "Vermilion Rasengan",
            "Ultra Gale Formation",
            "Black Chidori",
            "Loopy Lotus",
            "Loopy Eight Whirlwind",
            "Hot Sand Burial ",
            "Sand Shuriken",
            "Butterfly Rage Throw",
            "Butterfly Bomb Sever",
            "Chakra Inhale",
            "Earth Style: Gushing Rock Mountain Cannonball",
            "Heaven Spider Web Net",
            "Destruction Power Bow",
            "Demon Flute: Chains of Fantasia",
            "Demon Flute: Phantom Wave",
            "Twin Pole Drop",
            "Summoning: Rashomon",
            "Vine and Flower",
            "Bracken Dance ",
            "Naruto Uzumaki Combo Attack",
            "Great Ball Rasengan",
            "Medical Ninjutsu: Ferocious Flash",
            "Killer Spring",
            "Sand Cluster",
            "Sand Tsunami",
            "Secret Black Move: Iron Maiden",
            "Secret Black Move: Fire Flower",
            "Slicing Blade Dance",
            "True Wind Scythe Jutsu",
            "Parental Love",
            "1000 Autumn Shower",
            "Iron Sand World Order",
            "Iron Sand Drizzle",
            "Beauty of Figurative Arts",
            "Beauty of Destruction",
            "8 Trigrams Palms Rotation",
            "8 Trigrams Sky Palm",
            "Ninja Tool: Blade of 1000 Strikes",
            "Concealed Kunai Blast",
            "Primary Lotus",
            "Dynamic Entry",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal: Improvement",
            "Maximum Entry",
            "Night Phoenix",
            "Lightning Blade Drop",
            "Lightning Blade",
            "Genjutsu: Shiranui",
            "Fire Style: Fire Ball Jutsu",
            "Water Style: Shark Attack",
            "Water Style: Water Shark Shotgun Jutsu",
            "Crimson Splash",
            "Fake Fox Blast",
            "",
            "",
            "Powerful Blade",
            "Red Secret Technique: Performance of a Hundred Puppets",
            "Tail Road Lu",
            "Mechanical Puppet: Octo Needle Waves",
            "Skillful Manner",
            "1000 Autumn Shower",
            "Dual Raging Fangs",
            "Fang Over Fang",
            "Parasitic Insects: Bind",
            "Parasitic Insects: Feast",
            "8 Trigrams Twin Back Pierce",
            "8 Trigrams 64 Palms Guard",
            "Rage Explosion",
            "Super Slap",
            "Mind Distraction Jutsu",
            "Beautiful Seasons",
            "Toad Blade Cut",
            "Rasengan",
            "Heaven Kick of Pain: Lord of Hosts",
            "Heaven Defending Kick",
            "Hidden Senbon Spray",
            "Ninja Art: Poison Fog",
            "Wolf Fang Drill",
            "Flying Swallow Thrust",
            "Genjutsu: Mirage",
            "Genjutsu: Haze",
            "",
            "",
            "Daenroka",
            "Slithering Snakes",
            "Chakra Dissection: Three",
            "Dead Soul Jutsu",
            "Wood Style: Total Capture ",
            "Wood Style: Wooden Hammer",
            "Ninja Art: Beast Scroll Replicas",
            "Ninja Art: Beast Scroll Replicas \"Wild Dog\" ",
            "Instantaneous Blade",
            "Chidori"});
            this.cmbJutsu1Player1.Location = new System.Drawing.Point(99, 113);
            this.cmbJutsu1Player1.Name = "cmbJutsu1Player1";
            this.cmbJutsu1Player1.Size = new System.Drawing.Size(212, 21);
            this.cmbJutsu1Player1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Player 1 Jutsu 1:";
            // 
            // cmbJutsu2Player1
            // 
            this.cmbJutsu2Player1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJutsu2Player1.FormattingEnabled = true;
            this.cmbJutsu2Player1.Items.AddRange(new object[] {
            "(Default)",
            "(Default)",
            "Multi Shadow Clone Jutsu",
            "Rasengan",
            "Ultra Fire Bullet ",
            "Chidori",
            "Leaf Whirlwind",
            "Leaf Great Hurricane",
            "Sand Burial",
            "Sand Shower ",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal",
            "8 Trigrams Palm Storm Dance",
            "Rotation",
            "This Fairy Tale is for Real!!",
            "Clone Combo",
            "",
            "",
            "",
            "",
            "A Thousand Needles of Death",
            "Crystal Ice Mirrors",
            "Water Style: Water Dragon Jutsu",
            "Demon Slash",
            "8 Trigrams 64 Palms Guard",
            "Super Healing Medicine",
            "Twin Swallow Cut",
            "Sacred Dance Shuriken",
            "Donburi Throw",
            "Spiky Human Boulder",
            "16-hit Combo",
            "Ninja Wolfsbane",
            "Man Beast Clone",
            "Tunneling Fang ",
            "Insect Paralysis Jutsu",
            "Insect Pillar Jutsu",
            "Puppet: Manji Shot",
            "Pair of Maidens",
            "Giant Rumbling Fan Wind Wall",
            "Wind Scythe Jutsu",
            "",
            "",
            "",
            "",
            "Fire Style: Dragon Flame Bombs",
            "Earth Style: Mud Wall",
            "",
            "",
            "",
            "",
            "",
            "",
            "Ninja Hound Summoning",
            "Demon Wind Bomb",
            "",
            "",
            "",
            "",
            "Double Last Resort",
            "Swirling Sand Rasengan",
            "Kachofuketsu",
            "Fragment of a Legend",
            "Dazzling Battle: Beast Scroll Replicas",
            "Temple of Nirvana Technique",
            "",
            "",
            "",
            "",
            "Earth Style Barrier: Earth Dome Prison",
            "Earth Style: Sphere of Graves",
            "Spiral Spider Web",
            "Giant Spider Drop",
            "Musical Manipulation: Tied Madness",
            "Musical Manipulation: Single Burial ",
            "Multiple Fists Barrage",
            "Explosive Destruction Formation",
            "Thorn",
            "Larch Dance ",
            "Instant Light ",
            "Rasengan",
            "Sexy Jutsu",
            "Ninja Tools Toss!",
            "Fierce Palm",
            "Windmill",
            "Wood Style: Universe",
            "Wood Style: Adamantine Forest Call",
            "Infinite Darkness Jutsu",
            "Water Style: Water Wall",
            "",
            "",
            "",
            "",
            "Snake Stomp",
            "Marauding Snakes",
            "Nine-Tailed Fox Power",
            "Vermilion Rasengan",
            "Ultra Gale Formation",
            "Black Chidori",
            "Loopy Lotus",
            "Loopy Eight Whirlwind",
            "Hot Sand Burial ",
            "Sand Shuriken",
            "Butterfly Rage Throw",
            "Butterfly Bomb Sever",
            "Chakra Inhale",
            "Earth Style: Gushing Rock Mountain Cannonball",
            "Heaven Spider Web Net",
            "Destruction Power Bow",
            "Demon Flute: Chains of Fantasia",
            "Demon Flute: Phantom Wave",
            "Twin Pole Drop",
            "Summoning: Rashomon",
            "Vine and Flower",
            "Bracken Dance ",
            "Naruto Uzumaki Combo Attack",
            "Great Ball Rasengan",
            "Medical Ninjutsu: Ferocious Flash",
            "Killer Spring",
            "Sand Cluster",
            "Sand Tsunami",
            "Secret Black Move: Iron Maiden",
            "Secret Black Move: Fire Flower",
            "Slicing Blade Dance",
            "True Wind Scythe Jutsu",
            "Parental Love",
            "1000 Autumn Shower",
            "Iron Sand World Order",
            "Iron Sand Drizzle",
            "Beauty of Figurative Arts",
            "Beauty of Destruction",
            "8 Trigrams Palms Rotation",
            "8 Trigrams Sky Palm",
            "Ninja Tool: Blade of 1000 Strikes",
            "Concealed Kunai Blast",
            "Primary Lotus",
            "Dynamic Entry",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal: Improvement",
            "Maximum Entry",
            "Night Phoenix",
            "Lightning Blade Drop",
            "Lightning Blade",
            "Genjutsu: Shiranui",
            "Fire Style: Fire Ball Jutsu",
            "Water Style: Shark Attack",
            "Water Style: Water Shark Shotgun Jutsu",
            "Crimson Splash",
            "Fake Fox Blast",
            "",
            "",
            "Powerful Blade",
            "Red Secret Technique: Performance of a Hundred Puppets",
            "Tail Road Lu",
            "Mechanical Puppet: Octo Needle Waves",
            "Skillful Manner",
            "1000 Autumn Shower",
            "Dual Raging Fangs",
            "Fang Over Fang",
            "Parasitic Insects: Bind",
            "Parasitic Insects: Feast",
            "8 Trigrams Twin Back Pierce",
            "8 Trigrams 64 Palms Guard",
            "Rage Explosion",
            "Super Slap",
            "Mind Distraction Jutsu",
            "Beautiful Seasons",
            "Toad Blade Cut",
            "Rasengan",
            "Heaven Kick of Pain: Lord of Hosts",
            "Heaven Defending Kick",
            "Hidden Senbon Spray",
            "Ninja Art: Poison Fog",
            "Wolf Fang Drill",
            "Flying Swallow Thrust",
            "Genjutsu: Mirage",
            "Genjutsu: Haze",
            "",
            "",
            "Daenroka",
            "Slithering Snakes",
            "Chakra Dissection: Three",
            "Dead Soul Jutsu",
            "Wood Style: Total Capture ",
            "Wood Style: Wooden Hammer",
            "Ninja Art: Beast Scroll Replicas",
            "Ninja Art: Beast Scroll Replicas \"Wild Dog\" ",
            "Instantaneous Blade",
            "Chidori"});
            this.cmbJutsu2Player1.Location = new System.Drawing.Point(420, 113);
            this.cmbJutsu2Player1.Name = "cmbJutsu2Player1";
            this.cmbJutsu2Player1.Size = new System.Drawing.Size(213, 21);
            this.cmbJutsu2Player1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Player 1 Jutsu 2:";
            // 
            // cmbJutsu2Player2
            // 
            this.cmbJutsu2Player2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJutsu2Player2.FormattingEnabled = true;
            this.cmbJutsu2Player2.Items.AddRange(new object[] {
            "(Default)",
            "(Default)",
            "Multi Shadow Clone Jutsu",
            "Rasengan",
            "Ultra Fire Bullet ",
            "Chidori",
            "Leaf Whirlwind",
            "Leaf Great Hurricane",
            "Sand Burial",
            "Sand Shower ",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal",
            "8 Trigrams Palm Storm Dance",
            "Rotation",
            "This Fairy Tale is for Real!!",
            "Clone Combo",
            "",
            "",
            "",
            "",
            "A Thousand Needles of Death",
            "Crystal Ice Mirrors",
            "Water Style: Water Dragon Jutsu",
            "Demon Slash",
            "8 Trigrams 64 Palms Guard",
            "Super Healing Medicine",
            "Twin Swallow Cut",
            "Sacred Dance Shuriken",
            "Donburi Throw",
            "Spiky Human Boulder",
            "16-hit Combo",
            "Ninja Wolfsbane",
            "Man Beast Clone",
            "Tunneling Fang ",
            "Insect Paralysis Jutsu",
            "Insect Pillar Jutsu",
            "Puppet: Manji Shot",
            "Pair of Maidens",
            "Giant Rumbling Fan Wind Wall",
            "Wind Scythe Jutsu",
            "",
            "",
            "",
            "",
            "Fire Style: Dragon Flame Bombs",
            "Earth Style: Mud Wall",
            "",
            "",
            "",
            "",
            "",
            "",
            "Ninja Hound Summoning",
            "Demon Wind Bomb",
            "",
            "",
            "",
            "",
            "Double Last Resort",
            "Swirling Sand Rasengan",
            "Kachofuketsu",
            "Fragment of a Legend",
            "Dazzling Battle: Beast Scroll Replicas",
            "Temple of Nirvana Technique",
            "",
            "",
            "",
            "",
            "Earth Style Barrier: Earth Dome Prison",
            "Earth Style: Sphere of Graves",
            "Spiral Spider Web",
            "Giant Spider Drop",
            "Musical Manipulation: Tied Madness",
            "Musical Manipulation: Single Burial ",
            "Multiple Fists Barrage",
            "Explosive Destruction Formation",
            "Thorn",
            "Larch Dance ",
            "Instant Light ",
            "Rasengan",
            "Sexy Jutsu",
            "Ninja Tools Toss!",
            "Fierce Palm",
            "Windmill",
            "Wood Style: Universe",
            "Wood Style: Adamantine Forest Call",
            "Infinite Darkness Jutsu",
            "Water Style: Water Wall",
            "",
            "",
            "",
            "",
            "Snake Stomp",
            "Marauding Snakes",
            "Nine-Tailed Fox Power",
            "Vermilion Rasengan",
            "Ultra Gale Formation",
            "Black Chidori",
            "Loopy Lotus",
            "Loopy Eight Whirlwind",
            "Hot Sand Burial ",
            "Sand Shuriken",
            "Butterfly Rage Throw",
            "Butterfly Bomb Sever",
            "Chakra Inhale",
            "Earth Style: Gushing Rock Mountain Cannonball",
            "Heaven Spider Web Net",
            "Destruction Power Bow",
            "Demon Flute: Chains of Fantasia",
            "Demon Flute: Phantom Wave",
            "Twin Pole Drop",
            "Summoning: Rashomon",
            "Vine and Flower",
            "Bracken Dance ",
            "Naruto Uzumaki Combo Attack",
            "Great Ball Rasengan",
            "Medical Ninjutsu: Ferocious Flash",
            "Killer Spring",
            "Sand Cluster",
            "Sand Tsunami",
            "Secret Black Move: Iron Maiden",
            "Secret Black Move: Fire Flower",
            "Slicing Blade Dance",
            "True Wind Scythe Jutsu",
            "Parental Love",
            "1000 Autumn Shower",
            "Iron Sand World Order",
            "Iron Sand Drizzle",
            "Beauty of Figurative Arts",
            "Beauty of Destruction",
            "8 Trigrams Palms Rotation",
            "8 Trigrams Sky Palm",
            "Ninja Tool: Blade of 1000 Strikes",
            "Concealed Kunai Blast",
            "Primary Lotus",
            "Dynamic Entry",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal: Improvement",
            "Maximum Entry",
            "Night Phoenix",
            "Lightning Blade Drop",
            "Lightning Blade",
            "Genjutsu: Shiranui",
            "Fire Style: Fire Ball Jutsu",
            "Water Style: Shark Attack",
            "Water Style: Water Shark Shotgun Jutsu",
            "Crimson Splash",
            "Fake Fox Blast",
            "",
            "",
            "Powerful Blade",
            "Red Secret Technique: Performance of a Hundred Puppets",
            "Tail Road Lu",
            "Mechanical Puppet: Octo Needle Waves",
            "Skillful Manner",
            "1000 Autumn Shower",
            "Dual Raging Fangs",
            "Fang Over Fang",
            "Parasitic Insects: Bind",
            "Parasitic Insects: Feast",
            "8 Trigrams Twin Back Pierce",
            "8 Trigrams 64 Palms Guard",
            "Rage Explosion",
            "Super Slap",
            "Mind Distraction Jutsu",
            "Beautiful Seasons",
            "Toad Blade Cut",
            "Rasengan",
            "Heaven Kick of Pain: Lord of Hosts",
            "Heaven Defending Kick",
            "Hidden Senbon Spray",
            "Ninja Art: Poison Fog",
            "Wolf Fang Drill",
            "Flying Swallow Thrust",
            "Genjutsu: Mirage",
            "Genjutsu: Haze",
            "",
            "",
            "Daenroka",
            "Slithering Snakes",
            "Chakra Dissection: Three",
            "Dead Soul Jutsu",
            "Wood Style: Total Capture ",
            "Wood Style: Wooden Hammer",
            "Ninja Art: Beast Scroll Replicas",
            "Ninja Art: Beast Scroll Replicas \"Wild Dog\" ",
            "Instantaneous Blade",
            "Chidori"});
            this.cmbJutsu2Player2.Location = new System.Drawing.Point(420, 140);
            this.cmbJutsu2Player2.Name = "cmbJutsu2Player2";
            this.cmbJutsu2Player2.Size = new System.Drawing.Size(213, 21);
            this.cmbJutsu2Player2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Player 2 Jutsu 2:";
            // 
            // cmbJutsu1Player2
            // 
            this.cmbJutsu1Player2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJutsu1Player2.FormattingEnabled = true;
            this.cmbJutsu1Player2.Items.AddRange(new object[] {
            "(Default)",
            "(Default)",
            "Multi Shadow Clone Jutsu",
            "Rasengan",
            "Ultra Fire Bullet ",
            "Chidori",
            "Leaf Whirlwind",
            "Leaf Great Hurricane",
            "Sand Burial",
            "Sand Shower ",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal",
            "8 Trigrams Palm Storm Dance",
            "Rotation",
            "This Fairy Tale is for Real!!",
            "Clone Combo",
            "",
            "",
            "",
            "",
            "A Thousand Needles of Death",
            "Crystal Ice Mirrors",
            "Water Style: Water Dragon Jutsu",
            "Demon Slash",
            "8 Trigrams 64 Palms Guard",
            "Super Healing Medicine",
            "Twin Swallow Cut",
            "Sacred Dance Shuriken",
            "Donburi Throw",
            "Spiky Human Boulder",
            "16-hit Combo",
            "Ninja Wolfsbane",
            "Man Beast Clone",
            "Tunneling Fang ",
            "Insect Paralysis Jutsu",
            "Insect Pillar Jutsu",
            "Puppet: Manji Shot",
            "Pair of Maidens",
            "Giant Rumbling Fan Wind Wall",
            "Wind Scythe Jutsu",
            "",
            "",
            "",
            "",
            "Fire Style: Dragon Flame Bombs",
            "Earth Style: Mud Wall",
            "",
            "",
            "",
            "",
            "",
            "",
            "Ninja Hound Summoning",
            "Demon Wind Bomb",
            "",
            "",
            "",
            "",
            "Double Last Resort",
            "Swirling Sand Rasengan",
            "Kachofuketsu",
            "Fragment of a Legend",
            "Dazzling Battle: Beast Scroll Replicas",
            "Temple of Nirvana Technique",
            "",
            "",
            "",
            "",
            "Earth Style Barrier: Earth Dome Prison",
            "Earth Style: Sphere of Graves",
            "Spiral Spider Web",
            "Giant Spider Drop",
            "Musical Manipulation: Tied Madness",
            "Musical Manipulation: Single Burial ",
            "Multiple Fists Barrage",
            "Explosive Destruction Formation",
            "Thorn",
            "Larch Dance ",
            "Instant Light ",
            "Rasengan",
            "Sexy Jutsu",
            "Ninja Tools Toss!",
            "Fierce Palm",
            "Windmill",
            "Wood Style: Universe",
            "Wood Style: Adamantine Forest Call",
            "Infinite Darkness Jutsu",
            "Water Style: Water Wall",
            "",
            "",
            "",
            "",
            "Snake Stomp",
            "Marauding Snakes",
            "Nine-Tailed Fox Power",
            "Vermilion Rasengan",
            "Ultra Gale Formation",
            "Black Chidori",
            "Loopy Lotus",
            "Loopy Eight Whirlwind",
            "Hot Sand Burial ",
            "Sand Shuriken",
            "Butterfly Rage Throw",
            "Butterfly Bomb Sever",
            "Chakra Inhale",
            "Earth Style: Gushing Rock Mountain Cannonball",
            "Heaven Spider Web Net",
            "Destruction Power Bow",
            "Demon Flute: Chains of Fantasia",
            "Demon Flute: Phantom Wave",
            "Twin Pole Drop",
            "Summoning: Rashomon",
            "Vine and Flower",
            "Bracken Dance ",
            "Naruto Uzumaki Combo Attack",
            "Great Ball Rasengan",
            "Medical Ninjutsu: Ferocious Flash",
            "Killer Spring",
            "Sand Cluster",
            "Sand Tsunami",
            "Secret Black Move: Iron Maiden",
            "Secret Black Move: Fire Flower",
            "Slicing Blade Dance",
            "True Wind Scythe Jutsu",
            "Parental Love",
            "1000 Autumn Shower",
            "Iron Sand World Order",
            "Iron Sand Drizzle",
            "Beauty of Figurative Arts",
            "Beauty of Destruction",
            "8 Trigrams Palms Rotation",
            "8 Trigrams Sky Palm",
            "Ninja Tool: Blade of 1000 Strikes",
            "Concealed Kunai Blast",
            "Primary Lotus",
            "Dynamic Entry",
            "Shadow Possession Jutsu",
            "Explosive Style Shadow Conceal: Improvement",
            "Maximum Entry",
            "Night Phoenix",
            "Lightning Blade Drop",
            "Lightning Blade",
            "Genjutsu: Shiranui",
            "Fire Style: Fire Ball Jutsu",
            "Water Style: Shark Attack",
            "Water Style: Water Shark Shotgun Jutsu",
            "Crimson Splash",
            "Fake Fox Blast",
            "",
            "",
            "Powerful Blade",
            "Red Secret Technique: Performance of a Hundred Puppets",
            "Tail Road Lu",
            "Mechanical Puppet: Octo Needle Waves",
            "Skillful Manner",
            "1000 Autumn Shower",
            "Dual Raging Fangs",
            "Fang Over Fang",
            "Parasitic Insects: Bind",
            "Parasitic Insects: Feast",
            "8 Trigrams Twin Back Pierce",
            "8 Trigrams 64 Palms Guard",
            "Rage Explosion",
            "Super Slap",
            "Mind Distraction Jutsu",
            "Beautiful Seasons",
            "Toad Blade Cut",
            "Rasengan",
            "Heaven Kick of Pain: Lord of Hosts",
            "Heaven Defending Kick",
            "Hidden Senbon Spray",
            "Ninja Art: Poison Fog",
            "Wolf Fang Drill",
            "Flying Swallow Thrust",
            "Genjutsu: Mirage",
            "Genjutsu: Haze",
            "",
            "",
            "Daenroka",
            "Slithering Snakes",
            "Chakra Dissection: Three",
            "Dead Soul Jutsu",
            "Wood Style: Total Capture ",
            "Wood Style: Wooden Hammer",
            "Ninja Art: Beast Scroll Replicas",
            "Ninja Art: Beast Scroll Replicas \"Wild Dog\" ",
            "Instantaneous Blade",
            "Chidori"});
            this.cmbJutsu1Player2.Location = new System.Drawing.Point(99, 140);
            this.cmbJutsu1Player2.Name = "cmbJutsu1Player2";
            this.cmbJutsu1Player2.Size = new System.Drawing.Size(212, 21);
            this.cmbJutsu1Player2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Player 2 Jutsu 1:";
            // 
            // cmbStage
            // 
            this.cmbStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStage.FormattingEnabled = true;
            this.cmbStage.Items.AddRange(new object[] {
            "Hidden Leaf Village",
            "Hidden Sand Village",
            "Five-Seal Barrier Cliff",
            "Akatsuki Hideout",
            "Wilderness of Running Water",
            "Twilight Cliff",
            "Training Field",
            "Hidden Leaf Forest",
            "No.44 Exercise Ground The Forest of Death",
            "The Final Valley",
            "Hidden Leaf Gate",
            "Hidden Sand Gate",
            "Great Naruto Bridge",
            "Chunin Exam Stadium",
            "Tanzaku Town Outskirts",
            "Moonlit Field",
            "Blue Sky Plain ",
            "Mirage Desert",
            "Orochimaru\'s Hideout",
            "Foundation\'s Hideout",
            "Altar of Orochi",
            "Tenchi Bridge",
            "Top of Lookout Tower",
            "Tanzaku Town"});
            this.cmbStage.Location = new System.Drawing.Point(52, 302);
            this.cmbStage.Name = "cmbStage";
            this.cmbStage.Size = new System.Drawing.Size(245, 21);
            this.cmbStage.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Stage:";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Items.AddRange(new object[] {
            "(Default)",
            "N. Uzumaki (Classic)",
            "S. Uchiha (Classic)",
            "Rock Lee (Classic)",
            "Gaara (Classic)",
            "S. Nara (Classic)",
            "Neji Hyuga (Classic)",
            "S. Haruno (Classic)",
            "",
            "",
            "Haku",
            "Zabuza Momochi",
            "H. Hyuga (Classic)",
            "Tenten (Classic)",
            "C. Akimichi (Classic)",
            "I. Yamanaka (Class.)",
            "K. Inuzuka (Classic)",
            "S. Aburame (Classic)",
            "Kankuro (Classic)",
            "Temari (Classic)",
            "",
            "",
            "The Third Hokage",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Jirobo",
            "Kidomaru",
            "Tayuya",
            "Sakon",
            "Kimimaro",
            "The Yellow Flash",
            "Konohamaru NS",
            "Hanabi Hyuga",
            "The First Hokage",
            "The Second Hokage",
            "",
            "",
            "Anko Mitarashi",
            "Naruto Uzumaki (Nine-Tailed)",
            "Second Stage Sasuke Uchiha",
            "Loopy Fist Lee",
            "Possessed Gaara",
            "Super Choji",
            "Second Stage Jirobo",
            "Second Stage Kidomaru",
            "Second Stage Tayuya",
            "Second Stage Sakon",
            "Second Stage Kimimaro",
            "Naruto Uzumaki",
            "Sakura Haruno",
            "Kazekage Gaara",
            "Kankuro",
            "Temari",
            "Granny Chiyo ",
            "Sasori",
            "Deidara",
            "Neji Hyuga",
            "Tenten",
            "Rock Lee",
            "Shikamaru Nara",
            "Might Guy",
            "Kakashi Hatake",
            "Itachi Uchiha",
            "Kisame Hoshigaki",
            "Nine-Tailed Fourth Awakened State",
            "",
            "Sasori (Puppet)",
            "Sasori (Hiruko)",
            "Granny Chiyo (Taijutsu)",
            "Kiba Inuzuka",
            "Shino Aburame",
            "Hinata Hyuga",
            "Choji Akimichi",
            "Ino Yamanaka",
            "Jiraiya",
            "Tsunade",
            "Shizune",
            "Asuma Sarutobi",
            "Kurenai Yuhi",
            "",
            "Orochimaru",
            "Kabuto Yakushi",
            "Yamato",
            "Sai",
            "Sasuke Uchiha"});
            this.cmbPlayer1.Location = new System.Drawing.Point(61, 59);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(250, 21);
            this.cmbPlayer1.TabIndex = 38;
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Items.AddRange(new object[] {
            "(Default)",
            "N. Uzumaki (Classic)",
            "S. Uchiha (Classic)",
            "Rock Lee (Classic)",
            "Gaara (Classic)",
            "S. Nara (Classic)",
            "Neji Hyuga (Classic)",
            "S. Haruno (Classic)",
            "",
            "",
            "Haku",
            "Zabuza Momochi",
            "H. Hyuga (Classic)",
            "Tenten (Classic)",
            "C. Akimichi (Classic)",
            "I. Yamanaka (Class.)",
            "K. Inuzuka (Classic)",
            "S. Aburame (Classic)",
            "Kankuro (Classic)",
            "Temari (Classic)",
            "",
            "",
            "The Third Hokage",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Jirobo",
            "Kidomaru",
            "Tayuya",
            "Sakon",
            "Kimimaro",
            "The Yellow Flash",
            "Konohamaru NS",
            "Hanabi Hyuga",
            "The First Hokage",
            "The Second Hokage",
            "",
            "",
            "Anko Mitarashi",
            "Naruto Uzumaki (Nine-Tailed)",
            "Second Stage Sasuke Uchiha",
            "Loopy Fist Lee",
            "Possessed Gaara",
            "Super Choji",
            "Second Stage Jirobo",
            "Second Stage Kidomaru",
            "Second Stage Tayuya",
            "Second Stage Sakon",
            "Second Stage Kimimaro",
            "Naruto Uzumaki",
            "Sakura Haruno",
            "Kazekage Gaara",
            "Kankuro",
            "Temari",
            "Granny Chiyo ",
            "Sasori",
            "Deidara",
            "Neji Hyuga",
            "Tenten",
            "Rock Lee",
            "Shikamaru Nara",
            "Might Guy",
            "Kakashi Hatake",
            "Itachi Uchiha",
            "Kisame Hoshigaki",
            "Nine-Tailed Fourth Awakened State",
            "",
            "Sasori (Puppet)",
            "Sasori (Hiruko)",
            "Granny Chiyo (Taijutsu)",
            "Kiba Inuzuka",
            "Shino Aburame",
            "Hinata Hyuga",
            "Choji Akimichi",
            "Ino Yamanaka",
            "Jiraiya",
            "Tsunade",
            "Shizune",
            "Asuma Sarutobi",
            "Kurenai Yuhi",
            "",
            "Orochimaru",
            "Kabuto Yakushi",
            "Yamato",
            "Sai",
            "Sasuke Uchiha"});
            this.cmbPlayer2.Location = new System.Drawing.Point(383, 59);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(250, 21);
            this.cmbPlayer2.TabIndex = 39;
            // 
            // cmbSuport1
            // 
            this.cmbSuport1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuport1.FormattingEnabled = true;
            this.cmbSuport1.Items.AddRange(new object[] {
            "Naruto Uzumaki",
            "Sakura Haruno",
            "Kakashi Hatake",
            "Neji Hyuuga",
            "Rock Lee",
            "Tenten",
            "Might Guy",
            "Shikamaru Nara",
            "Gaara",
            "Kankuro",
            "Temari",
            "Deidara",
            "Sasori (Hiruko)",
            "Itachi",
            "Kisame",
            "Granny Chiyo (Physical Techniques)",
            "Shino Aburame",
            "Kiba Inuzuka",
            "Hinata Hyuuga",
            "Choji Akimichi",
            "Ino Yamanaka",
            "Asuma Sarutobi",
            "Kurenai Yuhi",
            "",
            "Jiraiya",
            "Tsunade",
            "Shizune",
            "Granny Chiyo (Master Puppet)",
            "Orochimaru",
            "Kabuto Yakushi",
            "Sasori (Master Puppet)",
            "Yamato",
            "Sai",
            "Sasuke",
            "",
            "",
            "",
            "(None)",
            "(Default)"});
            this.cmbSuport1.Location = new System.Drawing.Point(114, 86);
            this.cmbSuport1.Name = "cmbSuport1";
            this.cmbSuport1.Size = new System.Drawing.Size(197, 21);
            this.cmbSuport1.TabIndex = 40;
            // 
            // cmbSuport2
            // 
            this.cmbSuport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuport2.FormattingEnabled = true;
            this.cmbSuport2.Items.AddRange(new object[] {
            "Naruto Uzumaki",
            "Sakura Haruno",
            "Kakashi Hatake",
            "Neji Hyuuga",
            "Rock Lee",
            "Tenten",
            "Might Guy",
            "Shikamaru Nara",
            "Gaara",
            "Kankuro",
            "Temari",
            "Deidara",
            "Sasori (Hiruko)",
            "Itachi",
            "Kisame",
            "Granny Chiyo (Physical Techniques)",
            "Shino Aburame",
            "Kiba Inuzuka",
            "Hinata Hyuuga",
            "Choji Akimichi",
            "Ino Yamanaka",
            "Asuma Sarutobi",
            "Kurenai Yuhi",
            "",
            "Jiraiya",
            "Tsunade",
            "Shizune",
            "Granny Chiyo (Master Puppet)",
            "Orochimaru",
            "Kabuto Yakushi",
            "Sasori (Master Puppet)",
            "Yamato",
            "Sai",
            "Sasuke",
            "",
            "",
            "",
            "(None)",
            "(Default)"});
            this.cmbSuport2.Location = new System.Drawing.Point(435, 86);
            this.cmbSuport2.Name = "cmbSuport2";
            this.cmbSuport2.Size = new System.Drawing.Size(198, 21);
            this.cmbSuport2.TabIndex = 41;
            // 
            // cmbGameOver
            // 
            this.cmbGameOver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameOver.FormattingEnabled = true;
            this.cmbGameOver.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbGameOver.Location = new System.Drawing.Point(356, 275);
            this.cmbGameOver.Name = "cmbGameOver";
            this.cmbGameOver.Size = new System.Drawing.Size(41, 21);
            this.cmbGameOver.TabIndex = 43;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(135, 278);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(215, 13);
            this.lblGameOver.TabIndex = 42;
            this.lblGameOver.Text = "Show \"Game Over\" message if not retrying?";
            // 
            // cmbSelectMode
            // 
            this.cmbSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectMode.FormattingEnabled = true;
            this.cmbSelectMode.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbSelectMode.Location = new System.Drawing.Point(592, 275);
            this.cmbSelectMode.Name = "cmbSelectMode";
            this.cmbSelectMode.Size = new System.Drawing.Size(41, 21);
            this.cmbSelectMode.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Return to Select Mode if not retrying?";
            // 
            // cmbAllowRetry
            // 
            this.cmbAllowRetry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllowRetry.FormattingEnabled = true;
            this.cmbAllowRetry.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbAllowRetry.Location = new System.Drawing.Point(79, 275);
            this.cmbAllowRetry.Name = "cmbAllowRetry";
            this.cmbAllowRetry.Size = new System.Drawing.Size(41, 21);
            this.cmbAllowRetry.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Allow Retry?";
            // 
            // cmbPlayer1UltimateJutsu1
            // 
            this.cmbPlayer1UltimateJutsu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1UltimateJutsu1.FormattingEnabled = true;
            this.cmbPlayer1UltimateJutsu1.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer1UltimateJutsu1.Location = new System.Drawing.Point(86, 167);
            this.cmbPlayer1UltimateJutsu1.Name = "cmbPlayer1UltimateJutsu1";
            this.cmbPlayer1UltimateJutsu1.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer1UltimateJutsu1.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Player 1 UJ 1:";
            // 
            // cmbPlayer1UltimateJutsu2
            // 
            this.cmbPlayer1UltimateJutsu2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1UltimateJutsu2.FormattingEnabled = true;
            this.cmbPlayer1UltimateJutsu2.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer1UltimateJutsu2.Location = new System.Drawing.Point(307, 167);
            this.cmbPlayer1UltimateJutsu2.Name = "cmbPlayer1UltimateJutsu2";
            this.cmbPlayer1UltimateJutsu2.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer1UltimateJutsu2.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Player 1 UJ 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Player 1 UJ 3:";
            // 
            // cmbPlayer1UltimateJutsu3
            // 
            this.cmbPlayer1UltimateJutsu3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1UltimateJutsu3.FormattingEnabled = true;
            this.cmbPlayer1UltimateJutsu3.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer1UltimateJutsu3.Location = new System.Drawing.Point(523, 167);
            this.cmbPlayer1UltimateJutsu3.Name = "cmbPlayer1UltimateJutsu3";
            this.cmbPlayer1UltimateJutsu3.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer1UltimateJutsu3.TabIndex = 54;
            // 
            // cmbPlayer2UltimateJutsu3
            // 
            this.cmbPlayer2UltimateJutsu3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2UltimateJutsu3.FormattingEnabled = true;
            this.cmbPlayer2UltimateJutsu3.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer2UltimateJutsu3.Location = new System.Drawing.Point(523, 194);
            this.cmbPlayer2UltimateJutsu3.Name = "cmbPlayer2UltimateJutsu3";
            this.cmbPlayer2UltimateJutsu3.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer2UltimateJutsu3.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Player 2 UJ 3:";
            // 
            // cmbPlayer2UltimateJutsu2
            // 
            this.cmbPlayer2UltimateJutsu2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2UltimateJutsu2.FormattingEnabled = true;
            this.cmbPlayer2UltimateJutsu2.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer2UltimateJutsu2.Location = new System.Drawing.Point(307, 194);
            this.cmbPlayer2UltimateJutsu2.Name = "cmbPlayer2UltimateJutsu2";
            this.cmbPlayer2UltimateJutsu2.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer2UltimateJutsu2.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(228, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Player 2 UJ 2:";
            // 
            // cmbPlayer2UltimateJutsu1
            // 
            this.cmbPlayer2UltimateJutsu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2UltimateJutsu1.FormattingEnabled = true;
            this.cmbPlayer2UltimateJutsu1.Items.AddRange(new object[] {
            "Ultimate Jutsu 1",
            "Ultimate Jutsu 2",
            "Ultimate Jutsu 3"});
            this.cmbPlayer2UltimateJutsu1.Location = new System.Drawing.Point(86, 194);
            this.cmbPlayer2UltimateJutsu1.Name = "cmbPlayer2UltimateJutsu1";
            this.cmbPlayer2UltimateJutsu1.Size = new System.Drawing.Size(110, 21);
            this.cmbPlayer2UltimateJutsu1.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "Player 2 UJ 1:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBattleName);
            this.panel1.Controls.Add(this.cmbPlayer2UltimateJutsu3);
            this.panel1.Controls.Add(this.txtBattleName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblRyoLose);
            this.panel1.Controls.Add(this.cmbPlayer2UltimateJutsu2);
            this.panel1.Controls.Add(this.lblRyoWin);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.numRyoLose);
            this.panel1.Controls.Add(this.cmbPlayer2UltimateJutsu1);
            this.panel1.Controls.Add(this.numRyoWin);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblDifficulty);
            this.panel1.Controls.Add(this.cmbPlayer1UltimateJutsu3);
            this.panel1.Controls.Add(this.cmbDifficulty);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.numTime);
            this.panel1.Controls.Add(this.cmbPlayer1UltimateJutsu2);
            this.panel1.Controls.Add(this.lblPlayer1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblLinkedCharacter1);
            this.panel1.Controls.Add(this.cmbPlayer1UltimateJutsu1);
            this.panel1.Controls.Add(this.lblLinkedCharacter2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbAllowRetry);
            this.panel1.Controls.Add(this.cmbCondition1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbSelectMode);
            this.panel1.Controls.Add(this.cmbCondition2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCondition3);
            this.panel1.Controls.Add(this.cmbGameOver);
            this.panel1.Controls.Add(this.cmbCondition3);
            this.panel1.Controls.Add(this.lblGameOver);
            this.panel1.Controls.Add(this.lblCondition4);
            this.panel1.Controls.Add(this.cmbSuport2);
            this.panel1.Controls.Add(this.cmbCondition4);
            this.panel1.Controls.Add(this.cmbSuport1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbPlayer2);
            this.panel1.Controls.Add(this.cmbJutsu1Player1);
            this.panel1.Controls.Add(this.cmbPlayer1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbStage);
            this.panel1.Controls.Add(this.cmbJutsu2Player1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbJutsu2Player2);
            this.panel1.Controls.Add(this.cmbJutsu1Player2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(208, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 345);
            this.panel1.TabIndex = 62;
            this.panel1.Visible = false;
            // 
            // EditBattleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 369);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditBattleData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Battle Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRyoLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRyoWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox txtBattleName;
        public System.Windows.Forms.Label lblBattleName;
        public System.Windows.Forms.Label lblRyoLose;
        public System.Windows.Forms.Label lblRyoWin;
        public System.Windows.Forms.NumericUpDown numRyoLose;
        public System.Windows.Forms.NumericUpDown numRyoWin;
        public System.Windows.Forms.Label lblDifficulty;
        public System.Windows.Forms.ComboBox cmbDifficulty;
        public System.Windows.Forms.NumericUpDown numTime;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblPlayer1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLinkedCharacter1;
        public System.Windows.Forms.Label lblLinkedCharacter2;
        public System.Windows.Forms.ComboBox cmbCondition1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbCondition2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbCondition3;
        public System.Windows.Forms.Label lblCondition3;
        public System.Windows.Forms.ComboBox cmbCondition4;
        public System.Windows.Forms.Label lblCondition4;
        public System.Windows.Forms.ComboBox cmbJutsu1Player1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbJutsu2Player1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbJutsu2Player2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbJutsu1Player2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbStage;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbPlayer1;
        public System.Windows.Forms.ComboBox cmbPlayer2;
        public System.Windows.Forms.ComboBox cmbSuport1;
        public System.Windows.Forms.ComboBox cmbSuport2;
        public System.Windows.Forms.ComboBox cmbGameOver;
        public System.Windows.Forms.Label lblGameOver;
        public System.Windows.Forms.ComboBox cmbSelectMode;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbAllowRetry;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbPlayer1UltimateJutsu1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmbPlayer1UltimateJutsu2;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cmbPlayer1UltimateJutsu3;
        public System.Windows.Forms.ComboBox cmbPlayer2UltimateJutsu3;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cmbPlayer2UltimateJutsu2;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cmbPlayer2UltimateJutsu1;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem battleToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
    }
}