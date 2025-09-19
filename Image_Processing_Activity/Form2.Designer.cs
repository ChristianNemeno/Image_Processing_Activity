namespace Image_Processing_Activity
{
    partial class Form2
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
            this.buttonBackToForm1 = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.pictureBoxSubtract = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonLoadBackground = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtract)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToForm1
            // 
            this.buttonBackToForm1.Location = new System.Drawing.Point(30, 23);
            this.buttonBackToForm1.Name = "buttonBackToForm1";
            this.buttonBackToForm1.Size = new System.Drawing.Size(75, 56);
            this.buttonBackToForm1.TabIndex = 0;
            this.buttonBackToForm1.Text = "Part1";
            this.buttonBackToForm1.UseVisualStyleBackColor = true;
            this.buttonBackToForm1.Click += new System.EventHandler(this.buttonBackToForm1_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(30, 146);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(256, 209);
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBG.Location = new System.Drawing.Point(329, 146);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(245, 209);
            this.pictureBoxBG.TabIndex = 2;
            this.pictureBoxBG.TabStop = false;
            // 
            // pictureBoxSubtract
            // 
            this.pictureBoxSubtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSubtract.Location = new System.Drawing.Point(635, 146);
            this.pictureBoxSubtract.Name = "pictureBoxSubtract";
            this.pictureBoxSubtract.Size = new System.Drawing.Size(246, 209);
            this.pictureBoxSubtract.TabIndex = 3;
            this.pictureBoxSubtract.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(107, 387);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 51);
            this.buttonLoadImage.TabIndex = 4;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonLoadBackground
            // 
            this.buttonLoadBackground.Location = new System.Drawing.Point(408, 387);
            this.buttonLoadBackground.Name = "buttonLoadBackground";
            this.buttonLoadBackground.Size = new System.Drawing.Size(92, 51);
            this.buttonLoadBackground.TabIndex = 5;
            this.buttonLoadBackground.Text = "Load Background";
            this.buttonLoadBackground.UseVisualStyleBackColor = true;
            this.buttonLoadBackground.Click += new System.EventHandler(this.buttonLoadBackground_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(722, 387);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(75, 51);
            this.buttonSubtract.TabIndex = 6;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 652);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonLoadBackground);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.pictureBoxSubtract);
            this.Controls.Add(this.pictureBoxBG);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonBackToForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToForm1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.PictureBox pictureBoxSubtract;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonLoadBackground;
        private System.Windows.Forms.Button buttonSubtract;
    }
}