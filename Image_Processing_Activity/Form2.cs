using System;
using System.Drawing;
using System.Windows.Forms;
using WebCamLib;
// Add this for LockBits
using System.Drawing.Imaging;

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
            processingTimer.Interval = 100; // You can try lowering this to 50 for smoother video
            processingTimer.Tick += ProcessingTimer_Tick;
        }

        private void Form2_Load(object sender, EventArgs e) { }

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
                else { MessageBox.Show("No webcam found."); }
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
            var form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(ofd.FileName);
                pictureBoxImage.Image = imageB;
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonLoadBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif" };
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
            if (imageA == null) { MessageBox.Show("Please load a background image first."); return; }
            if (webcam == null && imageB == null) { MessageBox.Show("Please start the camera or load a foreground image."); return; }

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
                else { PerformSubtraction(); }
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

            
            Rectangle rect = new Rectangle(0, 0, imageB.Width, imageB.Height);

            
            BitmapData foregroundData = imageB.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData backgroundData = imageA.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            
            IntPtr fgPtr = foregroundData.Scan0;
            IntPtr bgPtr = backgroundData.Scan0;
            IntPtr resPtr = resultData.Scan0;

            
            int bytes = Math.Abs(foregroundData.Stride) * imageB.Height;
            byte[] fgValues = new byte[bytes];
            byte[] bgValues = new byte[bytes];
            byte[] resValues = new byte[bytes];

            
            System.Runtime.InteropServices.Marshal.Copy(fgPtr, fgValues, 0, bytes);
            System.Runtime.InteropServices.Marshal.Copy(bgPtr, bgValues, 0, bytes);

            
            for (int i = 0; i < bytes; i += 3)
            {
                byte blue = fgValues[i];
                byte green = fgValues[i + 1];
                byte red = fgValues[i + 2];

                int greenStrength = green - Math.Max(red, blue);

                if (greenStrength > threshold)
                {
                    
                    resValues[i] = bgValues[i];         
                    resValues[i + 1] = bgValues[i + 1]; 
                    resValues[i + 2] = bgValues[i + 2];
                }
                else
                {
                    
                    resValues[i] = blue;
                    resValues[i + 1] = green;
                    resValues[i + 2] = red;
                }
            }

           
            System.Runtime.InteropServices.Marshal.Copy(resValues, 0, resPtr, bytes);

            
            imageB.UnlockBits(foregroundData);
            imageA.UnlockBits(backgroundData);
            resultImage.UnlockBits(resultData);

           
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
                processingTimer?.Stop();
                webcam.Stop();
                webcam = null;
            }
        }
    }
}