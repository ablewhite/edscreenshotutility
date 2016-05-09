namespace EDScreenshotUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtScreenshotFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.rbJPG = new System.Windows.Forms.RadioButton();
            this.rbPNG = new System.Windows.Forms.RadioButton();
            this.lblQuality = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblSelectedQuality = new System.Windows.Forms.Label();
            this.linkAttribution = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbInstallationStatus = new System.Windows.Forms.PictureBox();
            this.gbInstallationStatus = new System.Windows.Forms.GroupBox();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblInstallationStatus = new System.Windows.Forms.Label();
            this.gbRunningStatus = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRunningStatus = new System.Windows.Forms.Label();
            this.pbRunningStatus = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.rbHighResOnly = new System.Windows.Forms.RadioButton();
            this.rbAlways = new System.Windows.Forms.RadioButton();
            this.lblBitmap = new System.Windows.Forms.Label();
            this.rbNever = new System.Windows.Forms.RadioButton();
            this.panelBitmap = new System.Windows.Forms.Panel();
            this.btnProcessAll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDonate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstallationStatus)).BeginInit();
            this.gbInstallationStatus.SuspendLayout();
            this.gbRunningStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunningStatus)).BeginInit();
            this.panelBitmap.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Double-click this icon to configure your preferences";
            this.notifyIcon1.BalloonTipTitle = "Elite:Dangerous Screenshot Utility";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Elite:Dangerous screenshot utility";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(12, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(98, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "&Screenshot folder";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Please select the folder where Elite:Dangerous screenshots are stored:";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // txtScreenshotFolder
            // 
            this.txtScreenshotFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScreenshotFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreenshotFolder.Location = new System.Drawing.Point(15, 25);
            this.txtScreenshotFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScreenshotFolder.Name = "txtScreenshotFolder";
            this.txtScreenshotFolder.ReadOnly = true;
            this.txtScreenshotFolder.Size = new System.Drawing.Size(407, 22);
            this.txtScreenshotFolder.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtScreenshotFolder, "Changes to the screenshot folder will take effect next time the service is reinst" +
        "alled");
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(347, 55);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.Location = new System.Drawing.Point(12, 141);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(128, 13);
            this.lblFormat.TabIndex = 20;
            this.lblFormat.Text = "Preferred image format";
            // 
            // rbJPG
            // 
            this.rbJPG.AutoSize = true;
            this.rbJPG.Checked = true;
            this.rbJPG.Location = new System.Drawing.Point(15, 161);
            this.rbJPG.Name = "rbJPG";
            this.rbJPG.Size = new System.Drawing.Size(154, 17);
            this.rbJPG.TabIndex = 21;
            this.rbJPG.TabStop = true;
            this.rbJPG.Text = ".&JPG (better compression)";
            this.rbJPG.UseVisualStyleBackColor = true;
            this.rbJPG.CheckedChanged += new System.EventHandler(this.rbJPG_CheckedChanged);
            // 
            // rbPNG
            // 
            this.rbPNG.AutoSize = true;
            this.rbPNG.Location = new System.Drawing.Point(175, 161);
            this.rbPNG.Name = "rbPNG";
            this.rbPNG.Size = new System.Drawing.Size(128, 17);
            this.rbPNG.TabIndex = 22;
            this.rbPNG.Text = ".P&NG (better quality)";
            this.rbPNG.UseVisualStyleBackColor = true;
            this.rbPNG.CheckedChanged += new System.EventHandler(this.rbPNG_CheckedChanged);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(12, 189);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(66, 13);
            this.lblQuality.TabIndex = 30;
            this.lblQuality.Text = "JPG &quality";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tbQuality
            // 
            this.tbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuality.Location = new System.Drawing.Point(53, 205);
            this.tbQuality.Maximum = 100;
            this.tbQuality.Minimum = 10;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(328, 45);
            this.tbQuality.TabIndex = 32;
            this.tbQuality.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.tbQuality, "Changes to JPEG compression quality will take effect next time the service is rei" +
        "nstalled");
            this.tbQuality.Value = 10;
            this.tbQuality.ValueChanged += new System.EventHandler(this.tbQuality_ValueChanged);
            // 
            // lbl10
            // 
            this.lbl10.Location = new System.Drawing.Point(12, 205);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(35, 17);
            this.lbl10.TabIndex = 31;
            this.lbl10.Text = "10%";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl100
            // 
            this.lbl100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl100.Location = new System.Drawing.Point(387, 205);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(35, 17);
            this.lbl100.TabIndex = 33;
            this.lbl100.Text = "100%";
            this.lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedQuality
            // 
            this.lblSelectedQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedQuality.Location = new System.Drawing.Point(65, 239);
            this.lblSelectedQuality.Name = "lblSelectedQuality";
            this.lblSelectedQuality.Size = new System.Drawing.Size(305, 13);
            this.lblSelectedQuality.TabIndex = 34;
            this.lblSelectedQuality.Text = "-";
            this.lblSelectedQuality.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkAttribution
            // 
            this.linkAttribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkAttribution.AutoSize = true;
            this.linkAttribution.Location = new System.Drawing.Point(9, 544);
            this.linkAttribution.Name = "linkAttribution";
            this.linkAttribution.Size = new System.Drawing.Size(145, 13);
            this.linkAttribution.TabIndex = 900;
            this.linkAttribution.TabStop = true;
            this.linkAttribution.Text = "Icons by Marc Grützmacher";
            this.linkAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAttribution_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "noun_160945_cc.png");
            this.imageList1.Images.SetKeyName(1, "noun_160932_cc.png");
            this.imageList1.Images.SetKeyName(2, "noun_160931_cc.png");
            this.imageList1.Images.SetKeyName(3, "noun_160936_cc.png");
            this.imageList1.Images.SetKeyName(4, "noun_160939_cc.png");
            this.imageList1.Images.SetKeyName(5, "noun_160934_cc.png");
            this.imageList1.Images.SetKeyName(6, "noun_160963_cc.png");
            this.imageList1.Images.SetKeyName(7, "lenslok48.jpg");
            // 
            // pbInstallationStatus
            // 
            this.pbInstallationStatus.Location = new System.Drawing.Point(14, 21);
            this.pbInstallationStatus.Name = "pbInstallationStatus";
            this.pbInstallationStatus.Size = new System.Drawing.Size(48, 48);
            this.pbInstallationStatus.TabIndex = 13;
            this.pbInstallationStatus.TabStop = false;
            // 
            // gbInstallationStatus
            // 
            this.gbInstallationStatus.Controls.Add(this.btnUninstall);
            this.gbInstallationStatus.Controls.Add(this.btnInstall);
            this.gbInstallationStatus.Controls.Add(this.lblInstallationStatus);
            this.gbInstallationStatus.Controls.Add(this.pbInstallationStatus);
            this.gbInstallationStatus.Location = new System.Drawing.Point(12, 264);
            this.gbInstallationStatus.Name = "gbInstallationStatus";
            this.gbInstallationStatus.Size = new System.Drawing.Size(410, 116);
            this.gbInstallationStatus.TabIndex = 40;
            this.gbInstallationStatus.TabStop = false;
            this.gbInstallationStatus.Text = "Service installation status";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.Location = new System.Drawing.Point(282, 83);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(118, 23);
            this.btnUninstall.TabIndex = 16;
            this.btnUninstall.Text = "&Uninstall service";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Location = new System.Drawing.Point(158, 83);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(118, 23);
            this.btnInstall.TabIndex = 15;
            this.btnInstall.Text = "&Install service";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblInstallationStatus
            // 
            this.lblInstallationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstallationStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallationStatus.Location = new System.Drawing.Point(68, 21);
            this.lblInstallationStatus.Name = "lblInstallationStatus";
            this.lblInstallationStatus.Size = new System.Drawing.Size(336, 48);
            this.lblInstallationStatus.TabIndex = 14;
            this.lblInstallationStatus.Text = "-";
            this.lblInstallationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbRunningStatus
            // 
            this.gbRunningStatus.Controls.Add(this.btnRun);
            this.gbRunningStatus.Controls.Add(this.btnPause);
            this.gbRunningStatus.Controls.Add(this.btnStop);
            this.gbRunningStatus.Controls.Add(this.lblRunningStatus);
            this.gbRunningStatus.Controls.Add(this.pbRunningStatus);
            this.gbRunningStatus.Location = new System.Drawing.Point(12, 386);
            this.gbRunningStatus.Name = "gbRunningStatus";
            this.gbRunningStatus.Size = new System.Drawing.Size(410, 116);
            this.gbRunningStatus.TabIndex = 50;
            this.gbRunningStatus.TabStop = false;
            this.gbRunningStatus.Text = "Service running status";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(163, 83);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 18;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(244, 83);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 19;
            this.btnPause.Text = "Paus&e";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(325, 83);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRunningStatus
            // 
            this.lblRunningStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRunningStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningStatus.Location = new System.Drawing.Point(68, 21);
            this.lblRunningStatus.Name = "lblRunningStatus";
            this.lblRunningStatus.Size = new System.Drawing.Size(336, 48);
            this.lblRunningStatus.TabIndex = 14;
            this.lblRunningStatus.Text = "-";
            this.lblRunningStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbRunningStatus
            // 
            this.pbRunningStatus.Location = new System.Drawing.Point(14, 21);
            this.pbRunningStatus.Name = "pbRunningStatus";
            this.pbRunningStatus.Size = new System.Drawing.Size(48, 48);
            this.pbRunningStatus.TabIndex = 13;
            this.pbRunningStatus.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(266, 55);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "&View...";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // rbHighResOnly
            // 
            this.rbHighResOnly.Location = new System.Drawing.Point(131, 27);
            this.rbHighResOnly.Name = "rbHighResOnly";
            this.rbHighResOnly.Size = new System.Drawing.Size(110, 17);
            this.rbHighResOnly.TabIndex = 20;
            this.rbHighResOnly.Text = "&4K bitmaps only";
            this.rbHighResOnly.UseVisualStyleBackColor = true;
            this.rbHighResOnly.CheckedChanged += new System.EventHandler(this.rbHighResOnly_CheckedChanged);
            // 
            // rbAlways
            // 
            this.rbAlways.Checked = true;
            this.rbAlways.Location = new System.Drawing.Point(15, 27);
            this.rbAlways.Name = "rbAlways";
            this.rbAlways.Size = new System.Drawing.Size(110, 17);
            this.rbAlways.TabIndex = 19;
            this.rbAlways.TabStop = true;
            this.rbAlways.Text = "&Always";
            this.rbAlways.UseVisualStyleBackColor = true;
            this.rbAlways.CheckedChanged += new System.EventHandler(this.rbAlways_CheckedChanged);
            // 
            // lblBitmap
            // 
            this.lblBitmap.AutoSize = true;
            this.lblBitmap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitmap.Location = new System.Drawing.Point(12, 7);
            this.lblBitmap.Name = "lblBitmap";
            this.lblBitmap.Size = new System.Drawing.Size(134, 13);
            this.lblBitmap.TabIndex = 18;
            this.lblBitmap.Text = "Remove bitmap images?";
            // 
            // rbNever
            // 
            this.rbNever.Location = new System.Drawing.Point(247, 27);
            this.rbNever.Name = "rbNever";
            this.rbNever.Size = new System.Drawing.Size(110, 17);
            this.rbNever.TabIndex = 21;
            this.rbNever.Text = "N&ever";
            this.rbNever.UseVisualStyleBackColor = true;
            this.rbNever.CheckedChanged += new System.EventHandler(this.rbNever_CheckedChanged);
            // 
            // panelBitmap
            // 
            this.panelBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBitmap.Controls.Add(this.lblBitmap);
            this.panelBitmap.Controls.Add(this.rbNever);
            this.panelBitmap.Controls.Add(this.rbAlways);
            this.panelBitmap.Controls.Add(this.rbHighResOnly);
            this.panelBitmap.Location = new System.Drawing.Point(0, 84);
            this.panelBitmap.Name = "panelBitmap";
            this.panelBitmap.Size = new System.Drawing.Size(434, 50);
            this.panelBitmap.TabIndex = 10;
            // 
            // btnProcessAll
            // 
            this.btnProcessAll.Location = new System.Drawing.Point(175, 509);
            this.btnProcessAll.Name = "btnProcessAll";
            this.btnProcessAll.Size = new System.Drawing.Size(237, 23);
            this.btnProcessAll.TabIndex = 901;
            this.btnProcessAll.Text = "&Process all existing bitmap images";
            this.btnProcessAll.UseVisualStyleBackColor = true;
            this.btnProcessAll.Visible = false;
            this.btnProcessAll.Click += new System.EventHandler(this.btnProcessAll_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Please note";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ShowAlways = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Right on, CMDR!";
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.ImageIndex = 7;
            this.btnDonate.ImageList = this.imageList1;
            this.btnDonate.Location = new System.Drawing.Point(364, 510);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(48, 48);
            this.btnDonate.TabIndex = 903;
            this.toolTip2.SetToolTip(this.btnDonate, "Helpful?  Buy me a Lavian brandy ;)");
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 566);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnProcessAll);
            this.Controls.Add(this.panelBitmap);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbRunningStatus);
            this.Controls.Add(this.gbInstallationStatus);
            this.Controls.Add(this.linkAttribution);
            this.Controls.Add(this.lblSelectedQuality);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.tbQuality);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.rbPNG);
            this.Controls.Add(this.rbJPG);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtScreenshotFolder);
            this.Controls.Add(this.lblFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Elite:Dangerous Screenshot Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstallationStatus)).EndInit();
            this.gbInstallationStatus.ResumeLayout(false);
            this.gbRunningStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRunningStatus)).EndInit();
            this.panelBitmap.ResumeLayout(false);
            this.panelBitmap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtScreenshotFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.RadioButton rbJPG;
        private System.Windows.Forms.RadioButton rbPNG;
        private System.Windows.Forms.Label lblQuality;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TrackBar tbQuality;
        private System.Windows.Forms.Label lblSelectedQuality;
        private System.Windows.Forms.LinkLabel linkAttribution;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbInstallationStatus;
        private System.Windows.Forms.PictureBox pbInstallationStatus;
        private System.Windows.Forms.Label lblInstallationStatus;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.GroupBox gbRunningStatus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblRunningStatus;
        private System.Windows.Forms.PictureBox pbRunningStatus;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RadioButton rbNever;
        private System.Windows.Forms.RadioButton rbHighResOnly;
        private System.Windows.Forms.RadioButton rbAlways;
        private System.Windows.Forms.Label lblBitmap;
        private System.Windows.Forms.Panel panelBitmap;
        private System.Windows.Forms.Button btnProcessAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnDonate;
    }
}

