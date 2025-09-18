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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(295, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 440);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(44, 537);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 65);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(125, 537);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 65);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Basic Copy ";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonGreyScale
            // 
            this.buttonGreyScale.Location = new System.Drawing.Point(206, 537);
            this.buttonGreyScale.Name = "buttonGreyScale";
            this.buttonGreyScale.Size = new System.Drawing.Size(73, 64);
            this.buttonGreyScale.TabIndex = 4;
            this.buttonGreyScale.Text = "Grey scale";
            this.buttonGreyScale.UseVisualStyleBackColor = true;
            this.buttonGreyScale.Click += new System.EventHandler(this.buttonGreyScale_Click);
            // 
            // buttonInversion
            // 
            this.buttonInversion.Location = new System.Drawing.Point(285, 538);
            this.buttonInversion.Name = "buttonInversion";
            this.buttonInversion.Size = new System.Drawing.Size(75, 64);
            this.buttonInversion.TabIndex = 5;
            this.buttonInversion.Text = "Color Inversion";
            this.buttonInversion.UseVisualStyleBackColor = true;
            this.buttonInversion.Click += new System.EventHandler(this.buttonInversion_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(366, 537);
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
            this.pictureBox3.Location = new System.Drawing.Point(577, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(323, 440);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // buttonSepia
            // 
            this.buttonSepia.Location = new System.Drawing.Point(469, 537);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(75, 65);
            this.buttonSepia.TabIndex = 8;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = true;
            this.buttonSepia.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 637);
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
    }
}

