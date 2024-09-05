namespace UN5_Event_Editor
{
    partial class EditSpc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewSpcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numUnk1 = new System.Windows.Forms.NumericUpDown();
            this.cmbEventID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.cmbAutoTalk = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSpcToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewSpcToolStripMenuItem
            // 
            this.addNewSpcToolStripMenuItem.Name = "addNewSpcToolStripMenuItem";
            this.addNewSpcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.addNewSpcToolStripMenuItem.Text = "Add New Spc";
            this.addNewSpcToolStripMenuItem.Click += new System.EventHandler(this.addNewSpcToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // numUnk1
            // 
            this.numUnk1.Location = new System.Drawing.Point(346, 27);
            this.numUnk1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUnk1.Name = "numUnk1";
            this.numUnk1.Size = new System.Drawing.Size(52, 20);
            this.numUnk1.TabIndex = 18;
            // 
            // cmbEventID
            // 
            this.cmbEventID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventID.FormattingEnabled = true;
            this.cmbEventID.Location = new System.Drawing.Point(448, 26);
            this.cmbEventID.Name = "cmbEventID";
            this.cmbEventID.Size = new System.Drawing.Size(140, 21);
            this.cmbEventID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Event:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Unk1:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 426);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Char:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Team:";
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Items.AddRange(new object[] {
            "Naruto",
            "Sakura",
            "Kakashi",
            "Kankuro",
            "Neji",
            "Sai",
            "Sasuke",
            "Jiraiya",
            "Tsunade",
            "Shizune",
            "Asuma",
            "Kurenai",
            "Gaara",
            "Temari",
            "Chiyo",
            "Yamato",
            "Lee",
            "Tenten",
            "Guy",
            "Shikamaru",
            "Choji",
            "Ino",
            "Kiba",
            "Shino",
            "Hinata"});
            this.cmbCharacter.Location = new System.Drawing.Point(632, 26);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(88, 21);
            this.cmbCharacter.TabIndex = 23;
            // 
            // cmbAutoTalk
            // 
            this.cmbAutoTalk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoTalk.FormattingEnabled = true;
            this.cmbAutoTalk.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAutoTalk.Location = new System.Drawing.Point(347, 53);
            this.cmbAutoTalk.Name = "cmbAutoTalk";
            this.cmbAutoTalk.Size = new System.Drawing.Size(41, 21);
            this.cmbAutoTalk.TabIndex = 45;
            // 
            // EditSpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.cmbAutoTalk);
            this.Controls.Add(this.cmbCharacter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUnk1);
            this.Controls.Add(this.cmbEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditSpc";
            this.Text = "EditSpc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown numUnk1;
        public System.Windows.Forms.ComboBox cmbEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem addNewSpcToolStripMenuItem;
        public System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ComboBox cmbAutoTalk;
    }
}