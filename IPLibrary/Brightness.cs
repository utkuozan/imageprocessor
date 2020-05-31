using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {
        public Bitmap SetBrightness(Bitmap bmp, float brightness)
        {
            Bitmap result = new Bitmap(bmp);
            float newBrightness = brightness - 1.0f;
            float[][] conversionMatrix =
                {
                new float[] { 1, 0, 0, 0, 0 },
                new float[] { 0, 1, 0, 0, 0 },
                new float[] { 0, 0, 1, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { newBrightness, newBrightness, newBrightness, 0, 1 }
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(conversionMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp, new Rectangle(0, 0, result.Width, result.Height) , 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, imageAttributes);

            return result;
        }
    }
}
