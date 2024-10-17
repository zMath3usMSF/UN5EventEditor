namespace UN5_Event_Editor
{
    partial class EditFieldItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFieldItem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewFieldItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numPosZ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRotX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStageID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbObject = new System.Windows.Forms.ComboBox();
            this.cmbDisarm = new System.Windows.Forms.ComboBox();
            this.cmbVerify = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFieldItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewFieldItemToolStripMenuItem
            // 
            this.addNewFieldItemToolStripMenuItem.Name = "addNewFieldItemToolStripMenuItem";
            this.addNewFieldItemToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.addNewFieldItemToolStripMenuItem.Text = "Add New Field Item";
            this.addNewFieldItemToolStripMenuItem.Click += new System.EventHandler(this.addNewFieldItemToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 376);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Object:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stage:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position X:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numPosX
            // 
            this.numPosX.Location = new System.Drawing.Point(371, 56);
            this.numPosX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPosX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(56, 20);
            this.numPosX.TabIndex = 19;
            this.numPosX.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Position Y:";
            // 
            // numPosY
            // 
            this.numPosY.Location = new System.Drawing.Point(496, 56);
            this.numPosY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPosY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(56, 20);
            this.numPosY.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Position Z:";
            // 
            // numPosZ
            // 
            this.numPosZ.Location = new System.Drawing.Point(621, 56);
            this.numPosZ.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPosZ.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numPosZ.Name = "numPosZ";
            this.numPosZ.Size = new System.Drawing.Size(56, 20);
            this.numPosZ.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rotation X:";
            // 
            // numRotX
            // 
            this.numRotX.Location = new System.Drawing.Point(749, 56);
            this.numRotX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numRotX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numRotX.Name = "numRotX";
            this.numRotX.Size = new System.Drawing.Size(56, 20);
            this.numRotX.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Allow Disarm?";
            // 
            // cmbItemID
            // 
            this.cmbItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Location = new System.Drawing.Point(510, 29);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(161, 21);
            this.cmbItemID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Item:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Allow Verify?";
            // 
            // cmbStageID
            // 
            this.cmbStageID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStageID.FormattingEnabled = true;
            this.cmbStageID.Items.AddRange(new object[] {
            "Konoha Gate",
            "Ichiraku Ramen",
            "Konoha Tea Street",
            "Konoha Highway",
            "Hokage\'s Room",
            "Konoha Plains",
            "Deep Green Hill",
            "Tool Shop",
            "Training Road",
            "Hokage Highway",
            "Hokage\'s Mansion Rooftop",
            "Third Training Ground",
            "Training Ground 44: Forest of Death",
            "Konoha Hill",
            "Konoha Forest",
            "Wind Forest",
            "Cliff Gorge",
            "Wind Desert",
            "Dusty Desert",
            "Sand Village Gate",
            "Sand Grand Avenue",
            "Kazekage\'s Mansion Rooftop",
            "Sand Cavern",
            "Hot Sand Wasteland",
            "Sand Wind Path",
            "Kazekage\'s Desert",
            "Silent Wasteland",
            "Wind Valley",
            "Five Colors Plain",
            "Barrier Cliff",
            "River Border",
            "Endless Tree Valley",
            "Oblique Light Forest",
            "Way of the Ninja",
            "Heavenly Bridge",
            "Strange Stone Plain",
            "Orochimaru\'s Hideout",
            "Orochimaru\'s Altar",
            "Room One",
            "Room Two",
            "Room Three",
            "Room Four",
            "Room Five",
            "Room Six",
            "Room Seven",
            "Room Eight",
            "Akatsuki Hideout",
            "Stone Hill Valley",
            "Dark Corridor: Beginning Room",
            "First Corridor",
            "Second Corridor",
            "Third Corridor",
            "Fourth Corridor",
            "Fifth Corridor",
            "Sixth Corridor",
            "Seventh Corridor",
            "Eighth Corridor",
            "Ninth Corridor",
            "Tenth Corridor",
            "Eleventh Corridor",
            "Twelfth Corridor",
            "Thirteenth Corridor",
            "Fourteenth Corridor",
            "Fifteenth Corridor",
            "Sixteenth Corridor",
            "Seventeenth Corridor",
            "Eighteenth Corridor",
            "Dark Corridor: End Room",
            "Heaven\'s Path Pass",
            "Light Shadow Path"});
            this.cmbStageID.Location = new System.Drawing.Point(721, 29);
            this.cmbStageID.Name = "cmbStageID";
            this.cmbStageID.Size = new System.Drawing.Size(215, 21);
            this.cmbStageID.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbObject
            // 
            this.cmbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObject.FormattingEnabled = true;
            this.cmbObject.Items.AddRange(new object[] {
            "Bomb",
            "Chest",
            "Secret",
            "Golden Chest"});
            this.cmbObject.Location = new System.Drawing.Point(355, 29);
            this.cmbObject.Name = "cmbObject";
            this.cmbObject.Size = new System.Drawing.Size(113, 21);
            this.cmbObject.TabIndex = 64;
            // 
            // cmbDisarm
            // 
            this.cmbDisarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisarm.FormattingEnabled = true;
            this.cmbDisarm.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbDisarm.Location = new System.Drawing.Point(895, 56);
            this.cmbDisarm.Name = "cmbDisarm";
            this.cmbDisarm.Size = new System.Drawing.Size(41, 21);
            this.cmbDisarm.TabIndex = 65;
            // 
            // cmbVerify
            // 
            this.cmbVerify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVerify.FormattingEnabled = true;
            this.cmbVerify.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbVerify.Location = new System.Drawing.Point(382, 82);
            this.cmbVerify.Name = "cmbVerify";
            this.cmbVerify.Size = new System.Drawing.Size(41, 21);
            this.cmbVerify.TabIndex = 66;
            // 
            // EditFieldItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 400);
            this.Controls.Add(this.cmbVerify);
            this.Controls.Add(this.cmbDisarm);
            this.Controls.Add(this.cmbObject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbStageID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbItemID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numRotX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPosZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPosY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPosX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditFieldItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Field Item:";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbItemID;
        public System.Windows.Forms.NumericUpDown numPosX;
        public System.Windows.Forms.NumericUpDown numPosY;
        public System.Windows.Forms.NumericUpDown numPosZ;
        public System.Windows.Forms.NumericUpDown numRotX;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbStageID;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cmbObject;
        public System.Windows.Forms.ComboBox cmbDisarm;
        public System.Windows.Forms.ComboBox cmbVerify;
        private System.Windows.Forms.ToolStripMenuItem addNewFieldItemToolStripMenuItem;
    }
}