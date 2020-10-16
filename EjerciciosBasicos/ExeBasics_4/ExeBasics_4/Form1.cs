using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calul_Click(object sender, EventArgs e)
        {
            int un = Int32.Parse(PrimertextBox.Text);
            int dos = Int32.Parse(SegontextBox.Text);

            if (Operacio.Text == "+")
            {
                int resulp = un + dos;

                ResultattextBox.Text = resulp.ToString();
            }
            else
            {
                int resuln = un - dos;

                ResultattextBox.Text = resuln.ToString();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PrimertextBox.Text = "0";
            SegontextBox.Text = "0";
            ResultattextBox.Text = "0";
            Operacio.Text = " ";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            Operacio.Text = "+";
        }

        private void Subs_Click(object sender, EventArgs e)
        {
            Operacio.Text = "-";
        }
    }
}
