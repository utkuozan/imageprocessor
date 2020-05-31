using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {
        public Bitmap Sharpen(Bitmap image, int radius)
        {
            Bitmap sharpenImage = new Bitmap(image.Width, image.Height);
            int w = image.Width;
            int h = image.Height;
            double[,] filter = new double[radius, radius];
            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
            filter[1, 1] = 9;
            double factor = 1.0;
            double bias = 0.0;
            Color[,] result = new Color[image.Width, image.Height];

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;
                    for (int filterX = 0; filterX < radius; filterX++)
                    {
                        for (int filterY = 0; filterY < radius; filterY++)
                        {
                            int imageX = (x - radius / 2 + filterX + w) % w;
                            int imageY = (y - radius / 2 + filterY + h) % h;
                            Color imageColor = image.GetPixel(imageX, imageY);
                            red += imageColor.R * filter[filterX, filterY];
                            green += imageColor.G * filter[filterX, filterY];
                            blue += imageColor.B * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }
            for (int i = 0; i < w; ++i)
                for (int j = 0; j < h; ++j)
                    sharpenImage.SetPixel(i, j, result[i, j]);
            return sharpenImage;
        }
    }
}
