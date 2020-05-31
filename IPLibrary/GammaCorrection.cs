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
    {
        public Bitmap SetGamma(Bitmap bmp, float gamma)
        {
            Bitmap result = new Bitmap(bmp);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp, new Rectangle(0, 0, result.Width, result.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, imageAttributes);

            return result;
        }
    }
}
