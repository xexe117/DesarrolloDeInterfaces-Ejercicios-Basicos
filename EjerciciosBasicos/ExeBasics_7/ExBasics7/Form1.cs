using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExBasics7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColortextBox.Text = "The choosen colur is: " + ColorcomboBox.Text;
        }
    }
}
