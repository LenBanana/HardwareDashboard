namespace HardwareDashboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainIcon = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.tempPanel = new System.Windows.Forms.Panel();
            this.tempIcon = new System.Windows.Forms.PictureBox();
            this.hddPanel = new System.Windows.Forms.Panel();
            this.hddIcon = new System.Windows.Forms.PictureBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.testPanel = new System.Windows.Forms.Panel();
            this.testIcon = new System.Windows.Forms.PictureBox();
            this.modernSlider1 = new HardwareDashboard.ModernSlider();
            this.roundedPanel3 = new CircleLoadingBar.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.hddBar = new CircleLoadingBar.VerticalProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.memoryLoad = new CircleLoadingBar.VerticalProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new CircleLoadingBar.RoundedPanel();
            this.gpuLoadCheck = new HardwareDashboard.ModernCheckBox();
            this.gpuLbl = new System.Windows.Forms.Label();
            this.gpuLoadGauge = new CircleLoadingBar.Gauge();
            this.roundedPanel2 = new CircleLoadingBar.RoundedPanel();
            this.lineGraph = new HardwareDashboard.MultilevelLineGraph();
            this.sliderValue = new System.Windows.Forms.Label();
            this.modernCheckBox3 = new HardwareDashboard.ModernCheckBox();
            this.modernCheckBox2 = new HardwareDashboard.ModernCheckBox();
            this.modernCheckBox1 = new HardwareDashboard.ModernCheckBox();
            this.multilineBorder = new HardwareDashboard.ModernCheckBox();
            this.multilineCheck = new HardwareDashboard.ModernCheckBox();
            this.cpuCorePanel = new CircleLoadingBar.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuTotalPanel = new CircleLoadingBar.RoundedPanel();
            this.cpuLoadCheck = new HardwareDashboard.ModernCheckBox();
            this.cpuLoadGauge = new CircleLoadingBar.Gauge();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.tempPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempIcon)).BeginInit();
            this.hddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hddIcon)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testIcon)).BeginInit();
            this.roundedPanel3.ContentsPanel.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel1.ContentsPanel.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.ContentsPanel.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.cpuCorePanel.ContentsPanel.SuspendLayout();
            this.cpuCorePanel.SuspendLayout();
            this.cpuTotalPanel.ContentsPanel.SuspendLayout();
            this.cpuTotalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(97)))), ((int)(((byte)(178)))));
            this.topPanel.Controls.Add(this.pictureBox3);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.MainIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(883, 30);
            this.topPanel.TabIndex = 6;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::HardwareDashboard.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(784, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HardwareDashboard.Properties.Resources.maximize;
            this.pictureBox2.Location = new System.Drawing.Point(815, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HardwareDashboard.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(846, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainIcon
            // 
            this.MainIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainIcon.Image = global::HardwareDashboard.Properties.Resources.favicon;
            this.MainIcon.Location = new System.Drawing.Point(0, -2);
            this.MainIcon.Name = "MainIcon";
            this.MainIcon.Size = new System.Drawing.Size(48, 36);
            this.MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainIcon.TabIndex = 0;
            this.MainIcon.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(97)))), ((int)(((byte)(178)))));
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.tempPanel);
            this.sidePanel.Controls.Add(this.hddPanel);
            this.sidePanel.Controls.Add(this.settingsPanel);
            this.sidePanel.Controls.Add(this.testPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 30);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(48, 605);
            this.sidePanel.TabIndex = 7;
            // 
            // tempPanel
            // 
            this.tempPanel.Controls.Add(this.tempIcon);
            this.tempPanel.Location = new System.Drawing.Point(0, 146);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.Size = new System.Drawing.Size(50, 50);
            this.tempPanel.TabIndex = 4;
            // 
            // tempIcon
            // 
            this.tempIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tempIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempIcon.Image = global::HardwareDashboard.Properties.Resources.temps;
            this.tempIcon.Location = new System.Drawing.Point(0, 0);
            this.tempIcon.Name = "tempIcon";
            this.tempIcon.Size = new System.Drawing.Size(50, 50);
            this.tempIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tempIcon.TabIndex = 1;
            this.tempIcon.TabStop = false;
            // 
            // hddPanel
            // 
            this.hddPanel.Controls.Add(this.hddIcon);
            this.hddPanel.Location = new System.Drawing.Point(0, 97);
            this.hddPanel.Name = "hddPanel";
            this.hddPanel.Size = new System.Drawing.Size(50, 50);
            this.hddPanel.TabIndex = 3;
            // 
            // hddIcon
            // 
            this.hddIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hddIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hddIcon.Image = global::HardwareDashboard.Properties.Resources.HDD;
            this.hddIcon.Location = new System.Drawing.Point(0, 0);
            this.hddIcon.Name = "hddIcon";
            this.hddIcon.Size = new System.Drawing.Size(50, 50);
            this.hddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hddIcon.TabIndex = 1;
            this.hddIcon.TabStop = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsIcon);
            this.settingsPanel.Location = new System.Drawing.Point(0, 48);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(50, 50);
            this.settingsPanel.TabIndex = 2;
            // 
            // settingsIcon
            // 
            this.settingsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsIcon.Image = global::HardwareDashboard.Properties.Resources.computer_settings;
            this.settingsIcon.Location = new System.Drawing.Point(0, 0);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(50, 50);
            this.settingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settingsIcon.TabIndex = 1;
            this.settingsIcon.TabStop = false;
            this.settingsIcon.MouseEnter += new System.EventHandler(this.settingsIcon_MouseEnter);
            this.settingsIcon.MouseLeave += new System.EventHandler(this.settingsIcon_MouseLeave);
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.testIcon);
            this.testPanel.Location = new System.Drawing.Point(0, -1);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(50, 50);
            this.testPanel.TabIndex = 0;
            // 
            // testIcon
            // 
            this.testIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.testIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testIcon.Image = global::HardwareDashboard.Properties.Resources.Test_Bigger_Light;
            this.testIcon.Location = new System.Drawing.Point(0, 0);
            this.testIcon.Name = "testIcon";
            this.testIcon.Size = new System.Drawing.Size(50, 50);
            this.testIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.testIcon.TabIndex = 1;
            this.testIcon.TabStop = false;
            this.testIcon.Click += new System.EventHandler(this.testIcon_Click);
            // 
            // modernSlider1
            // 
            this.modernSlider1.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.modernSlider1.BallSize = 15F;
            this.modernSlider1.BarBackColor = System.Drawing.Color.Gray;
            this.modernSlider1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.modernSlider1.Location = new System.Drawing.Point(58, 543);
            this.modernSlider1.MaxValue = 100000F;
            this.modernSlider1.Name = "modernSlider1";
            this.modernSlider1.Size = new System.Drawing.Size(262, 60);
            this.modernSlider1.SliderBarHeight = 3;
            this.modernSlider1.TabIndex = 11;
            this.modernSlider1.Value = 5000F;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            // 
            // roundedPanel3.ContentsPanel
            // 
            this.roundedPanel3.ContentsPanel.Controls.Add(this.label4);
            this.roundedPanel3.ContentsPanel.Controls.Add(this.hddBar);
            this.roundedPanel3.ContentsPanel.Controls.Add(this.label3);
            this.roundedPanel3.ContentsPanel.Controls.Add(this.memoryLoad);
            this.roundedPanel3.ContentsPanel.Controls.Add(this.label1);
            this.roundedPanel3.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.ContentsPanel.Enabled = true;
            this.roundedPanel3.ContentsPanel.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel3.ContentsPanel.Name = "ContentsPanel";
            this.roundedPanel3.ContentsPanel.Size = new System.Drawing.Size(262, 262);
            this.roundedPanel3.ContentsPanel.TabIndex = 0;
            this.roundedPanel3.ContentsPanel.Visible = true;
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.Corners = new bool[] {
        false,
        false,
        true,
        true};
            this.roundedPanel3.Location = new System.Drawing.Point(609, 30);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(262, 262);
            this.roundedPanel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(150, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "HDD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hddBar
            // 
            this.hddBar.BackgroundColor = System.Drawing.Color.DimGray;
            this.hddBar.BarColor = new System.Drawing.Color[] {
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Green};
            this.hddBar.ColorAngle = 0F;
            this.hddBar.Edge = false;
            this.hddBar.EdgeColor = System.Drawing.Color.DimGray;
            this.hddBar.Location = new System.Drawing.Point(156, 52);
            this.hddBar.MaxValue = 100D;
            this.hddBar.Name = "hddBar";
            this.hddBar.Size = new System.Drawing.Size(25, 167);
            this.hddBar.TabIndex = 6;
            this.hddBar.Value = 25D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(60, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryLoad
            // 
            this.memoryLoad.BackgroundColor = System.Drawing.Color.DimGray;
            this.memoryLoad.BarColor = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Teal};
            this.memoryLoad.ColorAngle = 0F;
            this.memoryLoad.Edge = true;
            this.memoryLoad.EdgeColor = System.Drawing.Color.DarkGray;
            this.memoryLoad.Location = new System.Drawing.Point(66, 52);
            this.memoryLoad.MaxValue = 100D;
            this.memoryLoad.Name = "memoryLoad";
            this.memoryLoad.Size = new System.Drawing.Size(25, 167);
            this.memoryLoad.TabIndex = 4;
            this.memoryLoad.Value = 25D;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Memory | HDD usage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            // 
            // roundedPanel1.ContentsPanel
            // 
            this.roundedPanel1.ContentsPanel.Controls.Add(this.gpuLoadCheck);
            this.roundedPanel1.ContentsPanel.Controls.Add(this.gpuLbl);
            this.roundedPanel1.ContentsPanel.Controls.Add(this.gpuLoadGauge);
            this.roundedPanel1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.ContentsPanel.Enabled = true;
            this.roundedPanel1.ContentsPanel.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.ContentsPanel.Name = "ContentsPanel";
            this.roundedPanel1.ContentsPanel.Size = new System.Drawing.Size(262, 262);
            this.roundedPanel1.ContentsPanel.TabIndex = 0;
            this.roundedPanel1.ContentsPanel.Visible = true;
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Corners = new bool[] {
        false,
        false,
        true,
        true};
            this.roundedPanel1.Location = new System.Drawing.Point(332, 30);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(262, 262);
            this.roundedPanel1.TabIndex = 4;
            // 
            // gpuLoadCheck
            // 
            this.gpuLoadCheck.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.gpuLoadCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.gpuLoadCheck.Checked = true;
            this.gpuLoadCheck.DisabledColor = System.Drawing.Color.Gray;
            this.gpuLoadCheck.Location = new System.Drawing.Point(3, 234);
            this.gpuLoadCheck.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.gpuLoadCheck.MaximumSize = new System.Drawing.Size(80, 25);
            this.gpuLoadCheck.MinimumSize = new System.Drawing.Size(80, 25);
            this.gpuLoadCheck.Name = "gpuLoadCheck";
            this.gpuLoadCheck.Size = new System.Drawing.Size(80, 25);
            this.gpuLoadCheck.TabIndex = 4;
            // 
            // gpuLbl
            // 
            this.gpuLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gpuLbl.Location = new System.Drawing.Point(0, 13);
            this.gpuLbl.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.gpuLbl.Name = "gpuLbl";
            this.gpuLbl.Size = new System.Drawing.Size(262, 17);
            this.gpuLbl.TabIndex = 3;
            this.gpuLbl.Text = "GPU Load";
            this.gpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuLoadGauge
            // 
            this.gpuLoadGauge.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpuLoadGauge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.gpuLoadGauge.BallSize = 12;
            this.gpuLoadGauge.BarBackground = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            this.gpuLoadGauge.BarColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))))};
            this.gpuLoadGauge.BarWidth = 50;
            this.gpuLoadGauge.ColorAngle = 0F;
            this.gpuLoadGauge.ColorAngleForeground = 0F;
            this.gpuLoadGauge.ColorLive = true;
            this.gpuLoadGauge.DisplayMinMax = true;
            this.gpuLoadGauge.DisplayPercentages = false;
            this.gpuLoadGauge.DisplayPointer = true;
            this.gpuLoadGauge.DisplayText = true;
            this.gpuLoadGauge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLoadGauge.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gpuLoadGauge.Location = new System.Drawing.Point(44, 108);
            this.gpuLoadGauge.Margin = new System.Windows.Forms.Padding(21);
            this.gpuLoadGauge.MarkLineWidth = 1;
            this.gpuLoadGauge.MaxValue = 100D;
            this.gpuLoadGauge.Name = "gpuLoadGauge";
            this.gpuLoadGauge.PercentageMarkColor = System.Drawing.Color.Gainsboro;
            this.gpuLoadGauge.PointerBase = 6;
            this.gpuLoadGauge.PointerLengthPercentage = 1F;
            this.gpuLoadGauge.Size = new System.Drawing.Size(175, 175);
            this.gpuLoadGauge.StartAngle = 225F;
            this.gpuLoadGauge.SweepAngle = 90F;
            this.gpuLoadGauge.TabIndex = 2;
            this.gpuLoadGauge.TextHeightPercentage = 0.7F;
            this.gpuLoadGauge.Value = 50D;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            // 
            // roundedPanel2.ContentsPanel
            // 
            this.roundedPanel2.ContentsPanel.Controls.Add(this.lineGraph);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.sliderValue);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.modernCheckBox3);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.modernCheckBox2);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.modernCheckBox1);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.multilineBorder);
            this.roundedPanel2.ContentsPanel.Controls.Add(this.multilineCheck);
            this.roundedPanel2.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.ContentsPanel.Enabled = true;
            this.roundedPanel2.ContentsPanel.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.ContentsPanel.Margin = new System.Windows.Forms.Padding(16);
            this.roundedPanel2.ContentsPanel.Name = "ContentsPanel";
            this.roundedPanel2.ContentsPanel.Size = new System.Drawing.Size(539, 236);
            this.roundedPanel2.ContentsPanel.TabIndex = 0;
            this.roundedPanel2.ContentsPanel.Visible = true;
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Corners = new bool[] {
        true,
        true,
        true,
        true};
            this.roundedPanel2.Location = new System.Drawing.Point(332, 300);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(539, 236);
            this.roundedPanel2.TabIndex = 1;
            // 
            // lineGraph
            // 
            this.lineGraph.Captions = ((System.Collections.Generic.List<string>)(resources.GetObject("lineGraph.Captions")));
            this.lineGraph.DisplayDots = true;
            this.lineGraph.DisplayLegend = true;
            this.lineGraph.DisplayText = true;
            this.lineGraph.FillBackground = true;
            this.lineGraph.GraphLines = System.Drawing.Color.Gray;
            this.lineGraph.GraphOutline = System.Drawing.Color.Black;
            this.lineGraph.Location = new System.Drawing.Point(6, 44);
            this.lineGraph.MaxDisplay = 50;
            this.lineGraph.Name = "lineGraph";
            this.lineGraph.OutlineBottom = true;
            this.lineGraph.OutlineLeft = true;
            this.lineGraph.PercentageLines = true;
            this.lineGraph.Size = new System.Drawing.Size(502, 150);
            this.lineGraph.TabIndex = 0;
            this.lineGraph.Values = ((System.Collections.Generic.List<System.Collections.Generic.List<float>>)(resources.GetObject("lineGraph.Values")));
            // 
            // sliderValue
            // 
            this.sliderValue.AutoSize = true;
            this.sliderValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.sliderValue.Location = new System.Drawing.Point(388, 211);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Size = new System.Drawing.Size(110, 13);
            this.sliderValue.TabIndex = 12;
            this.sliderValue.Text = "Value: 5000 | 100000";
            // 
            // modernCheckBox3
            // 
            this.modernCheckBox3.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.modernCheckBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.modernCheckBox3.Checked = true;
            this.modernCheckBox3.DisabledColor = System.Drawing.Color.Gray;
            this.modernCheckBox3.Location = new System.Drawing.Point(388, 13);
            this.modernCheckBox3.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.modernCheckBox3.MaximumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox3.MinimumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox3.Name = "modernCheckBox3";
            this.modernCheckBox3.Size = new System.Drawing.Size(80, 25);
            this.modernCheckBox3.TabIndex = 10;
            this.modernCheckBox3.CheckedChanged += new System.EventHandler(this.modernCheckBox3_CheckedChanged);
            // 
            // modernCheckBox2
            // 
            this.modernCheckBox2.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.modernCheckBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.modernCheckBox2.Checked = true;
            this.modernCheckBox2.DisabledColor = System.Drawing.Color.Gray;
            this.modernCheckBox2.Location = new System.Drawing.Point(302, 13);
            this.modernCheckBox2.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.modernCheckBox2.MaximumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox2.MinimumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox2.Name = "modernCheckBox2";
            this.modernCheckBox2.Size = new System.Drawing.Size(80, 25);
            this.modernCheckBox2.TabIndex = 9;
            this.modernCheckBox2.CheckedChanged += new System.EventHandler(this.modernCheckBox2_CheckedChanged);
            // 
            // modernCheckBox1
            // 
            this.modernCheckBox1.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.modernCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.modernCheckBox1.Checked = true;
            this.modernCheckBox1.DisabledColor = System.Drawing.Color.Gray;
            this.modernCheckBox1.Location = new System.Drawing.Point(216, 13);
            this.modernCheckBox1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.modernCheckBox1.MaximumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox1.MinimumSize = new System.Drawing.Size(80, 25);
            this.modernCheckBox1.Name = "modernCheckBox1";
            this.modernCheckBox1.Size = new System.Drawing.Size(80, 25);
            this.modernCheckBox1.TabIndex = 8;
            this.modernCheckBox1.CheckedChanged += new System.EventHandler(this.modernCheckBox1_CheckedChanged);
            // 
            // multilineBorder
            // 
            this.multilineBorder.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.multilineBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.multilineBorder.Checked = true;
            this.multilineBorder.DisabledColor = System.Drawing.Color.Gray;
            this.multilineBorder.Location = new System.Drawing.Point(130, 13);
            this.multilineBorder.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.multilineBorder.MaximumSize = new System.Drawing.Size(80, 25);
            this.multilineBorder.MinimumSize = new System.Drawing.Size(80, 25);
            this.multilineBorder.Name = "multilineBorder";
            this.multilineBorder.Size = new System.Drawing.Size(80, 25);
            this.multilineBorder.TabIndex = 7;
            this.multilineBorder.CheckedChanged += new System.EventHandler(this.multilineBorder_CheckedChanged);
            // 
            // multilineCheck
            // 
            this.multilineCheck.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.multilineCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.multilineCheck.Checked = true;
            this.multilineCheck.DisabledColor = System.Drawing.Color.Gray;
            this.multilineCheck.Location = new System.Drawing.Point(44, 13);
            this.multilineCheck.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.multilineCheck.MaximumSize = new System.Drawing.Size(80, 25);
            this.multilineCheck.MinimumSize = new System.Drawing.Size(80, 25);
            this.multilineCheck.Name = "multilineCheck";
            this.multilineCheck.Size = new System.Drawing.Size(80, 25);
            this.multilineCheck.TabIndex = 6;
            this.multilineCheck.CheckedChanged += new System.EventHandler(this.multilineCheck_CheckedChanged);
            // 
            // cpuCorePanel
            // 
            this.cpuCorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            // 
            // cpuCorePanel.ContentsPanel
            // 
            this.cpuCorePanel.ContentsPanel.Controls.Add(this.label2);
            this.cpuCorePanel.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuCorePanel.ContentsPanel.Enabled = true;
            this.cpuCorePanel.ContentsPanel.Location = new System.Drawing.Point(0, 0);
            this.cpuCorePanel.ContentsPanel.Margin = new System.Windows.Forms.Padding(16);
            this.cpuCorePanel.ContentsPanel.Name = "ContentsPanel";
            this.cpuCorePanel.ContentsPanel.Size = new System.Drawing.Size(262, 236);
            this.cpuCorePanel.ContentsPanel.TabIndex = 0;
            this.cpuCorePanel.ContentsPanel.Visible = true;
            this.cpuCorePanel.CornerRadius = 10;
            this.cpuCorePanel.Corners = new bool[] {
        true,
        true,
        true,
        true};
            this.cpuCorePanel.Location = new System.Drawing.Point(58, 300);
            this.cpuCorePanel.Margin = new System.Windows.Forms.Padding(4);
            this.cpuCorePanel.Name = "cpuCorePanel";
            this.cpuCorePanel.Size = new System.Drawing.Size(262, 236);
            this.cpuCorePanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU Cores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuTotalPanel
            // 
            this.cpuTotalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            // 
            // cpuTotalPanel.ContentsPanel
            // 
            this.cpuTotalPanel.ContentsPanel.Controls.Add(this.cpuLoadCheck);
            this.cpuTotalPanel.ContentsPanel.Controls.Add(this.cpuLoadGauge);
            this.cpuTotalPanel.ContentsPanel.Controls.Add(this.cpuLbl);
            this.cpuTotalPanel.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuTotalPanel.ContentsPanel.Enabled = true;
            this.cpuTotalPanel.ContentsPanel.Location = new System.Drawing.Point(0, 0);
            this.cpuTotalPanel.ContentsPanel.Margin = new System.Windows.Forms.Padding(16);
            this.cpuTotalPanel.ContentsPanel.Name = "ContentsPanel";
            this.cpuTotalPanel.ContentsPanel.Size = new System.Drawing.Size(262, 262);
            this.cpuTotalPanel.ContentsPanel.TabIndex = 0;
            this.cpuTotalPanel.ContentsPanel.Visible = true;
            this.cpuTotalPanel.CornerRadius = 10;
            this.cpuTotalPanel.Corners = new bool[] {
        false,
        false,
        true,
        true};
            this.cpuTotalPanel.Location = new System.Drawing.Point(58, 30);
            this.cpuTotalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.cpuTotalPanel.Name = "cpuTotalPanel";
            this.cpuTotalPanel.Size = new System.Drawing.Size(262, 262);
            this.cpuTotalPanel.TabIndex = 0;
            // 
            // cpuLoadCheck
            // 
            this.cpuLoadCheck.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.cpuLoadCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.cpuLoadCheck.Checked = true;
            this.cpuLoadCheck.DisabledColor = System.Drawing.Color.Gray;
            this.cpuLoadCheck.Location = new System.Drawing.Point(3, 234);
            this.cpuLoadCheck.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.cpuLoadCheck.MaximumSize = new System.Drawing.Size(80, 25);
            this.cpuLoadCheck.MinimumSize = new System.Drawing.Size(80, 25);
            this.cpuLoadCheck.Name = "cpuLoadCheck";
            this.cpuLoadCheck.Size = new System.Drawing.Size(80, 25);
            this.cpuLoadCheck.TabIndex = 5;
            // 
            // cpuLoadGauge
            // 
            this.cpuLoadGauge.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpuLoadGauge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.cpuLoadGauge.BallSize = 20;
            this.cpuLoadGauge.BarBackground = new System.Drawing.Color[] {
        System.Drawing.Color.DimGray};
            this.cpuLoadGauge.BarColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))))};
            this.cpuLoadGauge.BarWidth = 10;
            this.cpuLoadGauge.ColorAngle = 0F;
            this.cpuLoadGauge.ColorAngleForeground = 0F;
            this.cpuLoadGauge.ColorLive = true;
            this.cpuLoadGauge.DisplayMinMax = true;
            this.cpuLoadGauge.DisplayPercentages = true;
            this.cpuLoadGauge.DisplayPointer = true;
            this.cpuLoadGauge.DisplayText = false;
            this.cpuLoadGauge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoadGauge.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cpuLoadGauge.Location = new System.Drawing.Point(44, 64);
            this.cpuLoadGauge.Margin = new System.Windows.Forms.Padding(21);
            this.cpuLoadGauge.MarkLineWidth = 1;
            this.cpuLoadGauge.MaxValue = 100D;
            this.cpuLoadGauge.Name = "cpuLoadGauge";
            this.cpuLoadGauge.PercentageMarkColor = System.Drawing.Color.Firebrick;
            this.cpuLoadGauge.PointerBase = 6;
            this.cpuLoadGauge.PointerLengthPercentage = 0.75F;
            this.cpuLoadGauge.Size = new System.Drawing.Size(175, 175);
            this.cpuLoadGauge.StartAngle = 135F;
            this.cpuLoadGauge.SweepAngle = 270F;
            this.cpuLoadGauge.TabIndex = 4;
            this.cpuLoadGauge.TextHeightPercentage = 0.85F;
            this.cpuLoadGauge.Value = 10D;
            this.cpuLoadGauge.Load += new System.EventHandler(this.cpuLoadGauge_Load);
            // 
            // cpuLbl
            // 
            this.cpuLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cpuLbl.Location = new System.Drawing.Point(0, 13);
            this.cpuLbl.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(259, 17);
            this.cpuLbl.TabIndex = 1;
            this.cpuLbl.Text = "CPU Load";
            this.cpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(883, 635);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.modernSlider1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.cpuCorePanel);
            this.Controls.Add(this.cpuTotalPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.tempPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempIcon)).EndInit();
            this.hddPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hddIcon)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            this.testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testIcon)).EndInit();
            this.roundedPanel3.ContentsPanel.ResumeLayout(false);
            this.roundedPanel3.ContentsPanel.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel1.ContentsPanel.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ContentsPanel.ResumeLayout(false);
            this.roundedPanel2.ContentsPanel.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.cpuCorePanel.ContentsPanel.ResumeLayout(false);
            this.cpuCorePanel.ResumeLayout(false);
            this.cpuTotalPanel.ContentsPanel.ResumeLayout(false);
            this.cpuTotalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CircleLoadingBar.RoundedPanel cpuTotalPanel;
        private CircleLoadingBar.RoundedPanel roundedPanel2;
        private CircleLoadingBar.RoundedPanel cpuCorePanel;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label label2;
        private CircleLoadingBar.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label gpuLbl;
        private CircleLoadingBar.Gauge gpuLoadGauge;
        private CircleLoadingBar.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label1;
        private CircleLoadingBar.VerticalProgressBar memoryLoad;
        private System.Windows.Forms.Label label4;
        private CircleLoadingBar.VerticalProgressBar hddBar;
        private System.Windows.Forms.Label label3;
        private CircleLoadingBar.Gauge cpuLoadGauge;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox MainIcon;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.PictureBox testIcon;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.PictureBox settingsIcon;
        private System.Windows.Forms.Panel hddPanel;
        private System.Windows.Forms.PictureBox hddIcon;
        private System.Windows.Forms.Panel tempPanel;
        private System.Windows.Forms.PictureBox tempIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ModernCheckBox gpuLoadCheck;
        private ModernCheckBox cpuLoadCheck;
        private ModernCheckBox multilineCheck;
        private ModernCheckBox multilineBorder;
        private ModernCheckBox modernCheckBox1;
        private ModernCheckBox modernCheckBox2;
        private ModernCheckBox modernCheckBox3;
        private ModernSlider modernSlider1;
        private System.Windows.Forms.Label sliderValue;
        private MultilevelLineGraph lineGraph;
    }
}

