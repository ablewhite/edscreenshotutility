using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EDScreenshotService
{
    public partial class Service1 : ServiceBase
    {
        public enum CustomCommand
        {
            RemoveBMPAlways = 200,
            RemoveBMPOnly4K,
            RemoveBMPNever,

            PrefFormatJPG,
            PrefFormatPNG,

            ProcessAll
        };

        /// <summary>
        /// Static values protected by access routines
        /// </summary>
        static int _removeBmpSetting = (int)CustomCommand.RemoveBMPAlways;
        static int _prefFormat = (int)CustomCommand.PrefFormatJPG;
        static int _jpgQuality = 80;

        /// <summary>
        /// Access routines for global vars
        /// </summary>
        public static int RemoveBMPSetting
        {
            get
            {
                return _removeBmpSetting;
            }
            set
            {
                _removeBmpSetting = value;
            }
        }

        public static int PreferredFormat
        {
            get
            {
                return _prefFormat;
            }
            set
            {
                _prefFormat = value;
            }
        }

        public static int JPEGQuality
        {
            get
            {
                return _jpgQuality;
            }
            set
            {
                _jpgQuality = value;
            }
        }

        public Service1(string screenshotPath, string removeBMPOption, string preferredFormat, int jpegQuality)
        {
            InitializeComponent();

            // setup logging
            this.AutoLog = true;

            if (Directory.Exists(screenshotPath))
            {
                this.EventLog.WriteEntry(string.Concat("Setting screenshot path to: ", screenshotPath));
                edScreenshotWatcher.Path = screenshotPath;
            }
            else
            {
                this.EventLog.WriteEntry(string.Concat("** Unable to locate path: ", screenshotPath));
            }

            this.EventLog.WriteEntry(string.Concat("Setting remove BMP option to: ", removeBMPOption));

            switch (removeBMPOption)
            {
                case "4konly":
                    Service1.RemoveBMPSetting = (int)CustomCommand.RemoveBMPOnly4K;
                    break;

                case "never":
                    Service1.RemoveBMPSetting = (int)CustomCommand.RemoveBMPNever;
                    break;

                default:
                    Service1.RemoveBMPSetting = (int)CustomCommand.RemoveBMPAlways;
                    break;
            }

            this.EventLog.WriteEntry(string.Concat("Setting preferred format to: ", preferredFormat));

            switch (preferredFormat)
            {
                case "png":
                    Service1.PreferredFormat = (int)CustomCommand.PrefFormatPNG;
                    break;

                default:
                    Service1.PreferredFormat = (int)CustomCommand.PrefFormatJPG;
                    break;
            }

            this.EventLog.WriteEntry(string.Concat("Setting JPEG quality to: ", jpegQuality));
            Service1.JPEGQuality = jpegQuality;
        }

        protected override void OnCustomCommand(int command)
        {

            switch (command) {
                case (int)CustomCommand.RemoveBMPAlways:
                case (int)CustomCommand.RemoveBMPOnly4K:
                case (int)CustomCommand.RemoveBMPNever:
                    _removeBmpSetting = command;
                    this.EventLog.WriteEntry(string.Concat("Switched bitmap remove setting to: ", command));
                    break;

                case (int)CustomCommand.PrefFormatJPG:
                case (int)CustomCommand.PrefFormatPNG:
                    _prefFormat = command;
                    this.EventLog.WriteEntry(string.Concat("Switched preferred format to: ", command));
                    break;

                case (int)CustomCommand.ProcessAll:
                    this.ProcessAllBitmaps();
                    break;
            }

        }

        protected override void OnStart(string[] args)
        {
            this.EventLog.WriteEntry("Starting service");
        }

        protected override void OnStop()
        {
            this.EventLog.WriteEntry("Stopping service");
        }

        public void ProcessAllBitmaps()
        {
            this.EventLog.WriteEntry("processAllBitmaps - starting");
            // TODO
            this.EventLog.WriteEntry("processAllBitmaps - ended");
        }

    }
}
