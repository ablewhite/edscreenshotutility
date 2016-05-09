using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EDScreenshotUI
{
    public partial class FormMain : Form
    {
        enum EDIcon
        {
            NotInstalled = 0,
            Installed,
            Paused,
            Running,
            Stopped,
            Search,
            Settings
        }

        public enum CustomCommand
        {
            RemoveBMPAlways = 200,
            RemoveBMPOnly4K,
            RemoveBMPNever,

            PrefFormatJPG,
            PrefFormatPNG,

            ProcessAll
        };

        bool showTipOnMinimize = true;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            // check: service EXE available in this folder?
            var installFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var pathToService = Path.Combine(installFolder, "EDScreenshotService.exe");

            if (!File.Exists(pathToService))
            {
                MessageBox.Show(string.Concat("Please ensure EDScreenshotService.exe is copied to:\r\n", installFolder),
                    "Service not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            string screenshotFolder = ConfigurationManager.AppSettings["EDScreenshotFolder"];

            if (!Directory.Exists(screenshotFolder))
            {
                //C:\Users\[USER]\Pictures\Frontier Developments\Elite Dangerous\
                string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                screenshotFolder = Path.Combine(userFolder, "Pictures\\Frontier Developments\\Elite Dangerous");
            }

            string strJpegQuality = ConfigurationManager.AppSettings["JpegQuality"];
            int jpegQuality;

            if (!Int32.TryParse(strJpegQuality, out jpegQuality))
            {
                jpegQuality = 80;
            }
            
            if (jpegQuality < 10)
            {
                jpegQuality = 10;
            }

            if (jpegQuality > 100)
            {
                jpegQuality = 100;
            }

            txtScreenshotFolder.Text = screenshotFolder;
            folderBrowserDialog1.SelectedPath = screenshotFolder;
            tbQuality.Value = jpegQuality;

            string removeBMPOption = ConfigurationManager.AppSettings["RemoveBMP"];

            switch (removeBMPOption.ToLower()) 
            {
                case "4konly":
                    rbHighResOnly.Checked = true;
                    break;

                case "never":
                    rbNever.Checked = true;
                    break;

                default:
                    rbAlways.Checked = true;
                    break;
            }

            string preferredFormat = ConfigurationManager.AppSettings["PreferredFormat"];

            switch (preferredFormat.ToLower())
            {
                case "png":
                    rbPNG.Checked = true;
                    break;

                default:
                    rbJPG.Checked = true;
                    break;
            }

            updateServiceStatus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtScreenshotFolder.Text = folderBrowserDialog1.SelectedPath;
                updateConfig("EDScreenshotFolder", folderBrowserDialog1.SelectedPath);
            }

        }

        private void updateConfig(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void tbQuality_ValueChanged(object sender, EventArgs e)
        {
            lblSelectedQuality.Text = string.Format("{0}% quality", tbQuality.Value);
            updateConfig("JpegQuality", tbQuality.Value.ToString());
        }

        private void toggleJpegControls(bool active)
        {
            lblQuality.Enabled = active;
            lbl10.Enabled = active;
            lbl100.Enabled = active;
            lblSelectedQuality.Enabled = active;
            tbQuality.Enabled = active;
        }

        private void rbJPG_CheckedChanged(object sender, EventArgs e)
        {
            toggleJpegControls(true);
            var service = getService();

            if (service != null)
            {
                service.ExecuteCommand((int)CustomCommand.PrefFormatJPG);
            }

            updateConfig("PreferredFormat", "JPG");
        }

        private void rbPNG_CheckedChanged(object sender, EventArgs e)
        {
            toggleJpegControls(false);
            var service = getService();

            if (service != null)
            {
                service.ExecuteCommand((int)CustomCommand.PrefFormatPNG);
            }

            updateConfig("PreferredFormat", "PNG");
        }

        private void linkAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://thenounproject.com/whoismarc/");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/lenslok");
        }

        private void updateServiceStatus()
        {
            // check service exists
            ServiceController screenshotService = getService();

            if (screenshotService == null)
            {
                pbInstallationStatus.Image = imageList1.Images[(int)EDIcon.NotInstalled];
                lblInstallationStatus.Text = "Not installed";
                btnInstall.Enabled = true;
                btnUninstall.Enabled = false;

                gbRunningStatus.Visible = false;
                pbRunningStatus.Image = imageList1.Images[(int)EDIcon.Stopped];
                lblRunningStatus.Text = "-";
            }
            else
            {
                pbInstallationStatus.Image = imageList1.Images[(int)EDIcon.Installed];
                lblInstallationStatus.Text = "Installed";
                btnInstall.Enabled = false;
                btnUninstall.Enabled = true;

                gbRunningStatus.Visible = true;

                btnRun.Enabled = false;
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                btnProcessAll.Enabled = false;

                switch (screenshotService.Status)
                {
                    case ServiceControllerStatus.Running:
                        pbRunningStatus.Image = imageList1.Images[(int)EDIcon.Running];
                        lblRunningStatus.Text = "Running";
                        btnPause.Enabled = true;
                        btnStop.Enabled = true;
                        btnProcessAll.Enabled = true;
                        break;

                    case ServiceControllerStatus.Stopped:
                        pbRunningStatus.Image = imageList1.Images[(int)EDIcon.Stopped];
                        lblRunningStatus.Text = "Stopped";
                        btnRun.Enabled = true;
                        break;

                    case ServiceControllerStatus.Paused:
                        pbRunningStatus.Image = imageList1.Images[(int)EDIcon.Paused];
                        lblRunningStatus.Text = "Paused";
                        btnPause.Enabled = true;
                        break;

                    default:
                        break;
                }

            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Process.Start(txtScreenshotFolder.Text);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            // install service
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                var pathToService = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "EDScreenshotService.exe");

                var removeBMPOption = "always";

                if (rbHighResOnly.Checked)
                {
                    removeBMPOption = "4konly";
                }

                if (rbNever.Checked)
                {
                    removeBMPOption = "never";
                }

                var preferredFormat = "jpg";

                if (rbPNG.Checked)
                {
                    preferredFormat = "png";
                }

                ServiceUtilities.InstallAndStart("EDScreenshotService",
                                                 "Elite:Dangerous screenshot service",
                                                 string.Concat(pathToService,                   // service EXE
                                                    " \"", txtScreenshotFolder.Text, "\" ",     // screenshot folder to watch for BMPs
                                                    removeBMPOption, " ",                       // always / 4k only / never
                                                    preferredFormat, " ",                       // JPG / PNG
                                                    tbQuality.Value));                          // JPG quality
            }
            finally
            {
                updateServiceStatus();
                Cursor.Current = Cursors.Default;
                this.Enabled = true;
            }

        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            // uninstall service
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                ServiceUtilities.Uninstall("EDScreenshotService");
            }
            finally
            {
                updateServiceStatus();
                Cursor.Current = Cursors.Default;
                this.Enabled = true;
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // run service
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                ServiceUtilities.StartService("EDScreenshotService");
            }
            finally
            {
                updateServiceStatus();
                Cursor.Current = Cursors.Default;
                this.Enabled = true;
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // toggle (pause / continue) service
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                ServiceUtilities.ToggleService("EDScreenshotService");
            }
            finally
            {
                updateServiceStatus();
                Cursor.Current = Cursors.Default;

                ServiceController screenshotService = getService();

                if (screenshotService != null) {

                    switch (screenshotService.Status)
                    {
                        case ServiceControllerStatus.Paused:
                            btnPause.Text = "Unpaus&e";
                            break;

                        default:
                            btnPause.Text = "Paus&e";
                            break;
                    }

                }

                this.Enabled = true;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // stop service
            try
            {
                this.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                ServiceUtilities.StopService("EDScreenshotService");
            }
            finally
            {
                updateServiceStatus();
                Cursor.Current = Cursors.Default;
                this.Enabled = true;
            }

        }

        private void btnProcessAll_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private ServiceController getService()
        {
            return ServiceUtilities.GetService(serviceController1, "EDScreenshotService");
        }

        private void rbAlways_CheckedChanged(object sender, EventArgs e)
        {
            var service = getService();

            if (service != null)
            {
                service.ExecuteCommand((int)CustomCommand.RemoveBMPAlways);
            }

            updateConfig("RemoveBMP", "Always");
        }

        private void rbHighResOnly_CheckedChanged(object sender, EventArgs e)
        {
            var service = getService();

            if (service != null)
            {
                service.ExecuteCommand((int)CustomCommand.RemoveBMPOnly4K);
            }

            updateConfig("RemoveBMP", "4KOnly");
        }

        private void rbNever_CheckedChanged(object sender, EventArgs e)
        {
            var service = getService();

            if (service != null)
            {
                service.ExecuteCommand((int)CustomCommand.RemoveBMPNever);
            }

            updateConfig("RemoveBMP", "Never");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("This will close the screenshot service (images will not be converted). " +
                                        "To temporarily hide this window and continue converting images, use the minimize button.\r\n\r\n" +
                                        "Are you sure you wish to close this window?",
                                     "Close E:D screenshot service",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }

            }
        
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            //notifyIcon1.Visible = false;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;

                if (showTipOnMinimize)
                {
                    showTipOnMinimize = false;
                    notifyIcon1.ShowBalloonTip(3000);
                }

                this.ShowInTaskbar = false;
            }

        }

    }
}
