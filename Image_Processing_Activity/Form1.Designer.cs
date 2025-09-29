namespace Image_Processing_Activity
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonGreyScale = new System.Windows.Forms.Button();
            this.buttonInversion = new System.Windows.Forms.Button();
            this.buttonHistogram = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonSepia = new System.Windows.Forms.Button();
            this.buttonChangeForm2 = new System.Windows.Forms.Button();
            this.Smooth = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonSharpen = new System.Windows.Forms.Button();
            this.buttonEmboss = new System.Windows.Forms.Button();
            this.buttonEmbossHorz = new System.Windows.Forms.Button();
            this.buttonEmbossAll = new System.Windows.Forms.Button();
            this.buttonMeanRemoval = new System.Windows.Forms.Button();
            this.buttonEmbossLossy = new System.Windows.Forms.Button();
            this.buttonHorizontalOnly = new System.Windows.Forms.Button();
            this.buttonVertOnly = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(333, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(21, 315);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 65);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(102, 315);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 65);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Basic Copy ";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonGreyScale
            // 
            this.buttonGreyScale.Location = new System.Drawing.Point(183, 315);
            this.buttonGreyScale.Name = "buttonGreyScale";
            this.buttonGreyScale.Size = new System.Drawing.Size(73, 64);
            this.buttonGreyScale.TabIndex = 4;
            this.buttonGreyScale.Text = "Grey scale";
            this.buttonGreyScale.UseVisualStyleBackColor = true;
            this.buttonGreyScale.Click += new System.EventHandler(this.buttonGreyScale_Click);
            // 
            // buttonInversion
            // 
            this.buttonInversion.Location = new System.Drawing.Point(262, 316);
            this.buttonInversion.Name = "buttonInversion";
            this.buttonInversion.Size = new System.Drawing.Size(75, 64);
            this.buttonInversion.TabIndex = 5;
            this.buttonInversion.Text = "Color Inversion";
            this.buttonInversion.UseVisualStyleBackColor = true;
            this.buttonInversion.Click += new System.EventHandler(this.buttonInversion_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(343, 316);
            this.buttonHistogram.Name = "buttonHistogram";
            this.buttonHistogram.Size = new System.Drawing.Size(79, 64);
            this.buttonHistogram.TabIndex = 6;
            this.buttonHistogram.Text = "Histogram";
            this.buttonHistogram.UseVisualStyleBackColor = true;
            this.buttonHistogram.Click += new System.EventHandler(this.buttonHistogram_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(640, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 200);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // buttonSepia
            // 
            this.buttonSepia.Location = new System.Drawing.Point(428, 316);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(75, 65);
            this.buttonSepia.TabIndex = 8;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = true;
            this.buttonSepia.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonChangeForm2
            // 
            this.buttonChangeForm2.Location = new System.Drawing.Point(590, 316);
            this.buttonChangeForm2.Name = "buttonChangeForm2";
            this.buttonChangeForm2.Size = new System.Drawing.Size(75, 63);
            this.buttonChangeForm2.TabIndex = 9;
            this.buttonChangeForm2.Text = "Part 2";
            this.buttonChangeForm2.UseVisualStyleBackColor = true;
            this.buttonChangeForm2.Click += new System.EventHandler(this.buttonChangeForm2_Click);
            // 
            // Smooth
            // 
            this.Smooth.Location = new System.Drawing.Point(102, 386);
            this.Smooth.Name = "Smooth";
            this.Smooth.Size = new System.Drawing.Size(75, 62);
            this.Smooth.TabIndex = 10;
            this.Smooth.Text = "Smooth";
            this.Smooth.UseVisualStyleBackColor = true;
            this.Smooth.Click += new System.EventHandler(this.Smooth_Click);
            // 
            // buttonBlur
            // 
            this.buttonBlur.Location = new System.Drawing.Point(21, 386);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(75, 62);
            this.buttonBlur.TabIndex = 11;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonSharpen
            // 
            this.buttonSharpen.Location = new System.Drawing.Point(21, 522);
            this.buttonSharpen.Name = "buttonSharpen";
            this.buttonSharpen.Size = new System.Drawing.Size(75, 62);
            this.buttonSharpen.TabIndex = 12;
            this.buttonSharpen.Text = "Sharpen";
            this.buttonSharpen.UseVisualStyleBackColor = true;
            this.buttonSharpen.Click += new System.EventHandler(this.buttonSharpen_Click);
            // 
            // buttonEmboss
            // 
            this.buttonEmboss.Location = new System.Drawing.Point(21, 454);
            this.buttonEmboss.Name = "buttonEmboss";
            this.buttonEmboss.Size = new System.Drawing.Size(75, 62);
            this.buttonEmboss.TabIndex = 13;
            this.buttonEmboss.Text = "Emboss";
            this.buttonEmboss.UseVisualStyleBackColor = true;
            this.buttonEmboss.Click += new System.EventHandler(this.buttonEmboss_Click);
            // 
            // buttonEmbossHorz
            // 
            this.buttonEmbossHorz.Location = new System.Drawing.Point(103, 455);
            this.buttonEmbossHorz.Name = "buttonEmbossHorz";
            this.buttonEmbossHorz.Size = new System.Drawing.Size(75, 61);
            this.buttonEmbossHorz.TabIndex = 14;
            this.buttonEmbossHorz.Text = "Horz/Vertical";
            this.buttonEmbossHorz.UseVisualStyleBackColor = true;
            this.buttonEmbossHorz.Click += new System.EventHandler(this.buttonEmbossHorz_Click);
            // 
            // buttonEmbossAll
            // 
            this.buttonEmbossAll.Location = new System.Drawing.Point(185, 455);
            this.buttonEmbossAll.Name = "buttonEmbossAll";
            this.buttonEmbossAll.Size = new System.Drawing.Size(75, 61);
            this.buttonEmbossAll.TabIndex = 15;
            this.buttonEmbossAll.Text = "All direction";
            this.buttonEmbossAll.UseVisualStyleBackColor = true;
            this.buttonEmbossAll.Click += new System.EventHandler(this.buttonEmbossAll_Click);
            // 
            // buttonMeanRemoval
            // 
            this.buttonMeanRemoval.Location = new System.Drawing.Point(103, 522);
            this.buttonMeanRemoval.Name = "buttonMeanRemoval";
            this.buttonMeanRemoval.Size = new System.Drawing.Size(75, 62);
            this.buttonMeanRemoval.TabIndex = 16;
            this.buttonMeanRemoval.Text = "Mean removal";
            this.buttonMeanRemoval.UseVisualStyleBackColor = true;
            this.buttonMeanRemoval.Click += new System.EventHandler(this.buttonMeanRemoval_Click);
            // 
            // buttonEmbossLossy
            // 
            this.buttonEmbossLossy.Location = new System.Drawing.Point(267, 454);
            this.buttonEmbossLossy.Name = "buttonEmbossLossy";
            this.buttonEmbossLossy.Size = new System.Drawing.Size(75, 62);
            this.buttonEmbossLossy.TabIndex = 17;
            this.buttonEmbossLossy.Text = "Lossy";
            this.buttonEmbossLossy.UseVisualStyleBackColor = true;
            this.buttonEmbossLossy.Click += new System.EventHandler(this.buttonEmbossLossy_Click);
            // 
            // buttonHorizontalOnly
            // 
            this.buttonHorizontalOnly.Location = new System.Drawing.Point(349, 455);
            this.buttonHorizontalOnly.Name = "buttonHorizontalOnly";
            this.buttonHorizontalOnly.Size = new System.Drawing.Size(75, 61);
            this.buttonHorizontalOnly.TabIndex = 18;
            this.buttonHorizontalOnly.Text = "Horizontal Only";
            this.buttonHorizontalOnly.UseVisualStyleBackColor = true;
            this.buttonHorizontalOnly.Click += new System.EventHandler(this.buttonHorizontalOnly_Click);
            // 
            // buttonVertOnly
            // 
            this.buttonVertOnly.Location = new System.Drawing.Point(428, 454);
            this.buttonVertOnly.Name = "buttonVertOnly";
            this.buttonVertOnly.Size = new System.Drawing.Size(75, 62);
            this.buttonVertOnly.TabIndex = 19;
            this.buttonVertOnly.Text = "Vertical Only";
            this.buttonVertOnly.UseVisualStyleBackColor = true;
            this.buttonVertOnly.Click += new System.EventHandler(this.buttonVertOnly_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(509, 316);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 63);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 637);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonVertOnly);
            this.Controls.Add(this.buttonHorizontalOnly);
            this.Controls.Add(this.buttonEmbossLossy);
            this.Controls.Add(this.buttonMeanRemoval);
            this.Controls.Add(this.buttonEmbossAll);
            this.Controls.Add(this.buttonEmbossHorz);
            this.Controls.Add(this.buttonEmboss);
            this.Controls.Add(this.buttonSharpen);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.Smooth);
            this.Controls.Add(this.buttonChangeForm2);
            this.Controls.Add(this.buttonSepia);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonHistogram);
            this.Controls.Add(this.buttonInversion);
            this.Controls.Add(this.buttonGreyScale);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonGreyScale;
        private System.Windows.Forms.Button buttonInversion;
        private System.Windows.Forms.Button buttonHistogram;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonSepia;
        private System.Windows.Forms.Button buttonChangeForm2;
        private System.Windows.Forms.Button Smooth;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.Button buttonSharpen;
        private System.Windows.Forms.Button buttonEmboss;
        private System.Windows.Forms.Button buttonEmbossHorz;
        private System.Windows.Forms.Button buttonEmbossAll;
        private System.Windows.Forms.Button buttonMeanRemoval;
        private System.Windows.Forms.Button buttonEmbossLossy;
        private System.Windows.Forms.Button buttonHorizontalOnly;
        private System.Windows.Forms.Button buttonVertOnly;
        private System.Windows.Forms.Button buttonSave;
    }
}

