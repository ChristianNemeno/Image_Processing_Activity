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
    public partial class Form2 : Form
    {
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
    }
}
