namespace UN5_Event_Editor
{
    partial class AddNewEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEventID = new System.Windows.Forms.ComboBox();
            this.cmbTrigger = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trigger:";
            // 
            // cmbEventID
            // 
            this.cmbEventID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventID.FormattingEnabled = true;
            this.cmbEventID.Location = new System.Drawing.Point(70, 6);
            this.cmbEventID.Name = "cmbEventID";
            this.cmbEventID.Size = new System.Drawing.Size(140, 21);
            this.cmbEventID.TabIndex = 15;
            // 
            // cmbTrigger
            // 
            this.cmbTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrigger.FormattingEnabled = true;
            this.cmbTrigger.Items.AddRange(new object[] {
            "Kind",
            "Other",
            "Event",
            "Talk",
            "Stage",
            "Sphere",
            "Spc",
            "Time",
            "Item",
            "Plch"});
            this.cmbTrigger.Location = new System.Drawing.Point(265, 6);
            this.cmbTrigger.Name = "cmbTrigger";
            this.cmbTrigger.Size = new System.Drawing.Size(98, 21);
            this.cmbTrigger.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 76);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTrigger);
            this.Controls.Add(this.cmbEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Event:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbEventID;
        public System.Windows.Forms.ComboBox cmbTrigger;
        public System.Windows.Forms.Button button1;
    }
}