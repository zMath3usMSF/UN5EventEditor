namespace UN5_Event_Editor
{
    partial class EditScriptList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScriptList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCS_TBL = new System.Windows.Forms.TextBox();
            this.txtEvent_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewScriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewScriptToolStripMenuItem
            // 
            this.addNewScriptToolStripMenuItem.Name = "addNewScriptToolStripMenuItem";
            this.addNewScriptToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.addNewScriptToolStripMenuItem.Text = "Add New Event ID";
            this.addNewScriptToolStripMenuItem.Click += new System.EventHandler(this.addNewScriptToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 426);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Block Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CCS:";
            // 
            // txtCCS_TBL
            // 
            this.txtCCS_TBL.Location = new System.Drawing.Point(46, 3);
            this.txtCCS_TBL.MaxLength = 28;
            this.txtCCS_TBL.Name = "txtCCS_TBL";
            this.txtCCS_TBL.Size = new System.Drawing.Size(162, 20);
            this.txtCCS_TBL.TabIndex = 9;
            // 
            // txtEvent_ID
            // 
            this.txtEvent_ID.Location = new System.Drawing.Point(288, 3);
            this.txtEvent_ID.MaxLength = 26;
            this.txtEvent_ID.Name = "txtEvent_ID";
            this.txtEvent_ID.Size = new System.Drawing.Size(162, 20);
            this.txtEvent_ID.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEvent_ID);
            this.panel1.Controls.Add(this.txtCCS_TBL);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(209, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 426);
            this.panel1.TabIndex = 63;
            this.panel1.Visible = false;
            // 
            // EditScriptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditScriptList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Event ID List:";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCCS_TBL;
        private System.Windows.Forms.TextBox txtEvent_ID;
        private System.Windows.Forms.ToolStripMenuItem addNewScriptToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListBox listBox1;
    }
}