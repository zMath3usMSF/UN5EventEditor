namespace UN5_Event_Editor
{
    partial class Teste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKind = new System.Windows.Forms.GroupBox();
            this.cmbKind = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numOtherValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numOtherProgressFlag = new System.Windows.Forms.NumericUpDown();
            this.grpOther = new System.Windows.Forms.GroupBox();
            this.cmbOtherConditional = new System.Windows.Forms.ComboBox();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEventState = new System.Windows.Forms.ComboBox();
            this.cmbEventConditional = new System.Windows.Forms.ComboBox();
            this.cmbEventEventID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTalkCharID = new System.Windows.Forms.ComboBox();
            this.cmbTalkAutoTalk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpTalk = new System.Windows.Forms.GroupBox();
            this.cmbTalkStageID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpStage = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbStageStageID = new System.Windows.Forms.ComboBox();
            this.cmbStageActivation = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.grpSphere = new System.Windows.Forms.GroupBox();
            this.cmbSphereConfirmation = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.numSphereScale = new System.Windows.Forms.NumericUpDown();
            this.cmbSphereActivation = new System.Windows.Forms.ComboBox();
            this.numSpherePosY = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numSpherePosZ = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numSpherePosX = new System.Windows.Forms.NumericUpDown();
            this.cmbSphereStageID = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numTimeUnk2 = new System.Windows.Forms.NumericUpDown();
            this.grpSpc = new System.Windows.Forms.GroupBox();
            this.cmbSpcTeam = new System.Windows.Forms.ComboBox();
            this.cmbSpcCharacter = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbItemItemID = new System.Windows.Forms.ComboBox();
            this.numStockCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.grpKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherProgressFlag)).BeginInit();
            this.grpOther.SuspendLayout();
            this.grpEvent.SuspendLayout();
            this.grpTalk.SuspendLayout();
            this.grpStage.SuspendLayout();
            this.grpSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSphereScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeUnk2)).BeginInit();
            this.grpSpc.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 459);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EventID";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Index";
            this.columnHeader3.Width = 38;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trigger";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            this.contextMenuStrip1.Text = "Event";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // grpKind
            // 
            this.grpKind.Controls.Add(this.cmbKind);
            this.grpKind.Controls.Add(this.label3);
            this.grpKind.Location = new System.Drawing.Point(335, 3);
            this.grpKind.Name = "grpKind";
            this.grpKind.Size = new System.Drawing.Size(422, 51);
            this.grpKind.TabIndex = 6;
            this.grpKind.TabStop = false;
            this.grpKind.Text = "Boot Event Kind";
            this.grpKind.Visible = false;
            // 
            // cmbKind
            // 
            this.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKind.FormattingEnabled = true;
            this.cmbKind.Items.AddRange(new object[] {
            "Main",
            "Collection (Music Box)",
            "Collection (Progress)",
            "Request (Skill)",
            "Request 1",
            "Request 2",
            "Other",
            "Town"});
            this.cmbKind.Location = new System.Drawing.Point(43, 19);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.Size = new System.Drawing.Size(151, 21);
            this.cmbKind.TabIndex = 55;
            this.cmbKind.SelectedIndexChanged += new System.EventHandler(this.cmbKind_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kind:";
            // 
            // numOtherValue
            // 
            this.numOtherValue.Location = new System.Drawing.Point(198, 19);
            this.numOtherValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numOtherValue.Name = "numOtherValue";
            this.numOtherValue.Size = new System.Drawing.Size(56, 20);
            this.numOtherValue.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Other:";
            // 
            // numOtherProgressFlag
            // 
            this.numOtherProgressFlag.Location = new System.Drawing.Point(49, 19);
            this.numOtherProgressFlag.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numOtherProgressFlag.Name = "numOtherProgressFlag";
            this.numOtherProgressFlag.Size = new System.Drawing.Size(53, 20);
            this.numOtherProgressFlag.TabIndex = 21;
            // 
            // grpOther
            // 
            this.grpOther.Controls.Add(this.cmbOtherConditional);
            this.grpOther.Controls.Add(this.numOtherProgressFlag);
            this.grpOther.Controls.Add(this.label5);
            this.grpOther.Controls.Add(this.label2);
            this.grpOther.Controls.Add(this.numOtherValue);
            this.grpOther.Location = new System.Drawing.Point(335, 3);
            this.grpOther.Name = "grpOther";
            this.grpOther.Size = new System.Drawing.Size(423, 49);
            this.grpOther.TabIndex = 21;
            this.grpOther.TabStop = false;
            this.grpOther.Text = "Check Other State";
            this.grpOther.Visible = false;
            // 
            // cmbOtherConditional
            // 
            this.cmbOtherConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtherConditional.FormattingEnabled = true;
            this.cmbOtherConditional.Items.AddRange(new object[] {
            "<=",
            ">=",
            "=="});
            this.cmbOtherConditional.Location = new System.Drawing.Point(108, 19);
            this.cmbOtherConditional.Name = "cmbOtherConditional";
            this.cmbOtherConditional.Size = new System.Drawing.Size(41, 21);
            this.cmbOtherConditional.TabIndex = 55;
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.label1);
            this.grpEvent.Controls.Add(this.cmbEventState);
            this.grpEvent.Controls.Add(this.cmbEventConditional);
            this.grpEvent.Controls.Add(this.cmbEventEventID);
            this.grpEvent.Controls.Add(this.label6);
            this.grpEvent.Location = new System.Drawing.Point(335, 3);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Size = new System.Drawing.Size(422, 52);
            this.grpEvent.TabIndex = 26;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Check Event State";
            this.grpEvent.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "State:";
            // 
            // cmbEventState
            // 
            this.cmbEventState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventState.FormattingEnabled = true;
            this.cmbEventState.Items.AddRange(new object[] {
            "Not Runned",
            "Runned 1",
            "Runned 2",
            "Runned 3",
            "Runned 4",
            "Runned 5",
            "Runned 6",
            "Runned 7",
            "Finished"});
            this.cmbEventState.Location = new System.Drawing.Point(295, 19);
            this.cmbEventState.Name = "cmbEventState";
            this.cmbEventState.Size = new System.Drawing.Size(112, 21);
            this.cmbEventState.TabIndex = 56;
            // 
            // cmbEventConditional
            // 
            this.cmbEventConditional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventConditional.FormattingEnabled = true;
            this.cmbEventConditional.Items.AddRange(new object[] {
            "<=",
            ">=",
            "=="});
            this.cmbEventConditional.Location = new System.Drawing.Point(207, 19);
            this.cmbEventConditional.Name = "cmbEventConditional";
            this.cmbEventConditional.Size = new System.Drawing.Size(41, 21);
            this.cmbEventConditional.TabIndex = 58;
            // 
            // cmbEventEventID
            // 
            this.cmbEventEventID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventEventID.FormattingEnabled = true;
            this.cmbEventEventID.Location = new System.Drawing.Point(50, 19);
            this.cmbEventEventID.Name = "cmbEventEventID";
            this.cmbEventEventID.Size = new System.Drawing.Size(151, 21);
            this.cmbEventEventID.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Event:";
            // 
            // cmbTalkCharID
            // 
            this.cmbTalkCharID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalkCharID.FormattingEnabled = true;
            this.cmbTalkCharID.Location = new System.Drawing.Point(45, 19);
            this.cmbTalkCharID.Name = "cmbTalkCharID";
            this.cmbTalkCharID.Size = new System.Drawing.Size(192, 21);
            this.cmbTalkCharID.TabIndex = 46;
            // 
            // cmbTalkAutoTalk
            // 
            this.cmbTalkAutoTalk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalkAutoTalk.FormattingEnabled = true;
            this.cmbTalkAutoTalk.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbTalkAutoTalk.Location = new System.Drawing.Point(305, 17);
            this.cmbTalkAutoTalk.Name = "cmbTalkAutoTalk";
            this.cmbTalkAutoTalk.Size = new System.Drawing.Size(41, 21);
            this.cmbTalkAutoTalk.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Char:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Auto Talk:";
            // 
            // grpTalk
            // 
            this.grpTalk.Controls.Add(this.cmbTalkStageID);
            this.grpTalk.Controls.Add(this.cmbTalkAutoTalk);
            this.grpTalk.Controls.Add(this.label13);
            this.grpTalk.Controls.Add(this.label10);
            this.grpTalk.Controls.Add(this.label9);
            this.grpTalk.Controls.Add(this.cmbTalkCharID);
            this.grpTalk.Location = new System.Drawing.Point(335, 3);
            this.grpTalk.Name = "grpTalk";
            this.grpTalk.Size = new System.Drawing.Size(422, 76);
            this.grpTalk.TabIndex = 27;
            this.grpTalk.TabStop = false;
            this.grpTalk.Text = "Boot Talk";
            this.grpTalk.Visible = false;
            // 
            // cmbTalkStageID
            // 
            this.cmbTalkStageID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalkStageID.FormattingEnabled = true;
            this.cmbTalkStageID.Items.AddRange(new object[] {
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
            this.cmbTalkStageID.Location = new System.Drawing.Point(49, 45);
            this.cmbTalkStageID.Name = "cmbTalkStageID";
            this.cmbTalkStageID.Size = new System.Drawing.Size(215, 21);
            this.cmbTalkStageID.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Stage:";
            // 
            // grpStage
            // 
            this.grpStage.Controls.Add(this.label12);
            this.grpStage.Controls.Add(this.cmbStageStageID);
            this.grpStage.Controls.Add(this.cmbStageActivation);
            this.grpStage.Controls.Add(this.label15);
            this.grpStage.Location = new System.Drawing.Point(335, 3);
            this.grpStage.Name = "grpStage";
            this.grpStage.Size = new System.Drawing.Size(422, 80);
            this.grpStage.TabIndex = 55;
            this.grpStage.TabStop = false;
            this.grpStage.Text = "Check Stage Change";
            this.grpStage.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Activation Mode:";
            // 
            // cmbStageStageID
            // 
            this.cmbStageStageID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStageStageID.FormattingEnabled = true;
            this.cmbStageStageID.Items.AddRange(new object[] {
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
            this.cmbStageStageID.Location = new System.Drawing.Point(49, 19);
            this.cmbStageStageID.Name = "cmbStageStageID";
            this.cmbStageStageID.Size = new System.Drawing.Size(215, 21);
            this.cmbStageStageID.TabIndex = 41;
            // 
            // cmbStageActivation
            // 
            this.cmbStageActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStageActivation.FormattingEnabled = true;
            this.cmbStageActivation.Items.AddRange(new object[] {
            "Exit (After Loading)",
            "Exit (Before Loading)",
            "Enter (After Loading)",
            "Enter (Before Loading)",
            "Exit (???)"});
            this.cmbStageActivation.Location = new System.Drawing.Point(98, 46);
            this.cmbStageActivation.Name = "cmbStageActivation";
            this.cmbStageActivation.Size = new System.Drawing.Size(140, 21);
            this.cmbStageActivation.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Stage:";
            // 
            // grpSphere
            // 
            this.grpSphere.Controls.Add(this.cmbSphereConfirmation);
            this.grpSphere.Controls.Add(this.label25);
            this.grpSphere.Controls.Add(this.label29);
            this.grpSphere.Controls.Add(this.numSphereScale);
            this.grpSphere.Controls.Add(this.cmbSphereActivation);
            this.grpSphere.Controls.Add(this.numSpherePosY);
            this.grpSphere.Controls.Add(this.label22);
            this.grpSphere.Controls.Add(this.label28);
            this.grpSphere.Controls.Add(this.label21);
            this.grpSphere.Controls.Add(this.numSpherePosZ);
            this.grpSphere.Controls.Add(this.label19);
            this.grpSphere.Controls.Add(this.numSpherePosX);
            this.grpSphere.Controls.Add(this.cmbSphereStageID);
            this.grpSphere.Controls.Add(this.label17);
            this.grpSphere.Location = new System.Drawing.Point(335, 3);
            this.grpSphere.Name = "grpSphere";
            this.grpSphere.Size = new System.Drawing.Size(422, 105);
            this.grpSphere.TabIndex = 56;
            this.grpSphere.TabStop = false;
            this.grpSphere.Text = "Boot Sphere";
            this.grpSphere.Visible = false;
            // 
            // cmbSphereConfirmation
            // 
            this.cmbSphereConfirmation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSphereConfirmation.FormattingEnabled = true;
            this.cmbSphereConfirmation.Items.AddRange(new object[] {
            "None",
            "Pick up",
            "Talk (Automatically positions on NPC)",
            "Check",
            "Pick up (Arrow)",
            "Talk (Arrow)",
            "Check (Aim)",
            "None (Aim)"});
            this.cmbSphereConfirmation.Location = new System.Drawing.Point(243, 72);
            this.cmbSphereConfirmation.Name = "cmbSphereConfirmation";
            this.cmbSphereConfirmation.Size = new System.Drawing.Size(168, 21);
            this.cmbSphereConfirmation.TabIndex = 66;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Position Y:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(169, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 65;
            this.label29.Text = "Confirmation:";
            // 
            // numSphereScale
            // 
            this.numSphereScale.Location = new System.Drawing.Point(341, 46);
            this.numSphereScale.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSphereScale.Name = "numSphereScale";
            this.numSphereScale.Size = new System.Drawing.Size(70, 20);
            this.numSphereScale.TabIndex = 62;
            // 
            // cmbSphereActivation
            // 
            this.cmbSphereActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSphereActivation.FormattingEnabled = true;
            this.cmbSphereActivation.Items.AddRange(new object[] {
            "Enter",
            "Confirm",
            "Hit"});
            this.cmbSphereActivation.Location = new System.Drawing.Point(99, 72);
            this.cmbSphereActivation.Name = "cmbSphereActivation";
            this.cmbSphereActivation.Size = new System.Drawing.Size(64, 21);
            this.cmbSphereActivation.TabIndex = 64;
            // 
            // numSpherePosY
            // 
            this.numSpherePosY.Location = new System.Drawing.Point(69, 46);
            this.numSpherePosY.Maximum = new decimal(new int[] {
            267656191,
            152586,
            0,
            0});
            this.numSpherePosY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSpherePosY.Name = "numSpherePosY";
            this.numSpherePosY.Size = new System.Drawing.Size(77, 20);
            this.numSpherePosY.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(298, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "Scale:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 13);
            this.label28.TabIndex = 63;
            this.label28.Text = "Activation Mode:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(152, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "Position Z:";
            // 
            // numSpherePosZ
            // 
            this.numSpherePosZ.Location = new System.Drawing.Point(215, 46);
            this.numSpherePosZ.Maximum = new decimal(new int[] {
            267656191,
            152586,
            0,
            0});
            this.numSpherePosZ.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSpherePosZ.Name = "numSpherePosZ";
            this.numSpherePosZ.Size = new System.Drawing.Size(77, 20);
            this.numSpherePosZ.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(271, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Position X:";
            // 
            // numSpherePosX
            // 
            this.numSpherePosX.Location = new System.Drawing.Point(334, 19);
            this.numSpherePosX.Maximum = new decimal(new int[] {
            267656191,
            152586,
            0,
            0});
            this.numSpherePosX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSpherePosX.Name = "numSpherePosX";
            this.numSpherePosX.Size = new System.Drawing.Size(77, 20);
            this.numSpherePosX.TabIndex = 47;
            // 
            // cmbSphereStageID
            // 
            this.cmbSphereStageID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSphereStageID.FormattingEnabled = true;
            this.cmbSphereStageID.Items.AddRange(new object[] {
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
            this.cmbSphereStageID.Location = new System.Drawing.Point(50, 19);
            this.cmbSphereStageID.Name = "cmbSphereStageID";
            this.cmbSphereStageID.Size = new System.Drawing.Size(215, 21);
            this.cmbSphereStageID.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Stage:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Time:";
            // 
            // numTimeUnk2
            // 
            this.numTimeUnk2.Location = new System.Drawing.Point(45, 19);
            this.numTimeUnk2.Maximum = new decimal(new int[] {
            267656191,
            152586,
            0,
            0});
            this.numTimeUnk2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numTimeUnk2.Name = "numTimeUnk2";
            this.numTimeUnk2.Size = new System.Drawing.Size(77, 20);
            this.numTimeUnk2.TabIndex = 49;
            // 
            // grpSpc
            // 
            this.grpSpc.Controls.Add(this.cmbSpcTeam);
            this.grpSpc.Controls.Add(this.cmbSpcCharacter);
            this.grpSpc.Controls.Add(this.label23);
            this.grpSpc.Controls.Add(this.label24);
            this.grpSpc.Location = new System.Drawing.Point(335, 4);
            this.grpSpc.Name = "grpSpc";
            this.grpSpc.Size = new System.Drawing.Size(422, 50);
            this.grpSpc.TabIndex = 63;
            this.grpSpc.TabStop = false;
            this.grpSpc.Text = "Check Team State";
            this.grpSpc.Visible = false;
            // 
            // cmbSpcTeam
            // 
            this.cmbSpcTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpcTeam.FormattingEnabled = true;
            this.cmbSpcTeam.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbSpcTeam.Location = new System.Drawing.Point(221, 19);
            this.cmbSpcTeam.Name = "cmbSpcTeam";
            this.cmbSpcTeam.Size = new System.Drawing.Size(41, 21);
            this.cmbSpcTeam.TabIndex = 49;
            // 
            // cmbSpcCharacter
            // 
            this.cmbSpcCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpcCharacter.FormattingEnabled = true;
            this.cmbSpcCharacter.Items.AddRange(new object[] {
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
            this.cmbSpcCharacter.Location = new System.Drawing.Point(43, 19);
            this.cmbSpcCharacter.Name = "cmbSpcCharacter";
            this.cmbSpcCharacter.Size = new System.Drawing.Size(129, 21);
            this.cmbSpcCharacter.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(178, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Team:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Char:";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.label20);
            this.grpTime.Controls.Add(this.numTimeUnk2);
            this.grpTime.Location = new System.Drawing.Point(335, 4);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(422, 47);
            this.grpTime.TabIndex = 64;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Check Play Time ";
            this.grpTime.Visible = false;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.label26);
            this.grpItem.Controls.Add(this.label27);
            this.grpItem.Controls.Add(this.cmbItemItemID);
            this.grpItem.Controls.Add(this.numStockCount);
            this.grpItem.Location = new System.Drawing.Point(335, 4);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(423, 55);
            this.grpItem.TabIndex = 63;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Check Item Stock";
            this.grpItem.Visible = false;
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 66;
            this.label26.Text = "Item:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(211, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 57;
            this.label27.Text = "Stock >=";
            // 
            // cmbItemItemID
            // 
            this.cmbItemItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemItemID.FormattingEnabled = true;
            this.cmbItemItemID.Location = new System.Drawing.Point(44, 19);
            this.cmbItemItemID.Name = "cmbItemItemID";
            this.cmbItemItemID.Size = new System.Drawing.Size(161, 21);
            this.cmbItemItemID.TabIndex = 65;
            // 
            // numStockCount
            // 
            this.numStockCount.Location = new System.Drawing.Point(267, 22);
            this.numStockCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numStockCount.Name = "numStockCount";
            this.numStockCount.Size = new System.Drawing.Size(56, 20);
            this.numStockCount.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 459);
            this.Controls.Add(this.grpTalk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpEvent);
            this.Controls.Add(this.grpOther);
            this.Controls.Add(this.grpKind);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpSpc);
            this.Controls.Add(this.grpSphere);
            this.Controls.Add(this.grpStage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Event Tree:";
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpKind.ResumeLayout(false);
            this.grpKind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherProgressFlag)).EndInit();
            this.grpOther.ResumeLayout(false);
            this.grpOther.PerformLayout();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.grpTalk.ResumeLayout(false);
            this.grpTalk.PerformLayout();
            this.grpStage.ResumeLayout(false);
            this.grpStage.PerformLayout();
            this.grpSphere.ResumeLayout(false);
            this.grpSphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSphereScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpherePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeUnk2)).EndInit();
            this.grpSpc.ResumeLayout(false);
            this.grpSpc.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grpKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOtherValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOtherProgressFlag;
        private System.Windows.Forms.GroupBox grpOther;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbTalkCharID;
        public System.Windows.Forms.ComboBox cmbTalkAutoTalk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpTalk;
        public System.Windows.Forms.ComboBox cmbTalkStageID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpStage;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbStageStageID;
        public System.Windows.Forms.ComboBox cmbStageActivation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpSphere;
        public System.Windows.Forms.ComboBox cmbSphereStageID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numSpherePosZ;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numTimeUnk2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numSpherePosX;
        private System.Windows.Forms.NumericUpDown numSphereScale;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grpSpc;
        public System.Windows.Forms.ComboBox cmbSpcTeam;
        public System.Windows.Forms.ComboBox cmbSpcCharacter;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numSpherePosY;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numStockCount;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.ComboBox cmbItemItemID;
        public System.Windows.Forms.ComboBox cmbSphereActivation;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.ComboBox cmbSphereConfirmation;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        public System.Windows.Forms.ComboBox cmbKind;
        public System.Windows.Forms.ComboBox cmbOtherConditional;
        public System.Windows.Forms.ComboBox cmbEventEventID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbEventState;
        public System.Windows.Forms.ComboBox cmbEventConditional;
    }
}