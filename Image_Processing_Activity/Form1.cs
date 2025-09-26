using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                Bitmap ogImage = new Bitmap(pictureBox1.Image);

                Bitmap toCopy = new Bitmap(ogImage.Width, ogImage.Height);

                for(int y =0; y < ogImage.Height; y++)
                {
                    for(int x=0; x < ogImage.Width; x++)
                    {
                        Color px = ogImage.GetPixel(x, y);
                        toCopy.SetPixel(x, y, px);
                    }
                }

                pictureBox2.Image = toCopy;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonGreyScale_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap ogImage = new Bitmap(pictureBox1.Image);

                Bitmap toCopy = new Bitmap(ogImage.Width, ogImage.Height);

                for (int y = 0; y < ogImage.Height; y++)
                {
                    for (int x = 0; x < ogImage.Width; x++)
                    {
                        Color px = ogImage.GetPixel(x, y);
                        int gray = (px.R + px.G + px.B) / 3;

                        Color newPx = Color.FromArgb(gray, gray, gray);

                        toCopy.SetPixel(x, y, newPx);
                    }
                }

                pictureBox2.Image = toCopy;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonInversion_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap ogImage = new Bitmap(pictureBox1.Image);

                Bitmap toCopy = new Bitmap(ogImage.Width, ogImage.Height);

                for (int y = 0; y < ogImage.Height; y++)
                {
                    for (int x = 0; x < ogImage.Width; x++)
                    {
                        Color px = ogImage.GetPixel(x, y);
                        //int gray = (px.R + px.G + px.B) / 3;

                        Color newPx = Color.FromArgb(255-px.R, 255-px.G, 255-px.B);

                        toCopy.SetPixel(x, y, newPx);
                    }
                }

                pictureBox2.Image = toCopy;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color px = originalImage.GetPixel(x, y);
                    int gray = (px.R + px.G + px.B) / 3;
                    Color newPx = Color.FromArgb(gray, gray, gray);
                    grayscaleImage.SetPixel(x, y, newPx);
                }
            }

            int[] histogramData = new int[256];
            for (int y = 0; y < grayscaleImage.Height; y++)
            {
                for (int x = 0; x < grayscaleImage.Width; x++)
                {
                    histogramData[grayscaleImage.GetPixel(x, y).R]++;
                }
            }

            int maxFrequency = 0;
            foreach (int frequency in histogramData)
            {
                if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                }
            }


            int graphWidth = 256;
            int graphHeight = 150; 
            int marginLeft = 40;  
            int marginRight = 10;
            int marginTop = 20;    
            int marginBottom = 40; 

            int bitmapWidth = graphWidth + marginLeft + marginRight;
            int bitmapHeight = graphHeight + marginTop + marginBottom;

            Bitmap histogramBitmap = new Bitmap(bitmapWidth, bitmapHeight);

            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                for (int i = 0; i < graphWidth; i++)
                {
                    float scaledValue = ((float)histogramData[i] / maxFrequency) * graphHeight;
                    g.DrawLine(Pens.Black,
                               marginLeft + i,                                 
                               marginTop + graphHeight,                        
                               marginLeft + i,                                 
                               marginTop + graphHeight - scaledValue);         
                }

                g.DrawLine(Pens.Black, marginLeft, marginTop + graphHeight, marginLeft + graphWidth, marginTop + graphHeight); // X-axis
                g.DrawLine(Pens.Black, marginLeft, marginTop, marginLeft, marginTop + graphHeight); 

                
            }

            

                pictureBox2.Image = grayscaleImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox3.Image = histogramBitmap;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap ogImage = new Bitmap(pictureBox1.Image);

                Bitmap toCopy = new Bitmap(ogImage.Width, ogImage.Height);

                for (int y = 0; y < ogImage.Height; y++)
                {
                    for (int x = 0; x < ogImage.Width; x++)
                    {
                        Color originalPixel = ogImage.GetPixel(x, y);
                        //int gray = (px.R + px.G + px.B) / 3;

                        int tempRed = (int)((originalPixel.R * 0.393) + (originalPixel.G * 0.769) + (originalPixel.B * 0.189));
                        int tempGreen = (int)((originalPixel.R * 0.349) + (originalPixel.G * 0.686) + (originalPixel.B * 0.168));
                        int tempBlue = (int)((originalPixel.R * 0.272) + (originalPixel.G * 0.534) + (originalPixel.B * 0.131));

                        int newRed = tempRed > 255 ? 255 : tempRed;
                        int newGreen = tempGreen > 255 ? 255 : tempGreen;
                        int newBlue = tempBlue > 255 ? 255 : tempBlue;
                        
                        Color newPx = Color.FromArgb(newRed, newGreen, newBlue);

                        toCopy.SetPixel(x, y, newPx);
                    }
                }

                pictureBox2.Image = toCopy;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void buttonChangeForm2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form form2 = new Form2();
            form2.ShowDialog();

            this.Close();
            
        }

        private void Smooth_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                BitmapFilter.Smooth(processedImage, 1);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

                

                matrix.TopLeft = 1;
                matrix.TopMid = 2;
                matrix.TopRight = 1;
                matrix.MidLeft = 2;
                matrix.Pixel = 4;
                matrix.MidRight = 2;
                matrix.BottomLeft = 1;
                matrix.BottomMid = 2;
                matrix.BottomRight = 1;

                matrix.Factor = 16;
                matrix.Offset = 0;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void buttonSharpen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

                

                
                matrix.TopMid = -2;
                matrix.MidLeft = -2;
                matrix.Pixel = 11;
                matrix.MidRight = -2;
                matrix.BottomMid = -2;
                
                matrix.Factor = 3;
                matrix.Offset = 0;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonEmboss_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

                


                matrix.TopLeft= -1;
                matrix.TopRight = -1;
                matrix.Pixel = 4;
                matrix.BottomLeft = -1;
                matrix.BottomRight = -1;

                matrix.Factor = 1;
                matrix.Offset = 127;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonEmbossHorz_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();



                matrix.TopMid = -1;
                matrix.MidLeft = -1;
                matrix.Pixel = 4;
                matrix.MidRight = -1;
                matrix.BottomMid = -1;

                matrix.Factor = 1;
                matrix.Offset = 127;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonEmbossAll_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

                matrix.SetAll(1);

                matrix.SetAll(-1);


                matrix.Pixel = 8;
                

                matrix.Factor = 1;
                matrix.Offset = 127;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonMeanRemoval_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

               

                matrix.SetAll(-1);


                matrix.Pixel = 9;


                matrix.Factor = 1;
                matrix.Offset = 0;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void buttonEmbossLossy_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                ConvMatrix matrix = new ConvMatrix();

                
                matrix.TopRight = 1;
                matrix.TopMid = -2;
                matrix.TopLeft = 1;

                matrix.MidRight = -2;
                matrix.Pixel = 4;
                matrix.MidLeft = -2;

                matrix.BottomRight = -2;
                matrix.BottomMid = 1;
                matrix.BottomLeft = -2;

                matrix.Factor = 1;
                matrix.Offset = 127;

                BitmapFilter.Conv3x3(processedImage, matrix);

                pictureBox2.Image = processedImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
