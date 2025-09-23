using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace Image_Processing_Activity
{
    public partial class Form2 : Form
    {
        Bitmap imageA, imageB, resultImage;

        private Device webcam;
        private Timer processingTimer;

        public Form2()
        {
            InitializeComponent();
            processingTimer = new Timer();
            processingTimer.Interval = 100;
            processingTimer.Tick += ProcessingTimer_Tick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            if (webcam == null)
            {
                Device[] devices = DeviceManager.GetAllDevices();
                if (devices.Length > 0)
                {
                    webcam = devices[0];
                    webcam.ShowWindow(pictureBoxImage);

                    buttonCamera.Text = "Stop Camera";
                    buttonLoadImage.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No webcam found.");
                }
            }
            else
            {
                processingTimer.Stop();
                buttonSubtract.Text = "Start Subtract";

                webcam.Stop();
                webcam = null; 
                
                pictureBoxImage.Image = null;
                buttonCamera.Text = "Start Camera";
                buttonLoadImage.Enabled = true;
            }
        }

        private void buttonBackToForm1_Click(object sender, EventArgs e)
        {
            StopAllProcesses();
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
                
                imageA = new Bitmap(imageA, pictureBoxImage.Width, pictureBoxImage.Height);
                pictureBoxBG.Image = imageA;
                pictureBoxBG.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load a background image first.");
                return;
            }
            if (webcam == null && imageB == null)
            {
                MessageBox.Show("Please start the camera or load a foreground image.");
                return;
            }

            if (processingTimer.Enabled)
            {
                processingTimer.Stop();
                buttonSubtract.Text = "Start Subtract";
            }
            else
            {
                if (webcam != null)
                {
                    processingTimer.Start();
                    buttonSubtract.Text = "Stop Subtract";
                }
                else 
                {
                    PerformSubtraction();
                }
            }
        }

        private void ProcessingTimer_Tick(object sender, EventArgs e)
        {
            if (webcam == null || imageA == null) return;

            webcam.Sendmessage();
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetDataPresent(DataFormats.Bitmap))
            {
                imageB = (Bitmap)data.GetData(DataFormats.Bitmap, true);
                PerformSubtraction();
            }
        }

        private void PerformSubtraction()
        {
            if (imageB == null || imageA == null) return;

            if (imageA.Width != imageB.Width || imageA.Height != imageB.Height)
            {
                imageA = new Bitmap(imageA, imageB.Width, imageB.Height);
            }

            resultImage = new Bitmap(imageB.Width, imageB.Height);

            
            int threshold = 10;

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backPixel = imageA.GetPixel(x, y);

                    int greenStrength = pixel.G - Math.Max(pixel.R, pixel.B);

                    if (greenStrength > threshold)
                    {
                        resultImage.SetPixel(x, y, backPixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                }
            }

            pictureBoxSubtract.Image = resultImage;
            pictureBoxSubtract.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllProcesses();
        }

        private void StopAllProcesses()
        {
            if (webcam != null)
            {
                processingTimer.Stop();
                webcam.Stop();
                webcam = null;
            }
        }
    }
}