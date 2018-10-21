using System.Collections.Generic;
using System.Drawing;

namespace TestFramework.White
{
    public class FileUtils
    {
        public static bool CompareImages(Image firstImage, Image secondImage)
        {
            var firstBitmap = (Bitmap)firstImage;
            var secondBitmap = (Bitmap)secondImage;
            if (firstBitmap.Size != secondBitmap.Size) return false;
            for (var i = 0; i < firstBitmap.Width; i++)
            {
                for (var j = 0; j < firstBitmap.Height; j++)
                {
                    return firstBitmap.GetPixel(i, j) == secondBitmap.GetPixel(i, j);
                }
            }
            return false;
        }

        public static List<bool> GetHash(Image image)
        {
            var bitmap = (Bitmap)image;
            var lResult = new List<bool>();
            //create new image with 16x16 pixel
            var bmpMin = new Bitmap(bitmap, new Size(16, 16));
            for (var j = 0; j < bmpMin.Height; j++)
            {
                for (var i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }
    }
}
