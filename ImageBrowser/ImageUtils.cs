using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageBrowser
{
    internal class ImageUtils
    {
        private static readonly string[] ImageExtensions = new[]
        {
            ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".tif", ".tiff"
        };

        public static bool IsImageFile(string path)
        {
            var ext = Path.GetExtension(path);
            if (string.IsNullOrEmpty(ext)) return false;

            return ImageExtensions.Contains(ext.ToLowerInvariant());
        }

        public static bool IsValidImageByHeader(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var img = Image.FromStream(fs, useEmbeddedColorManagement: false, validateImageData: false))
                    {
                        // if this statement is reached the image is valid
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static RotateFlipType GetRotateFlipType(int rotation, bool flipX, bool flipY)
        {
            switch (rotation)
            {
                case 0:
                    if (flipX)
                    {
                        if (flipY) return RotateFlipType.RotateNoneFlipXY;
                        else return RotateFlipType.RotateNoneFlipX;
                    }
                    else
                    {
                        if (flipY) return RotateFlipType.RotateNoneFlipY;
                        else return RotateFlipType.RotateNoneFlipNone;
                    }
                case 90:
                    if (flipX)
                    {
                        if (flipY) return RotateFlipType.Rotate90FlipXY;
                        else return RotateFlipType.Rotate90FlipX;
                    }
                    else
                    {
                        if (flipY) return RotateFlipType.Rotate90FlipY;
                        else return RotateFlipType.Rotate90FlipNone;
                    }
                case 180:
                    if (flipX)
                    {
                        if (flipY) return RotateFlipType.Rotate180FlipXY;
                        else return RotateFlipType.Rotate180FlipX;
                    }
                    else
                    {
                        if (flipY) return RotateFlipType.Rotate180FlipY;
                        else return RotateFlipType.Rotate180FlipNone;
                    }
                case 270:
                    if (flipX)
                    {
                        if (flipY) return RotateFlipType.Rotate270FlipXY;
                        else return RotateFlipType.Rotate270FlipX;
                    }
                    else
                    {
                        if (flipY) return RotateFlipType.Rotate270FlipY;
                        else return RotateFlipType.Rotate270FlipNone;
                    }
                default:
                    break;
            }

            return RotateFlipType.RotateNoneFlipNone;
        }
    }
}
