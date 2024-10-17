namespace UN5_Event_Editor
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUnk1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numStockLimit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numSunaPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEnabled = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSunaPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Icon:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 426);
            this.listBox1.TabIndex = 9;
            // 
            // rchDescription
            // 
            this.rchDescription.Location = new System.Drawing.Point(75, 49);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(473, 96);
            this.rchDescription.TabIndex = 10;
            this.rchDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 20);
            this.txtName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Unk1:";
            // 
            // numUnk1
            // 
            this.numUnk1.Location = new System.Drawing.Point(48, 151);
            this.numUnk1.Name = "numUnk1";
            this.numUnk1.Size = new System.Drawing.Size(47, 20);
            this.numUnk1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Category:";
            // 
            // numPurchasePrice
            // 
            this.numPurchasePrice.Location = new System.Drawing.Point(94, 177);
            this.numPurchasePrice.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numPurchasePrice.Name = "numPurchasePrice";
            this.numPurchasePrice.Size = new System.Drawing.Size(71, 20);
            this.numPurchasePrice.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Purchase Price:";
            // 
            // numStockLimit
            // 
            this.numStockLimit.Location = new System.Drawing.Point(484, 151);
            this.numStockLimit.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numStockLimit.Name = "numStockLimit";
            this.numStockLimit.Size = new System.Drawing.Size(64, 20);
            this.numStockLimit.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stock Limit:";
            // 
            // numSunaPurchasePrice
            // 
            this.numSunaPurchasePrice.Location = new System.Drawing.Point(287, 177);
            this.numSunaPurchasePrice.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numSunaPurchasePrice.Name = "numSunaPurchasePrice";
            this.numSunaPurchasePrice.Size = new System.Drawing.Size(71, 20);
            this.numSunaPurchasePrice.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Suna Purchase Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Enabled?";
            // 
            // numSellingPrice
            // 
            this.numSellingPrice.Location = new System.Drawing.Point(438, 177);
            this.numSellingPrice.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numSellingPrice.Name = "numSellingPrice";
            this.numSellingPrice.Size = new System.Drawing.Size(71, 20);
            this.numSellingPrice.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Selling Price:";
            // 
            // cmbEnabled
            // 
            this.cmbEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnabled.FormattingEnabled = true;
            this.cmbEnabled.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbEnabled.Location = new System.Drawing.Point(353, 150);
            this.cmbEnabled.Name = "cmbEnabled";
            this.cmbEnabled.Size = new System.Drawing.Size(41, 21);
            this.cmbEnabled.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.cmbEnabled);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numSellingPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.rchDescription);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSunaPurchasePrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.numStockLimit);
            this.panel1.Controls.Add(this.numUnk1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numPurchasePrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(274, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 426);
            this.panel1.TabIndex = 63;
            this.panel1.Visible = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Normal",
            "(Hidden)",
            "Battle",
            "Important",
            "Acessory"});
            this.cmbCategory.Location = new System.Drawing.Point(159, 150);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(130, 21);
            this.cmbCategory.TabIndex = 63;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSunaPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellingPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numUnk1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numPurchasePrice;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numStockLimit;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown numSunaPurchasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown numSellingPrice;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEnabled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        public System.Windows.Forms.ComboBox cmbCategory;
    }
}