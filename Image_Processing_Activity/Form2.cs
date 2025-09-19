using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Image_Processing_Activity
{
    public partial class Form2 : Form
    {

        Bitmap imageB, imageA, resultImage;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBackToForm1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Form form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

       
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(ofd.FileName);
                pictureBoxImage.Image = imageB;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonLoadBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(ofd.FileName);
                pictureBoxBG.Image = imageA;
                pictureBoxBG.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (imageB == null || imageA == null)
            {
                MessageBox.Show("Please load both an image and a background.");
                return;
            }

            resultImage = new Bitmap(imageB.Width, imageB.Height);

            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;


            for(int x = 0; x < resultImage.Width; x++)
            {
                for(int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backPixel = imageA.GetPixel(x, y);

                    int grey= (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey- greygreen);


                    if(subtractvalue > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, backPixel);
                    }


                }
            }
            pictureBoxSubtract.Image = resultImage;
            pictureBoxSubtract.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
