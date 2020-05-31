using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {
        public Bitmap Flip(Bitmap bmp, RotateFlipType type)
        {
            bmp.RotateFlip(type);
            return bmp;
        }
    }
}
