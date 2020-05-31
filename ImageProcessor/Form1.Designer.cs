namespace ImageProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbProcessed = new System.Windows.Forms.PictureBox();
            this.btnGreyScale = new System.Windows.Forms.Button();
            this.btnMedianFilter = new System.Windows.Forms.Button();
            this.btnGaussian = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.brnDetectEdges = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnGamma = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnFlipH = new System.Windows.Forms.Button();
            this.btnFlipV = new System.Windows.Forms.Button();
            this.btnResizeH = new System.Windows.Forms.Button();
            this.btnResizeV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbOriginal.Location = new System.Drawing.Point(13, 42);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(409, 442);
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // pbProcessed
            // 
            this.pbProcessed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbProcessed.Location = new System.Drawing.Point(428, 42);
            this.pbProcessed.Name = "pbProcessed";
            this.pbProcessed.Size = new System.Drawing.Size(409, 442);
            this.pbProcessed.TabIndex = 2;
            this.pbProcessed.TabStop = false;
            // 
            // btnGreyScale
            // 
            this.btnGreyScale.Location = new System.Drawing.Point(13, 492);
            this.btnGreyScale.Name = "btnGreyScale";
            this.btnGreyScale.Size = new System.Drawing.Size(139, 23);
            this.btnGreyScale.TabIndex = 3;
            this.btnGreyScale.Text = "Convert to Greyscale";
            this.btnGreyScale.UseVisualStyleBackColor = true;
            this.btnGreyScale.Click += new System.EventHandler(this.btnGreyScale_Click);
            // 
            // btnMedianFilter
            // 
            this.btnMedianFilter.Location = new System.Drawing.Point(169, 492);
            this.btnMedianFilter.Name = "btnMedianFilter";
            this.btnMedianFilter.Size = new System.Drawing.Size(139, 23);
            this.btnMedianFilter.TabIndex = 4;
            this.btnMedianFilter.Text = "Apply Media filter";
            this.btnMedianFilter.UseVisualStyleBackColor = true;
            this.btnMedianFilter.Click += new System.EventHandler(this.btnMedianFilter_Click);
            // 
            // btnGaussian
            // 
            this.btnGaussian.Location = new System.Drawing.Point(169, 521);
            this.btnGaussian.Name = "btnGaussian";
            this.btnGaussian.Size = new System.Drawing.Size(139, 23);
            this.btnGaussian.TabIndex = 5;
            this.btnGaussian.Text = "Apply Gaussian blur";
            this.btnGaussian.UseVisualStyleBackColor = true;
            this.btnGaussian.Click += new System.EventHandler(this.btnGaussian_Click);
            // 
            // btnSharpen
            // 
            this.btnSharpen.Location = new System.Drawing.Point(168, 550);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(139, 23);
            this.btnSharpen.TabIndex = 6;
            this.btnSharpen.Text = "Apply Sharpen filter";
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // brnDetectEdges
            // 
            this.brnDetectEdges.Location = new System.Drawing.Point(13, 521);
            this.brnDetectEdges.Name = "brnDetectEdges";
            this.brnDetectEdges.Size = new System.Drawing.Size(139, 23);
            this.brnDetectEdges.TabIndex = 7;
            this.brnDetectEdges.Text = "Edge detection";
            this.brnDetectEdges.UseVisualStyleBackColor = true;
            this.brnDetectEdges.Click += new System.EventHandler(this.brnDetectEdges_Click);
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(12, 550);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(139, 23);
            this.btnBrightness.TabIndex = 8;
            this.btnBrightness.Text = "Set brightness";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.Location = new System.Drawing.Point(13, 579);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(139, 23);
            this.btnContrast.TabIndex = 9;
            this.btnContrast.Text = "Set contrast";
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnGamma
            // 
            this.btnGamma.Location = new System.Drawing.Point(13, 608);
            this.btnGamma.Name = "btnGamma";
            this.btnGamma.Size = new System.Drawing.Size(139, 23);
            this.btnGamma.TabIndex = 10;
            this.btnGamma.Text = "Set gamma";
            this.btnGamma.UseVisualStyleBackColor = true;
            this.btnGamma.Click += new System.EventHandler(this.btnGamma_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(325, 492);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(139, 23);
            this.btnRotate.TabIndex = 11;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnFlipH
            // 
            this.btnFlipH.Location = new System.Drawing.Point(325, 521);
            this.btnFlipH.Name = "btnFlipH";
            this.btnFlipH.Size = new System.Drawing.Size(139, 23);
            this.btnFlipH.TabIndex = 12;
            this.btnFlipH.Text = "Flip horizontal";
            this.btnFlipH.UseVisualStyleBackColor = true;
            this.btnFlipH.Click += new System.EventHandler(this.btnFlipH_Click);
            // 
            // btnFlipV
            // 
            this.btnFlipV.Location = new System.Drawing.Point(325, 550);
            this.btnFlipV.Name = "btnFlipV";
            this.btnFlipV.Size = new System.Drawing.Size(139, 23);
            this.btnFlipV.TabIndex = 13;
            this.btnFlipV.Text = "Flip vertical";
            this.btnFlipV.UseVisualStyleBackColor = true;
            this.btnFlipV.Click += new System.EventHandler(this.btnFlipV_Click);
            // 
            // btnResizeH
            // 
            this.btnResizeH.Location = new System.Drawing.Point(481, 492);
            this.btnResizeH.Name = "btnResizeH";
            this.btnResizeH.Size = new System.Drawing.Size(139, 23);
            this.btnResizeH.TabIndex = 14;
            this.btnResizeH.Text = "Resize horizontal";
            this.btnResizeH.UseVisualStyleBackColor = true;
            this.btnResizeH.Click += new System.EventHandler(this.btnResizeH_Click);
            // 
            // btnResizeV
            // 
            this.btnResizeV.Location = new System.Drawing.Point(481, 521);
            this.btnResizeV.Name = "btnResizeV";
            this.btnResizeV.Size = new System.Drawing.Size(139, 23);
            this.btnResizeV.TabIndex = 15;
            this.btnResizeV.TabStop = false;
            this.btnResizeV.Text = "Resize vertical";
            this.btnResizeV.UseVisualStyleBackColor = true;
            this.btnResizeV.Click += new System.EventHandler(this.btnResizeV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 678);
            this.Controls.Add(this.btnResizeV);
            this.Controls.Add(this.btnResizeH);
            this.Controls.Add(this.btnFlipV);
            this.Controls.Add(this.btnFlipH);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnGamma);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.brnDetectEdges);
            this.Controls.Add(this.btnSharpen);
            this.Controls.Add(this.btnGaussian);
            this.Controls.Add(this.btnMedianFilter);
            this.Controls.Add(this.btnGreyScale);
            this.Controls.Add(this.pbProcessed);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbProcessed;
        private System.Windows.Forms.Button btnGreyScale;
        private System.Windows.Forms.Button btnMedianFilter;
        private System.Windows.Forms.Button btnGaussian;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button brnDetectEdges;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnGamma;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnFlipH;
        private System.Windows.Forms.Button btnFlipV;
        private System.Windows.Forms.Button btnResizeH;
        private System.Windows.Forms.Button btnResizeV;
    }
}

