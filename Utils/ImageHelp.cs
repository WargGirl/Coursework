using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Utils
{
    internal class ImageHelp
    {
        public static Bitmap CropAndResizeToBitmap(Image originalImage, Size targetSize)
        {
            if (originalImage == null || targetSize.Width <= 0 || targetSize.Height <= 0)
            {
                return null;
            }

            double targetAspect = (double)targetSize.Width / targetSize.Height;
            double originalAspect = (double)originalImage.Width / originalImage.Height;

            int sourceX = 0, sourceY = 0;
            int sourceWidth = originalImage.Width;
            int sourceHeight = originalImage.Height;

            if (originalAspect > targetAspect)
            {
                sourceHeight = originalImage.Height;
                sourceWidth = (int)(sourceHeight * targetAspect);
                sourceX = (originalImage.Width - sourceWidth) / 2;
            }
            else
            {
                sourceWidth = originalImage.Width;
                sourceHeight = (int)(sourceWidth / targetAspect);
                sourceY = (originalImage.Height - sourceHeight) / 2;
            }

            var cropRect = new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight);

            using Bitmap cropped = ((Bitmap)originalImage).Clone(cropRect, originalImage.PixelFormat);

            Bitmap finalImg = new Bitmap(targetSize.Width, targetSize.Height);
            using (Graphics g = Graphics.FromImage(finalImg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawImage(cropped, 0, 0, targetSize.Width, targetSize.Height);
            }

            return finalImg;
        }

        public static string ImageToBase64(Image image, ImageFormat format)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String)) return null;
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return new Bitmap(ms);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Base64ToImage Format Error: {ex.Message}");
                return null;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Base64ToImage Argument Error: {ex.Message}");
                return null;
            }
        }
    }
}
