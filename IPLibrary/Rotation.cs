using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {
        public Bitmap RotateImage(Bitmap bmp, float angle, InterpolationMode mode)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);
            Graphics gfx = Graphics.FromImage(result);
            gfx.TranslateTransform((float)result.Width / 2, (float)result.Height / 2);
            gfx.RotateTransform(angle);
            gfx.TranslateTransform(-(float)result.Width / 2, -(float)result.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(bmp, new Point(0, 0));
            gfx.Dispose();
            return result;
        }
    }
}
