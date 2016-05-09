using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EDScreenshotService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var screenshotPath = ConfigurationManager.AppSettings["EDScreenshotFolder"];
            string removeBMPOption = "always";
            string preferredFormat = "jpg";
            int jpegQuality;

            if (!Int32.TryParse(ConfigurationManager.AppSettings["JpegQuality"], out jpegQuality))
            {
                jpegQuality = 80;
            }

            // args[0] - screenshot folder
            // args[1] - remove BMP option
            // args[2] - preferred format
            // args[3] - JPEG quality
            if (args.Length > 0)
            {
                screenshotPath = args[0];

                // strip quotes if found
                if (screenshotPath.Length > 2 && screenshotPath[0] == '"' && screenshotPath[screenshotPath.Length - 1] == '"')
                {
                    screenshotPath = screenshotPath.Substring(1, screenshotPath.Length - 2);
                }

                // check for remove BMP option
                if (args.Length > 1)
                {
                    removeBMPOption = args[1].ToLower();
                }

                // check for preferred format option
                if (args.Length > 2)
                {
                    preferredFormat = args[2].ToLower();
                }

                // check for JPEG quality arg
                if (args.Length > 3)
                {

                    if (!Int32.TryParse(args[3], out jpegQuality))
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

                }

            }

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1(screenshotPath, removeBMPOption, preferredFormat, jpegQuality) 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
