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
        { // this button is for load image
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

                using (Font axisFont = new Font("Arial", 8))
                using (Brush textBrush = Brushes.Black)
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    g.DrawString("Intensity", axisFont, textBrush, marginLeft + graphWidth / 2, marginTop + graphHeight + 15, format);
                    g.DrawString("0", axisFont, textBrush, marginLeft, marginTop + graphHeight + 5);
                    g.DrawString("128", axisFont, textBrush, marginLeft + 128, marginTop + graphHeight + 5, format);
                    g.DrawString("255", axisFont, textBrush, marginLeft + 255, marginTop + graphHeight + 5, format);

                    format.Alignment = StringAlignment.Near;
                    g.DrawString("0", axisFont, textBrush, marginLeft - 15, marginTop + graphHeight - 10, format);
                    g.DrawString(maxFrequency.ToString(), axisFont, textBrush, marginLeft - 35, marginTop, format);

                    GraphicsState state = g.Save(); 
                    g.TranslateTransform(15, marginTop + graphHeight / 2); 
                    g.RotateTransform(-90); 
                    format.Alignment = StringAlignment.Center;
                    g.DrawString("Frequency", axisFont, textBrush, 0, 0, format);
                    g.Restore(state); // Restore back to normal
                }
            }

            

                pictureBox2.Image = grayscaleImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox3.Image = histogramBitmap;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
