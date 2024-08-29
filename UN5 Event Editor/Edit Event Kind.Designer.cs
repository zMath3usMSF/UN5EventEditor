namespace UN5_Event_Editor
{
    partial class EditEventKind
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEventID = new System.Windows.Forms.ComboBox();
            this.numUnk1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUnk2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUnk3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 426);
            this.listBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Block Name:";
            // 
            // cmbEventID
            // 
            this.cmbEventID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventID.FormattingEnabled = true;
            this.cmbEventID.Location = new System.Drawing.Point(401, 26);
            this.cmbEventID.Name = "cmbEventID";
            this.cmbEventID.Size = new System.Drawing.Size(140, 21);
            this.cmbEventID.TabIndex = 10;
            // 
            // numUnk1
            // 
            this.numUnk1.Location = new System.Drawing.Point(265, 27);
            this.numUnk1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUnk1.Name = "numUnk1";
            this.numUnk1.Size = new System.Drawing.Size(56, 20);
            this.numUnk1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unk 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unk 2:";
            // 
            // numUnk2
            // 
            this.numUnk2.Location = new System.Drawing.Point(589, 27);
            this.numUnk2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUnk2.Name = "numUnk2";
            this.numUnk2.Size = new System.Drawing.Size(56, 20);
            this.numUnk2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unk 3:";
            // 
            // numUnk3
            // 
            this.numUnk3.Location = new System.Drawing.Point(693, 27);
            this.numUnk3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUnk3.Name = "numUnk3";
            this.numUnk3.Size = new System.Drawing.Size(56, 20);
            this.numUnk3.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditEventKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUnk3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUnk2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEventID);
            this.Controls.Add(this.numUnk1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditEventKind";
            this.Text = "Edit Event Kind:";
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbEventID;
        private System.Windows.Forms.NumericUpDown numUnk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUnk2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUnk3;
        private System.Windows.Forms.Button button1;
    }
}