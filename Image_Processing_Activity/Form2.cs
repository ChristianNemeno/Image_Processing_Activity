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
    }
}
