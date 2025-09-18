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
            this.SuspendLayout();
            // 
            // buttonBackToForm1
            // 
            this.buttonBackToForm1.Location = new System.Drawing.Point(345, 182);
            this.buttonBackToForm1.Name = "buttonBackToForm1";
            this.buttonBackToForm1.Size = new System.Drawing.Size(75, 56);
            this.buttonBackToForm1.TabIndex = 0;
            this.buttonBackToForm1.Text = "Part1";
            this.buttonBackToForm1.UseVisualStyleBackColor = true;
            this.buttonBackToForm1.Click += new System.EventHandler(this.buttonBackToForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 652);
            this.Controls.Add(this.buttonBackToForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToForm1;
    }
}