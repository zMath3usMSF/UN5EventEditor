namespace UN5_Event_Editor
{
    partial class Edit_Boot_Talk
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
            this.addNewTalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCharID = new System.Windows.Forms.ComboBox();
            this.cmbEventID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numEventFlag = new System.Windows.Forms.NumericUpDown();
            this.numStageID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUnkFlag2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAutoTalk = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStageID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnkFlag2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTalkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewTalkToolStripMenuItem
            // 
            this.addNewTalkToolStripMenuItem.Name = "addNewTalkToolStripMenuItem";
            this.addNewTalkToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.addNewTalkToolStripMenuItem.Text = "Add New Talk";
            this.addNewTalkToolStripMenuItem.Click += new System.EventHandler(this.addNewTalkToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 426);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Char:";
            // 
            // cmbCharID
            // 
            this.cmbCharID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharID.FormattingEnabled = true;
            this.cmbCharID.Location = new System.Drawing.Point(421, 3);
            this.cmbCharID.Name = "cmbCharID";
            this.cmbCharID.Size = new System.Drawing.Size(155, 21);
            this.cmbCharID.TabIndex = 3;
            // 
            // cmbEventID
            // 
            this.cmbEventID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventID.FormattingEnabled = true;
            this.cmbEventID.Location = new System.Drawing.Point(237, 3);
            this.cmbEventID.Name = "cmbEventID";
            this.cmbEventID.Size = new System.Drawing.Size(140, 21);
            this.cmbEventID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Block Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "History Progress:";
            // 
            // numEventFlag
            // 
            this.numEventFlag.Location = new System.Drawing.Point(101, 4);
            this.numEventFlag.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numEventFlag.Name = "numEventFlag";
            this.numEventFlag.Size = new System.Drawing.Size(56, 20);
            this.numEventFlag.TabIndex = 7;
            // 
            // numStageID
            // 
            this.numStageID.Location = new System.Drawing.Point(53, 30);
            this.numStageID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStageID.Name = "numStageID";
            this.numStageID.Size = new System.Drawing.Size(104, 20);
            this.numStageID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stage:";
            // 
            // numUnkFlag2
            // 
            this.numUnkFlag2.Location = new System.Drawing.Point(311, 30);
            this.numUnkFlag2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUnkFlag2.Name = "numUnkFlag2";
            this.numUnkFlag2.Size = new System.Drawing.Size(73, 20);
            this.numUnkFlag2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Auto Talk?";
            // 
            // cmbAutoTalk
            // 
            this.cmbAutoTalk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoTalk.FormattingEnabled = true;
            this.cmbAutoTalk.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbAutoTalk.Location = new System.Drawing.Point(228, 29);
            this.cmbAutoTalk.Name = "cmbAutoTalk";
            this.cmbAutoTalk.Size = new System.Drawing.Size(41, 21);
            this.cmbAutoTalk.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbCharID);
            this.panel1.Controls.Add(this.cmbAutoTalk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numUnkFlag2);
            this.panel1.Controls.Add(this.cmbEventID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numStageID);
            this.panel1.Controls.Add(this.numEventFlag);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(212, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 426);
            this.panel1.TabIndex = 63;
            this.panel1.Visible = false;
            // 
            // Edit_Boot_Talk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Edit_Boot_Talk";
            this.Text = "Edit_Boot_Talk";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStageID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnkFlag2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCharID;
        public System.Windows.Forms.ComboBox cmbEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEventFlag;
        private System.Windows.Forms.NumericUpDown numStageID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUnkFlag2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbAutoTalk;
        private System.Windows.Forms.ToolStripMenuItem addNewTalkToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
    }
}