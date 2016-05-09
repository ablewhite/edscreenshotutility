using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
//using System.Timers;
using System.Threading;
//using System.Runtime.InteropServices;

namespace EDScreenshotService
{
    partial class Service1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edScreenshotWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.edScreenshotWatcher)).BeginInit();
            // 
            // edScreenshotWatcher
            // 
            this.edScreenshotWatcher.EnableRaisingEvents = true;
            this.edScreenshotWatcher.Filter = "*.bmp";
            this.edScreenshotWatcher.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite)));
            this.edScreenshotWatcher.Created += new System.IO.FileSystemEventHandler(this.FSWatcherTest_Created);
            // 
            // Service1
            // 
            this.AutoLog = false;
            this.CanPauseAndContinue = true;
            this.ServiceName = "EDScreenshotService";
            ((System.ComponentModel.ISupportInitialize)(this.edScreenshotWatcher)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher edScreenshotWatcher;

        /*
        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSSendMessage(
                    IntPtr hServer,
                    [MarshalAs(UnmanagedType.I4)] int SessionId,
                    String pTitle,
                    [MarshalAs(UnmanagedType.U4)] int TitleLength,
                    String pMessage,
                    [MarshalAs(UnmanagedType.U4)] int MessageLength,
                    [MarshalAs(UnmanagedType.U4)] int Style,
                    [MarshalAs(UnmanagedType.U4)] int Timeout,
                    [MarshalAs(UnmanagedType.U4)] out int pResponse,
                    bool bWait);
        */

        private void WriteToEventLog(string message)
        {
            string sSource = "EDScreenshotService";

			if (!EventLog.SourceExists(sSource)) {
				EventLog.CreateEventSource(sSource, "Application");
            }

			EventLog.WriteEntry(sSource, message);
        }

        /// <summary>
        /// Event occurs when the a File or Directory is created
        /// </summary>
        private void FSWatcherTest_Created(object sender, FileSystemEventArgs e)
        {
            TimerCallback tcb = OnTimedEvent;
            Timer fileConversionTimer = new Timer(tcb, e, 2000, Timeout.Infinite);
        }

        private void OnTimedEvent(Object fileSystemEventArgs)
        {
            FileSystemEventArgs e = (FileSystemEventArgs)fileSystemEventArgs;
            this.ProcessImage(e.FullPath);
        }

        private void ProcessImage(string bmpPath)
        {
            string path;
            string ext = ".jpg"; // default to JPG
            int screenshotWidth = 0;

            if (Service1.PreferredFormat == (int)Service1.CustomCommand.PrefFormatPNG)
            {
                ext = ".png";
            }

            WriteToEventLog(String.Concat("processing: ", bmpPath));

            WriteToEventLog(String.Concat("changing extension to ", ext));

            try
            {
                path = Path.ChangeExtension(bmpPath, ext);
            }
            catch (IOException ex)
            {
                WriteToEventLog(ex.Message);
                WriteToEventLog(ex.StackTrace);
                throw ex;
            }

            try
            {
                WriteToEventLog(string.Concat("opening stream for ", bmpPath));

                using (FileStream fs = new FileStream(bmpPath, FileMode.Open, FileAccess.Read))
                {
                    WriteToEventLog("with fs");

                    using (Bitmap bmpScreenshot = (Bitmap)Image.FromStream(fs))
                    {
                        screenshotWidth = bmpScreenshot.Width;
                        WriteToEventLog("with bmp");

                        if (ext == ".png")
                        {
                            WriteToEventLog("saving PNG");
                            BitmapExtensions.SavePng(bmpScreenshot, path);
                        }
                        else
                        {
                            WriteToEventLog("saving JPG");
                            BitmapExtensions.SaveJpeg(bmpScreenshot, path, Service1.JPEGQuality);
                        }

                    }

                }

                // remove BMP?
                if (Service1.RemoveBMPSetting == (int)Service1.CustomCommand.RemoveBMPAlways ||
                    (Service1.RemoveBMPSetting == (int)Service1.CustomCommand.RemoveBMPOnly4K && screenshotWidth == 7680))
                {
                    WriteToEventLog(string.Concat("Removing file: ", bmpPath));
                    File.Delete(bmpPath);

                    if (File.Exists(bmpPath))
                    {
                        WriteToEventLog(string.Concat("** Unable to remove file: ", bmpPath));
                    }

                }

            }
            catch (FileNotFoundException ex)
            {
                WriteToEventLog("file not found!");
                WriteToEventLog(ex.Message);
                WriteToEventLog(ex.StackTrace);
                throw ex;
            }
            catch (IOException ex)
            {
                WriteToEventLog(ex.Message);
                WriteToEventLog(ex.StackTrace);
                throw ex;
            }

        }

    }

}
