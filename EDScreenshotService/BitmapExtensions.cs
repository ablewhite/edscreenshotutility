using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Linq;

namespace EDScreenshotService
{
    public static class BitmapExtensions
    {

        public static void SaveJpeg(this Bitmap img, string filePath, long quality)
        {
            var encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            img.Save(filePath, GetEncoder(ImageFormat.Jpeg), encoderParameters);
        }

        public static void SavePng(this Bitmap img, string filePath)
        {
            //var encoderParameters = new EncoderParameters(1);
            //encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            //img.Save(filePath, GetEncoder(ImageFormat.Png), encoderParameters);
            img.Save(filePath, GetEncoder(ImageFormat.Png), null);
        }

        static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            return codecs.Single(codec => codec.FormatID == format.Guid);
        }

    }

}
