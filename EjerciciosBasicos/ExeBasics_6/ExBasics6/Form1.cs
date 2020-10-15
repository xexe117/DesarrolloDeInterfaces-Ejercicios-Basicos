using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExBasics6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (Red.Checked == true)
            {
                ColortextBox.Text = "You choose the color: Red";
            }
            if (Blue.Checked == true)
            {
                ColortextBox.Text = "You choose the color: Blue";
            }
            if (White.Checked == true)
            {
                ColortextBox.Text = "You choose the color: White";
            }
        }
    }
}
