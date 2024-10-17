namespace UN5_Event_Editor
{
    partial class EditCharData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCharData));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewCharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNamesToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchCharDescription = new System.Windows.Forms.RichTextBox();
            this.txtCharCCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtANM1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtANM2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtANM3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtANM4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtANM5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 426);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCharToolStripMenuItem,
            this.utilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewCharToolStripMenuItem
            // 
            this.addNewCharToolStripMenuItem.Name = "addNewCharToolStripMenuItem";
            this.addNewCharToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addNewCharToolStripMenuItem.Text = "Add New Char";
            this.addNewCharToolStripMenuItem.Click += new System.EventHandler(this.addNewCharToolStripMenuItem_Click);
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.importNamesToTXTToolStripMenuItem});
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.utilToolStripMenuItem.Text = "Util";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eToolStripMenuItem.Text = "Export Names to TXT";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // importNamesToTXTToolStripMenuItem
            // 
            this.importNamesToTXTToolStripMenuItem.Name = "importNamesToTXTToolStripMenuItem";
            this.importNamesToTXTToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.importNamesToTXTToolStripMenuItem.Text = "Import Names from TXT";
            this.importNamesToTXTToolStripMenuItem.Click += new System.EventHandler(this.importNamesToTXTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(52, 6);
            this.txtCharName.MaxLength = 32;
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(239, 20);
            this.txtCharName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // rchCharDescription
            // 
            this.rchCharDescription.Location = new System.Drawing.Point(77, 32);
            this.rchCharDescription.MaxLength = 64;
            this.rchCharDescription.Name = "rchCharDescription";
            this.rchCharDescription.Size = new System.Drawing.Size(214, 96);
            this.rchCharDescription.TabIndex = 5;
            this.rchCharDescription.Text = "";
            // 
            // txtCharCCS
            // 
            this.txtCharCCS.Location = new System.Drawing.Point(45, 134);
            this.txtCharCCS.MaxLength = 32;
            this.txtCharCCS.Name = "txtCharCCS";
            this.txtCharCCS.Size = new System.Drawing.Size(246, 20);
            this.txtCharCCS.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CCS:";
            // 
            // txtANM1
            // 
            this.txtANM1.Location = new System.Drawing.Point(79, 160);
            this.txtANM1.MaxLength = 32;
            this.txtANM1.Name = "txtANM1";
            this.txtANM1.Size = new System.Drawing.Size(212, 20);
            this.txtANM1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animation 1:";
            // 
            // txtANM2
            // 
            this.txtANM2.Location = new System.Drawing.Point(79, 186);
            this.txtANM2.MaxLength = 32;
            this.txtANM2.Name = "txtANM2";
            this.txtANM2.Size = new System.Drawing.Size(212, 20);
            this.txtANM2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Animation 2:";
            // 
            // txtANM3
            // 
            this.txtANM3.Location = new System.Drawing.Point(79, 212);
            this.txtANM3.MaxLength = 32;
            this.txtANM3.Name = "txtANM3";
            this.txtANM3.Size = new System.Drawing.Size(212, 20);
            this.txtANM3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Animation 3:";
            // 
            // txtANM4
            // 
            this.txtANM4.Location = new System.Drawing.Point(79, 238);
            this.txtANM4.MaxLength = 32;
            this.txtANM4.Name = "txtANM4";
            this.txtANM4.Size = new System.Drawing.Size(212, 20);
            this.txtANM4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Animation 4:";
            // 
            // txtANM5
            // 
            this.txtANM5.Location = new System.Drawing.Point(79, 264);
            this.txtANM5.MaxLength = 32;
            this.txtANM5.Name = "txtANM5";
            this.txtANM5.Size = new System.Drawing.Size(212, 20);
            this.txtANM5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Animation 5:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 391);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtANM5);
            this.panel1.Controls.Add(this.txtCharName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtANM4);
            this.panel1.Controls.Add(this.rchCharDescription);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtANM3);
            this.panel1.Controls.Add(this.txtCharCCS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtANM2);
            this.panel1.Controls.Add(this.txtANM1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(296, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 426);
            this.panel1.TabIndex = 63;
            this.panel1.Visible = false;
            // 
            // EditCharData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditCharData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Char Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewCharToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox rchCharDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem utilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNamesToTXTToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtCharName;
        public System.Windows.Forms.TextBox txtCharCCS;
        public System.Windows.Forms.TextBox txtANM1;
        public System.Windows.Forms.TextBox txtANM2;
        public System.Windows.Forms.TextBox txtANM3;
        public System.Windows.Forms.TextBox txtANM4;
        public System.Windows.Forms.TextBox txtANM5;
        private System.Windows.Forms.Panel panel1;
    }
}