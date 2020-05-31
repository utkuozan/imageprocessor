using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {   // https://docs.rainmeter.net/tips/colormatrix-guide/
        public Bitmap SetContrast(Bitmap bmp, float contrast)
        {
            Bitmap result = new Bitmap(bmp);
            float newContrast = contrast - 1.0f;
            float t = (1.0f - contrast) / 2.0f;
            float[][] conversionMatrix =
                {
                new float[] { newContrast, 0, 0, 0, 0 },
                new float[] { 0, newContrast, 0, 0, 0 },
                new float[] { 0, 0, newContrast, 0, 0 },
                new float[] { 0, 0, 0, newContrast, 0 },
                new float[] { t, t, t, 0, 1 }
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(conversionMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp, new Rectangle(0, 0, result.Width, result.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, imageAttributes);

            return result;
        }
    }
}
