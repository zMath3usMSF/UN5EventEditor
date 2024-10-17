namespace UN5_Event_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBattleData = new System.Windows.Forms.Button();
            this.btnEditCharData = new System.Windows.Forms.Button();
            this.btnEditScriptList = new System.Windows.Forms.Button();
            this.btnEditItemList = new System.Windows.Forms.Button();
            this.btnEditFieldItemList = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCCSToolStripMenuItem,
            this.saveCCSToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openCCSToolStripMenuItem
            // 
            this.openCCSToolStripMenuItem.Name = "openCCSToolStripMenuItem";
            this.openCCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openCCSToolStripMenuItem.Text = "Open EVENT.CCS";
            this.openCCSToolStripMenuItem.Click += new System.EventHandler(this.openCCSToolStripMenuItem_Click);
            // 
            // saveCCSToolStripMenuItem
            // 
            this.saveCCSToolStripMenuItem.Enabled = false;
            this.saveCCSToolStripMenuItem.Name = "saveCCSToolStripMenuItem";
            this.saveCCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCCSToolStripMenuItem.Text = "Save EVENT.CCS";
            this.saveCCSToolStripMenuItem.Click += new System.EventHandler(this.saveCCSToolStripMenuItem_Click);
            // 
            // btnEditBattleData
            // 
            this.btnEditBattleData.Enabled = false;
            this.btnEditBattleData.Location = new System.Drawing.Point(12, 300);
            this.btnEditBattleData.Name = "btnEditBattleData";
            this.btnEditBattleData.Size = new System.Drawing.Size(159, 30);
            this.btnEditBattleData.TabIndex = 1;
            this.btnEditBattleData.Text = "Edit Battle Data";
            this.btnEditBattleData.UseVisualStyleBackColor = true;
            this.btnEditBattleData.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditCharData
            // 
            this.btnEditCharData.Enabled = false;
            this.btnEditCharData.Location = new System.Drawing.Point(342, 264);
            this.btnEditCharData.Name = "btnEditCharData";
            this.btnEditCharData.Size = new System.Drawing.Size(159, 30);
            this.btnEditCharData.TabIndex = 2;
            this.btnEditCharData.Text = "Edit Char Data";
            this.btnEditCharData.UseVisualStyleBackColor = true;
            this.btnEditCharData.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditScriptList
            // 
            this.btnEditScriptList.Enabled = false;
            this.btnEditScriptList.Location = new System.Drawing.Point(177, 264);
            this.btnEditScriptList.Name = "btnEditScriptList";
            this.btnEditScriptList.Size = new System.Drawing.Size(159, 30);
            this.btnEditScriptList.TabIndex = 3;
            this.btnEditScriptList.Text = "Edit Event ID List";
            this.btnEditScriptList.UseVisualStyleBackColor = true;
            this.btnEditScriptList.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditItemList
            // 
            this.btnEditItemList.Enabled = false;
            this.btnEditItemList.Location = new System.Drawing.Point(507, 264);
            this.btnEditItemList.Name = "btnEditItemList";
            this.btnEditItemList.Size = new System.Drawing.Size(159, 30);
            this.btnEditItemList.TabIndex = 8;
            this.btnEditItemList.Text = "Edit Item List";
            this.btnEditItemList.UseVisualStyleBackColor = true;
            this.btnEditItemList.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnEditFieldItemList
            // 
            this.btnEditFieldItemList.Enabled = false;
            this.btnEditFieldItemList.Location = new System.Drawing.Point(177, 300);
            this.btnEditFieldItemList.Name = "btnEditFieldItemList";
            this.btnEditFieldItemList.Size = new System.Drawing.Size(159, 30);
            this.btnEditFieldItemList.TabIndex = 9;
            this.btnEditFieldItemList.Text = "Edit Field Item List";
            this.btnEditFieldItemList.UseVisualStyleBackColor = true;
            this.btnEditFieldItemList.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(12, 264);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(159, 30);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Edit Event Tree";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UN5_Event_Editor.Properties.Resources.EVENTBackgroundImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 320);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnEditFieldItemList);
            this.Controls.Add(this.btnEditItemList);
            this.Controls.Add(this.btnEditScriptList);
            this.Controls.Add(this.btnEditCharData);
            this.Controls.Add(this.btnEditBattleData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UN5 EVENT.CCS Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCCSToolStripMenuItem;
        private System.Windows.Forms.Button btnEditBattleData;
        private System.Windows.Forms.Button btnEditCharData;
        private System.Windows.Forms.Button btnEditScriptList;
        private System.Windows.Forms.Button btnEditItemList;
        private System.Windows.Forms.Button btnEditFieldItemList;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

