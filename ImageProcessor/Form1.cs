using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
        private IPLibrary.ImageProcessingLibrary lib;
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lib = new IPLibrary.ImageProcessingLibrary();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = openFileDialog1.FileName;
            LoadImage();
        }

        private void LoadImage()
        {
            pbOriginal.Image = Image.FromFile(filePath);
        }

        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.ConvertToGrayscale(bmp);
            pbProcessed.Image = pbmp;
        }

        private void btnMedianFilter_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.MedianFilter(bmp, 5);
            pbProcessed.Image = pbmp;
        }

        private void btnGaussian_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.GaussianBlur(5, bmp);
            pbProcessed.Image = pbmp;
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.Sharpen(bmp, 3);
            pbProcessed.Image = pbmp;
        }

        private void brnDetectEdges_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.DetectEdges(bmp, 250);
            pbProcessed.Image = pbmp;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.SetBrightness(bmp, 0.6f);
            pbProcessed.Image = pbmp;
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.SetContrast(bmp, 3.6f);
            pbProcessed.Image = pbmp;
        }

        private void btnGamma_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.SetGamma(bmp, 4.6f);
            pbProcessed.Image = pbmp;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.RotateImage(bmp, 50, InterpolationMode.HighQualityBicubic);
            pbProcessed.Image = pbmp;
        }

        private void btnFlipH_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.Flip(bmp, RotateFlipType.Rotate180FlipY);
            pbProcessed.Image = pbmp;
        }

        private void btnFlipV_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.Flip(bmp, RotateFlipType.Rotate180FlipX);
            pbProcessed.Image = pbmp;
        }

        private void btnResizeH_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.Resize(bmp, 50, 100);
            pbProcessed.Image = pbmp;
        }

        private void btnResizeV_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(filePath);
            Bitmap pbmp = lib.Resize(bmp, 100, 50);
            pbProcessed.Image = pbmp;
        }
    }
}
