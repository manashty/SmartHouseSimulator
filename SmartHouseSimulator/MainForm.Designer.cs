namespace SmartHouseSimulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateReadOnlySensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleATaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseHouseBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_DrawLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Rectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_Select = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog_SaveProject = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_OpenProject = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleATaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_ChooseHouseBackground = new System.Windows.Forms.OpenFileDialog();
            this.timer_setSchedule = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_UploadSensorData = new System.Windows.Forms.ToolStripButton();
            this.btn_DownloadObjectData = new System.Windows.Forms.ToolStripButton();
            this.timer_Upload_Download = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer_Scenario = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog_SaveAddedObjects = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_LoadObjects = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_showStatus = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_StartSimulation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_PauseSimulation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SetTimeNow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_TimeRate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txt_ShowsimulatedTime = new System.Windows.Forms.ToolStripTextBox();
            this.timer_SimulateTime = new System.Windows.Forms.Timer(this.components);
            this.timer_showSimulatedTime = new System.Windows.Forms.Timer(this.components);
            this.chbox_SimulatedTime = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ServerAddress = new System.Windows.Forms.ToolStripTextBox();
            this.btn_SetNewAddress = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageSensorsToolStripMenuItem,
            this.simulateReadOnlySensorsToolStripMenuItem,
            this.addObjectToolStripMenuItem,
            this.scheduleATaskToolStripMenuItem,
            this.defineScenarioToolStripMenuItem,
            this.chooseHouseBackgroundToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.undoToolStripMenuItem.Text = "&Smart House";
            // 
            // manageSensorsToolStripMenuItem
            // 
            this.manageSensorsToolStripMenuItem.Name = "manageSensorsToolStripMenuItem";
            this.manageSensorsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.manageSensorsToolStripMenuItem.Text = "Simulate Controlable Sensors (Actuators)";
            this.manageSensorsToolStripMenuItem.Click += new System.EventHandler(this.manageSensorsToolStripMenuItem_Click);
            // 
            // simulateReadOnlySensorsToolStripMenuItem
            // 
            this.simulateReadOnlySensorsToolStripMenuItem.Name = "simulateReadOnlySensorsToolStripMenuItem";
            this.simulateReadOnlySensorsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.simulateReadOnlySensorsToolStripMenuItem.Text = "Simulate Read-Only Sensors";
            this.simulateReadOnlySensorsToolStripMenuItem.Click += new System.EventHandler(this.simulateReadOnlySensorsToolStripMenuItem_Click);
            // 
            // addObjectToolStripMenuItem
            // 
            this.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem";
            this.addObjectToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.addObjectToolStripMenuItem.Text = "Simulate House Objects";
            this.addObjectToolStripMenuItem.Click += new System.EventHandler(this.addObjectToolStripMenuItem_Click_1);
            // 
            // scheduleATaskToolStripMenuItem
            // 
            this.scheduleATaskToolStripMenuItem.Name = "scheduleATaskToolStripMenuItem";
            this.scheduleATaskToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.scheduleATaskToolStripMenuItem.Text = "Define Scheduled Task";
            this.scheduleATaskToolStripMenuItem.Click += new System.EventHandler(this.scheduleATaskToolStripMenuItem_Click);
            // 
            // defineScenarioToolStripMenuItem
            // 
            this.defineScenarioToolStripMenuItem.Name = "defineScenarioToolStripMenuItem";
            this.defineScenarioToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.defineScenarioToolStripMenuItem.Text = "Define Scenario";
            this.defineScenarioToolStripMenuItem.Click += new System.EventHandler(this.defineScenarioToolStripMenuItem_Click);
            // 
            // chooseHouseBackgroundToolStripMenuItem
            // 
            this.chooseHouseBackgroundToolStripMenuItem.Name = "chooseHouseBackgroundToolStripMenuItem";
            this.chooseHouseBackgroundToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.chooseHouseBackgroundToolStripMenuItem.Text = "Load House Plan";
            this.chooseHouseBackgroundToolStripMenuItem.Click += new System.EventHandler(this.chooseHouseBackgroundToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.toolsToolStripMenuItem.Text = "&Smart HouseTools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.customizeToolStripMenuItem.Text = "&Save Simulated Objects";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.LoadToolStripMenuItem.Text = "&Load Simulated Objets";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(103, 623);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DragLeave += new System.EventHandler(this.listView1_DragLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "400_F_9986381_9FuHHZGAd1WsTGkjyVMNLdtlC6QojSfi.jpg");
            this.imageList1.Images.SetKeyName(1, "oven_icon.jpg");
            this.imageList1.Images.SetKeyName(2, "Door Icon.jpg");
            this.imageList1.Images.SetKeyName(3, "pitivi.png");
            this.imageList1.Images.SetKeyName(4, "banshee.png");
            this.imageList1.Images.SetKeyName(5, "video-display.png");
            this.imageList1.Images.SetKeyName(6, "fINALlaMP.png");
            this.imageList1.Images.SetKeyName(7, "Drying-Machine-icon.png");
            this.imageList1.Images.SetKeyName(8, "fingerprint-reader-icon.png");
            this.imageList1.Images.SetKeyName(9, "Toaster-2-icon.png");
            this.imageList1.Images.SetKeyName(10, "Washing-Machine-icon.png");
            this.imageList1.Images.SetKeyName(11, "Sony-TRV-99-open-icon.png");
            this.imageList1.Images.SetKeyName(12, "Toaster-icon.png");
            this.imageList1.Images.SetKeyName(13, "Speaker-icon.png");
            this.imageList1.Images.SetKeyName(14, "QuickCam-VC-icon.png");
            this.imageList1.Images.SetKeyName(15, "100917.jpg");
            this.imageList1.Images.SetKeyName(16, "8708231.jpg");
            this.imageList1.Images.SetKeyName(17, "11971054672097824636biswajyotim_Fan.svg.thumb.png");
            this.imageList1.Images.SetKeyName(18, "1217862501743393068speciwoman_coffee_machine.svg.med.png");
            this.imageList1.Images.SetKeyName(19, "1240169870492294635Angelo_Gemmi_street_lamp.svg.thumb.png");
            this.imageList1.Images.SetKeyName(20, "12543127731203853223table fan_jh.svg.thumb.png");
            this.imageList1.Images.SetKeyName(21, "air_conditioner_icon.jpg");
            this.imageList1.Images.SetKeyName(22, "ap12000s_icon.jpg");
            this.imageList1.Images.SetKeyName(23, "CarGrey.png");
            this.imageList1.Images.SetKeyName(24, "Computer.ico");
            this.imageList1.Images.SetKeyName(25, "door_icon_small_200.JPG");
            this.imageList1.Images.SetKeyName(26, "E36DF76GPS_724_L01 (1).jpg");
            this.imageList1.Images.SetKeyName(27, "Elevated-Oven_Icon.png");
            this.imageList1.Images.SetKeyName(28, "EXperience speakers twin.ico");
            this.imageList1.Images.SetKeyName(29, "freestanding-upright-chef-electric-oven-ebc5271w-icon (1).jpg");
            this.imageList1.Images.SetKeyName(30, "Hamilton-Beach-Countertop-Oven-with-Convection-&-Rotisserie~img~HMB~HMB1040_m.jpg" +
                    "");
            this.imageList1.Images.SetKeyName(31, "Harman Kardon SoundSticks II Speakers only.ico");
            this.imageList1.Images.SetKeyName(32, "Microwave-Oven.ico");
            this.imageList1.Images.SetKeyName(33, "Minicar.ico");
            this.imageList1.Images.SetKeyName(34, "Retro Toaster.ico");
            this.imageList1.Images.SetKeyName(35, "Speaker.ico");
            this.imageList1.Images.SetKeyName(36, "Television (1).ico");
            this.imageList1.Images.SetKeyName(37, "textbox_tv.png");
            this.imageList1.Images.SetKeyName(38, "Toaster.ico");
            this.imageList1.Images.SetKeyName(39, "Toaster-2.ico");
            this.imageList1.Images.SetKeyName(40, "washing machine LG.jpg");
            this.imageList1.Images.SetKeyName(41, "Off Lamp.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_DrawLine,
            this.toolStripButton_Rectangle,
            this.toolStripLabel_Select});
            this.toolStrip1.Location = new System.Drawing.Point(1094, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(41, 623);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton_DrawLine
            // 
            this.toolStripButton_DrawLine.AutoSize = false;
            this.toolStripButton_DrawLine.CheckOnClick = true;
            this.toolStripButton_DrawLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DrawLine.Image = global::SmartHouseSimulator.Properties.Resources.Line4;
            this.toolStripButton_DrawLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DrawLine.Name = "toolStripButton_DrawLine";
            this.toolStripButton_DrawLine.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_DrawLine.Text = "Draw Line";
            this.toolStripButton_DrawLine.Click += new System.EventHandler(this.toolStripButton_DrawLine_Click);
            // 
            // toolStripButton_Rectangle
            // 
            this.toolStripButton_Rectangle.AutoSize = false;
            this.toolStripButton_Rectangle.CheckOnClick = true;
            this.toolStripButton_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Rectangle.Image = global::SmartHouseSimulator.Properties.Resources.Rectangle1;
            this.toolStripButton_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rectangle.Name = "toolStripButton_Rectangle";
            this.toolStripButton_Rectangle.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Rectangle.Text = "Draw Rectangle";
            this.toolStripButton_Rectangle.Click += new System.EventHandler(this.toolStripButton_Rectangle_Click);
            // 
            // toolStripLabel_Select
            // 
            this.toolStripLabel_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel_Select.Image = global::SmartHouseSimulator.Properties.Resources.Select3;
            this.toolStripLabel_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel_Select.Name = "toolStripLabel_Select";
            this.toolStripLabel_Select.Size = new System.Drawing.Size(38, 20);
            this.toolStripLabel_Select.Text = "Select";
            this.toolStripLabel_Select.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // saveFileDialog_SaveProject
            // 
            this.saveFileDialog_SaveProject.Filter = "Smart House Simulator Files|*.sms";
            // 
            // openFileDialog_OpenProject
            // 
            this.openFileDialog_OpenProject.FileName = "openFileDialog1";
            this.openFileDialog_OpenProject.Filter = "Smart House Simulator Files|*.sms";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStatusToolStripMenuItem,
            this.getStatusToolStripMenuItem,
            this.scheduleATaskToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 70);
            // 
            // setStatusToolStripMenuItem
            // 
            this.setStatusToolStripMenuItem.Name = "setStatusToolStripMenuItem";
            this.setStatusToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setStatusToolStripMenuItem.Text = "Set Status";
            this.setStatusToolStripMenuItem.Click += new System.EventHandler(this.setStatusToolStripMenuItem_Click);
            // 
            // getStatusToolStripMenuItem
            // 
            this.getStatusToolStripMenuItem.Name = "getStatusToolStripMenuItem";
            this.getStatusToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.getStatusToolStripMenuItem.Text = "Get Status";
            this.getStatusToolStripMenuItem.Click += new System.EventHandler(this.getStatusToolStripMenuItem_Click);
            // 
            // scheduleATaskToolStripMenuItem1
            // 
            this.scheduleATaskToolStripMenuItem1.Name = "scheduleATaskToolStripMenuItem1";
            this.scheduleATaskToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.scheduleATaskToolStripMenuItem1.Text = "Schedule a Task";
            this.scheduleATaskToolStripMenuItem1.Click += new System.EventHandler(this.scheduleATaskToolStripMenuItem1_Click);
            // 
            // openFileDialog_ChooseHouseBackground
            // 
            this.openFileDialog_ChooseHouseBackground.FileName = "openFileDialog1";
            // 
            // timer_setSchedule
            // 
            this.timer_setSchedule.Enabled = true;
            this.timer_setSchedule.Interval = 15000;
            this.timer_setSchedule.Tick += new System.EventHandler(this.timer_setSchedule_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_UploadSensorData,
            this.btn_DownloadObjectData,
            this.txt_ServerAddress,
            this.btn_SetNewAddress});
            this.toolStrip2.Location = new System.Drawing.Point(103, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(991, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_UploadSensorData
            // 
            this.btn_UploadSensorData.CheckOnClick = true;
            this.btn_UploadSensorData.Image = global::SmartHouseSimulator.Properties.Resources._96;
            this.btn_UploadSensorData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_UploadSensorData.Name = "btn_UploadSensorData";
            this.btn_UploadSensorData.Size = new System.Drawing.Size(130, 22);
            this.btn_UploadSensorData.Text = "Upload Sensor Data";
            this.btn_UploadSensorData.Click += new System.EventHandler(this.btn_UploadSensorData_Click);
            // 
            // btn_DownloadObjectData
            // 
            this.btn_DownloadObjectData.Image = global::SmartHouseSimulator.Properties.Resources._105;
            this.btn_DownloadObjectData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DownloadObjectData.Name = "btn_DownloadObjectData";
            this.btn_DownloadObjectData.Size = new System.Drawing.Size(146, 22);
            this.btn_DownloadObjectData.Text = "Download Object Data";
            this.btn_DownloadObjectData.Click += new System.EventHandler(this.btn_DownloadObjectData_Click);
            // 
            // timer_Upload_Download
            // 
            this.timer_Upload_Download.Enabled = true;
            this.timer_Upload_Download.Interval = 2000;
            this.timer_Upload_Download.Tick += new System.EventHandler(this.timer_Upload_Download_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(393, 8);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(392, 41);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // timer_Scenario
            // 
            this.timer_Scenario.Enabled = true;
            this.timer_Scenario.Interval = 1500;
            this.timer_Scenario.Tick += new System.EventHandler(this.timer_Scenario_Tick);
            // 
            // saveFileDialog_SaveAddedObjects
            // 
            this.saveFileDialog_SaveAddedObjects.Filter = "SimulatedHouseObjectsFiles|*.sho";
            // 
            // openFileDialog_LoadObjects
            // 
            this.openFileDialog_LoadObjects.Filter = "SimulatedHouseObjectsFiles|*.sho";
            // 
            // toolTip_showStatus
            // 
            this.toolTip_showStatus.AutoPopDelay = 50000;
            this.toolTip_showStatus.InitialDelay = 500;
            this.toolTip_showStatus.ReshowDelay = 100;
            this.toolTip_showStatus.ShowAlways = true;
            this.toolTip_showStatus.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_showStatus.ToolTipTitle = "Object Status:";
            this.toolTip_showStatus.UseAnimation = false;
            this.toolTip_showStatus.UseFading = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(103, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(991, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = false;
            this.lbl_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(128, 17);
            this.lbl_Status.Text = "House Objects Status:";
            this.lbl_Status.Click += new System.EventHandler(this.lbl_Status_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_StartSimulation,
            this.toolStripSeparator3,
            this.btn_PauseSimulation,
            this.toolStripSeparator4,
            this.btn_SetTimeNow,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.txt_TimeRate,
            this.toolStripLabel2,
            this.toolStripSeparator7,
            this.toolStripLabel3,
            this.txt_ShowsimulatedTime});
            this.toolStrip3.Location = new System.Drawing.Point(103, 49);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(991, 25);
            this.toolStrip3.TabIndex = 7;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btn_StartSimulation
            // 
            this.btn_StartSimulation.Image = global::SmartHouseSimulator.Properties.Resources._129;
            this.btn_StartSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_StartSimulation.Name = "btn_StartSimulation";
            this.btn_StartSimulation.Size = new System.Drawing.Size(111, 22);
            this.btn_StartSimulation.Text = "Start Simulation";
            this.btn_StartSimulation.Click += new System.EventHandler(this.btn_StartSimulation_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_PauseSimulation
            // 
            this.btn_PauseSimulation.Image = global::SmartHouseSimulator.Properties.Resources._157;
            this.btn_PauseSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PauseSimulation.Name = "btn_PauseSimulation";
            this.btn_PauseSimulation.Size = new System.Drawing.Size(118, 22);
            this.btn_PauseSimulation.Text = "Pause Simulation";
            this.btn_PauseSimulation.Click += new System.EventHandler(this.btn_PauseSimulation_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_SetTimeNow
            // 
            this.btn_SetTimeNow.Image = global::SmartHouseSimulator.Properties.Resources._135;
            this.btn_SetTimeNow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SetTimeNow.Name = "btn_SetTimeNow";
            this.btn_SetTimeNow.Size = new System.Drawing.Size(168, 22);
            this.btn_SetTimeNow.Text = "Set Simulatio Time to Now";
            this.btn_SetTimeNow.Click += new System.EventHandler(this.btn_SetTimeNow_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(142, 22);
            this.toolStripLabel1.Text = "Rate of Simulation time:";
            // 
            // txt_TimeRate
            // 
            this.txt_TimeRate.Name = "txt_TimeRate";
            this.txt_TimeRate.Size = new System.Drawing.Size(100, 25);
            this.txt_TimeRate.Text = "1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel2.Text = "In Seconds";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel3.Text = "Simulated Time is:";
            // 
            // txt_ShowsimulatedTime
            // 
            this.txt_ShowsimulatedTime.Name = "txt_ShowsimulatedTime";
            this.txt_ShowsimulatedTime.ReadOnly = true;
            this.txt_ShowsimulatedTime.Size = new System.Drawing.Size(100, 25);
            // 
            // timer_SimulateTime
            // 
            this.timer_SimulateTime.Interval = 1000;
            this.timer_SimulateTime.Tick += new System.EventHandler(this.timer_SimulateTime_Tick);
            // 
            // timer_showSimulatedTime
            // 
            this.timer_showSimulatedTime.Enabled = true;
            this.timer_showSimulatedTime.Interval = 50;
            this.timer_showSimulatedTime.Tick += new System.EventHandler(this.timer_showSimulatedTime_Tick);
            // 
            // chbox_SimulatedTime
            // 
            this.chbox_SimulatedTime.AutoSize = true;
            this.chbox_SimulatedTime.Checked = true;
            this.chbox_SimulatedTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_SimulatedTime.Image = global::SmartHouseSimulator.Properties.Resources._75;
            this.chbox_SimulatedTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbox_SimulatedTime.Location = new System.Drawing.Point(823, 8);
            this.chbox_SimulatedTime.Name = "chbox_SimulatedTime";
            this.chbox_SimulatedTime.Size = new System.Drawing.Size(196, 43);
            this.chbox_SimulatedTime.TabIndex = 8;
            this.chbox_SimulatedTime.Text = "\r\n          Simulate With Simulated Time\r\n\r\n";
            this.chbox_SimulatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbox_SimulatedTime.UseVisualStyleBackColor = true;
            this.chbox_SimulatedTime.CheckedChanged += new System.EventHandler(this.chbox_SimulatedTime_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(103, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 623);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txt_ServerAddress
            // 
            this.txt_ServerAddress.Name = "txt_ServerAddress";
            this.txt_ServerAddress.Size = new System.Drawing.Size(100, 25);
            this.txt_ServerAddress.Text = "http://localhost:1316/MobileServer.aspx?";
            // 
            // btn_SetNewAddress
            // 
            this.btn_SetNewAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SetNewAddress.Image = ((System.Drawing.Image)(resources.GetObject("btn_SetNewAddress.Image")));
            this.btn_SetNewAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SetNewAddress.Name = "btn_SetNewAddress";
            this.btn_SetNewAddress.Size = new System.Drawing.Size(72, 22);
            this.btn_SetNewAddress.Text = "Set Address";
            this.btn_SetNewAddress.Click += new System.EventHandler(this.btn_SetNewAddress_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 647);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.chbox_SimulatedTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Smart House Simulator";
            this.MaximizedBoundsChanged += new System.EventHandler(this.MainForm_MaximizedBoundsChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.MainForm_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.MainForm_MinimumSizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_DrawLine;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rectangle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveProject;
        private System.Windows.Forms.OpenFileDialog openFileDialog_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSensorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleATaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleATaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripLabel_Select;
        private System.Windows.Forms.ToolStripMenuItem chooseHouseBackgroundToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ChooseHouseBackground;
        private System.Windows.Forms.Timer timer_setSchedule;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem defineScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_UploadSensorData;
        private System.Windows.Forms.ToolStripButton btn_DownloadObjectData;
        private System.Windows.Forms.Timer timer_Upload_Download;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer_Scenario;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveAddedObjects;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadObjects;
        public System.Windows.Forms.ToolTip toolTip_showStatus;
        private System.Windows.Forms.ToolStripMenuItem simulateReadOnlySensorsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btn_StartSimulation;
        private System.Windows.Forms.ToolStripButton btn_PauseSimulation;
        private System.Windows.Forms.ToolStripButton btn_SetTimeNow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_TimeRate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Timer timer_SimulateTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txt_ShowsimulatedTime;
        private System.Windows.Forms.Timer timer_showSimulatedTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.CheckBox chbox_SimulatedTime;
        private System.Windows.Forms.ToolStripTextBox txt_ServerAddress;
        private System.Windows.Forms.ToolStripButton btn_SetNewAddress;
    }
}

