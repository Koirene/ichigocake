using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;

namespace ichigocake.admin.Helpers
{
    public class ImageHelper
    {
        public static void SaveImage(Stream streamImage, string imageFullPath, double maxWidth, double maxHeight, bool createThumbnail)
        {
            var _bitmap = createThumbnail ? CreateThumbnailImage(streamImage, maxWidth, maxHeight) : ResizeImage(streamImage, maxWidth, maxHeight);
            var thumb = _bitmap.GetThumbnailImage(300, 300, null, IntPtr.Zero);

            if (createThumbnail)
                thumb.Save(imageFullPath);
            else
                _bitmap.Save(imageFullPath);

            _bitmap.Dispose();
            thumb.Dispose();
        }

        public static void SaveImageWithExactSize(Stream streamImage, string imageFullPath, double imageWidth, double imageHeight, bool createThumbnail)
        {
            var _bitmap = ResizeImageExact(streamImage, imageWidth, imageHeight);

            _bitmap.Save(imageFullPath);

            _bitmap.Dispose();
        }

        public static Bitmap ResizeImage(Stream streamImage, double maxWidth, double maxHeight)
        {
            Bitmap originalImage = new Bitmap(streamImage);

            double _maxWidth = maxWidth;
            double _maxHeight = maxHeight;

            double originalImageWidth = Convert.ToDouble(originalImage.Width);
            double originalImageHeight = Convert.ToDouble(originalImage.Height);

            if (originalImageHeight.Equals(maxHeight) && originalImageWidth.Equals(originalImageWidth))
                return originalImage;

            double scaleFactor = 0;

            //double aspectRatio = originalImageWidth / originalImageHeight;
            //double boxRatio = _maxWidth / _maxHeight;

            //if (boxRatio > aspectRatio) //Use height, since that is the most restrictive dimension of box.
            //    scaleFactor = _maxHeight / originalImageHeight;
            //else
            //    scaleFactor = _maxWidth / originalImageWidth;

            if (originalImageHeight > _maxHeight)
                scaleFactor = _maxHeight / originalImageHeight;
            else if (originalImageWidth > _maxWidth)
                scaleFactor = _maxWidth / originalImageWidth;
            else
                scaleFactor = 1;

            double newWidth = originalImageWidth * scaleFactor;
            double newHeight = originalImageHeight * scaleFactor;

            Bitmap newImage = new Bitmap(originalImage, Convert.ToInt32(Math.Floor(newWidth)), Convert.ToInt32(Math.Floor(newHeight)));

            Graphics g = Graphics.FromImage(newImage);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height);

            originalImage.Dispose();

            return newImage;
        }

        public static Bitmap ResizeImageExact(Stream streamImage, double imageWidth, double imageHeight)
        {
            Bitmap originalImage = new Bitmap(streamImage);

            Bitmap newImage = new Bitmap(originalImage, Convert.ToInt32(Math.Floor(imageWidth)), Convert.ToInt32(Math.Floor(imageHeight)));

            Graphics g = Graphics.FromImage(newImage);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height);

            originalImage.Dispose();

            return newImage;
        }

        public static Bitmap CreateThumbnailImage(Stream streamImage, double width, double height)
        {
            Bitmap originalImage = new Bitmap(streamImage);

            double originalImageWidth = Convert.ToDouble(originalImage.Width);
            double originalImageHeight = Convert.ToDouble(originalImage.Height);

            var sx = originalImageWidth / width;
            var sy = originalImageHeight / height;

            var s = sx > sy ? sy : sx;

            var midX = Math.Floor(originalImageWidth / 2);
            var midY = Math.Floor(originalImageHeight / 2);

            var x = Convert.ToInt32(Math.Floor(midX - (s / 2 * width)));
            var y = Convert.ToInt32(Math.Floor(midY - (s / 2 * height)));

            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }

            Rectangle bounds = new Rectangle(x, y, Convert.ToInt32(s * width), Convert.ToInt32(s * height));

            var thumbImage = originalImage.Clone(bounds, originalImage.PixelFormat);

            return thumbImage;
        }

        public static Bitmap CreateThumbnailImage(string imagePath, double width, double height)
        {
            Bitmap originalImage = (Bitmap)Bitmap.FromFile(imagePath);

            double originalImageWidth = Convert.ToDouble(originalImage.Width);
            double originalImageHeight = Convert.ToDouble(originalImage.Height);

            var sx = originalImageWidth / width;
            var sy = originalImageHeight / height;

            var s = sx > sy ? sy : sx;

            var midX = Math.Floor(originalImageWidth / 2);
            var midY = Math.Floor(originalImageHeight / 2);

            var x = Convert.ToInt32(Math.Floor(midX - (s / 2 * width)));
            var y = Convert.ToInt32(Math.Floor(midY - (s / 2 * height)));

            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }

            Rectangle bounds = new Rectangle(x, y, Convert.ToInt32(s * width), Convert.ToInt32(s * height));

            var thumbImage = originalImage.Clone(bounds, originalImage.PixelFormat);

            return thumbImage;
        }

        public static void MoveImage(string from, string to)
        {
            if (File.Exists(from))
            {
                System.IO.File.Move(from, to);
            }
            else
            {
                throw new FileNotFoundException(from);
            }
        }

        public static void DeleteImage(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}