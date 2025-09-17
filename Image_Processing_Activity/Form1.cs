using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
