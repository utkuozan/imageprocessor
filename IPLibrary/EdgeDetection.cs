using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace IPLibrary
{
    public partial class ImageProcessingLibrary
    {
        private double blue = 0.0;
        private double green = 0.0;
        private double red = 0.0;
        private double blueX = 0.0;
        private double greenX = 0.0;
        private double redX = 0.0;
        private double blueY = 0.0;
        private double greenY = 0.0;
        private double redY = 0.0;
        private double blueTotal = 0.0;
        private double greenTotal = 0.0;
        private double redTotal = 0.0;
        private int filterOffset = 1;
        private int calcOffset = 0;
        private int byteOffset = 0;

        public Bitmap DetectEdges(Bitmap bmp, int threshold)
        {
            double[,] filterMatrixX = FilterLibrary.GetFilterMatrix(FilterTypes.Gaussian3);
            double[,] filterMatrixY = FilterLibrary.GetFilterMatrix(FilterTypes.Gaussian3);
            Bitmap pbmp = new Bitmap(bmp);
            BitmapData pbmpData = new BitmapData();
            pbmpData = pbmp.LockBits(new Rectangle(0, 0, pbmp.Width, pbmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
            byte[] pixelbuff = new byte[pbmpData.Stride * pbmpData.Height];
            byte[] resultbuff = new byte[pbmpData.Stride * pbmpData.Height];
            Marshal.Copy(pbmpData.Scan0, pixelbuff, 0, pixelbuff.Length);
            pbmp.UnlockBits(pbmpData);
            for (int offsetY = filterOffset; offsetY < pbmp.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < pbmp.Width - filterOffset; offsetX++)
                {
                    blueX = greenX = redX = 0;
                    blueY = greenY = redY = 0;
                    blueTotal = greenTotal = redTotal = 0.0;
                    byteOffset = offsetY * pbmpData.Stride + offsetX * 4;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * pbmpData.Stride);
                            blueX += (double)(pixelbuff[calcOffset]) * filterMatrixX[filterY + filterOffset, filterX + filterOffset];
                            greenX += (double)(pixelbuff[calcOffset + 1]) * filterMatrixX[filterY + filterOffset, filterX + filterOffset];
                            redX += (double)(pixelbuff[calcOffset + 2]) * filterMatrixX[filterY + filterOffset, filterX + filterOffset];
                            blueY += (double)(pixelbuff[calcOffset]) * filterMatrixY[filterY + filterOffset, filterX + filterOffset];
                            greenY += (double)(pixelbuff[calcOffset + 1]) * filterMatrixY[filterY + filterOffset, filterX + filterOffset];
                            redY += (double)(pixelbuff[calcOffset + 2]) * filterMatrixY[filterY + filterOffset, filterX + filterOffset];
                        }
                    }
                    blueTotal = 0;
                    redTotal = 0;
                    greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    greenTotal = greenTotal > 255 ? 255 : greenTotal < 0 ? 0 : greenTotal;
                    greenTotal = greenTotal < threshold ? 0 : 255;
                    resultbuff[byteOffset] = (byte)(blueTotal);
                    resultbuff[byteOffset + 1] = (byte)(greenTotal);
                    resultbuff[byteOffset + 2] = (byte)(redTotal);
                    resultbuff[byteOffset + 3] = 255;
                }
            }

            Bitmap result = new Bitmap(pbmp.Width, pbmp.Height);
            BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(resultbuff, 0, resultData.Scan0, resultbuff.Length);
            result.UnlockBits(resultData);

            return result;
        }
    }
    public class FilterLibrary
    {
        private static double[,] Laplacian_3
        {
            get
            {
                return new double[,]
                {
                    { -1, -1, -1,  },
                    { -1,  8, -1,  },
                    { -1, -1, -1,  }
                };
            }
        }
        private static double[,] Laplacian_5
        {
            get
            {
                return new double[,]
                {
                    { -1, -1, -1, -1, -1, },
                    { -1, -1, -1, -1, -1, },
                    { -1, -1, 24, -1, -1, },
                    { -1, -1, -1, -1, -1, },
                    { -1, -1, -1, -1, -1  }
                };
            }
        }
        private static double[,] GaussianLaplacian
        {
            get
            {
                return new double[,]
                {
                    {  0,   0, -1,  0,  0 },
                    {  0,  -1, -2, -1,  0 },
                    { -1,  -2, 16, -2, -1 },
                    {  0,  -1, -2, -1,  0 },
                    {  0,   0, -1,  0,  0 }
                };
            }
        }
        private static double[,] Gaussian_3
        {
            get
            {
                return new double[,]
                {
                    { 1, 2, 1, },
                    { 2, 4, 2, },
                    { 1, 2, 1, }
                };
            }
        }
        private static double[,] Gaussian_5
        {
            get
            {
                return new double[,]
                {
                    { 2, 04, 05, 04, 2 },
                    { 4, 09, 12, 09, 4 },
                    { 5, 12, 15, 12, 5 },
                    { 4, 09, 12, 09, 4 },
                    { 2, 04, 05, 04, 2 }
                };
            }
        }

        public static double[,] GetFilterMatrix(FilterTypes type)
        {
            double[,] result = null;
            switch (type)
            {
                case FilterTypes.Laplacian3:
                    result = Laplacian_3;
                    break;
                case FilterTypes.Laplacian5:
                    result = Laplacian_5;
                    break;
                case FilterTypes.Gaussian3:
                    result = Gaussian_3;
                    break;
                case FilterTypes.Gaussian5:
                    result = Gaussian_5;
                    break;
                case FilterTypes.GaussianLaplacian:
                    result = GaussianLaplacian;
                    break;
            }
            return result;
        }
    }
    public enum FilterTypes
    {
        Laplacian3 = 0,
        Laplacian5 = 1,
        Gaussian3 = 2,
        Gaussian5 = 3,
        GaussianLaplacian = 4
    }
}
