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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int un = Int32.Parse(textBox1.Text);
            int dos = Int32.Parse(textBox2.Text);

            if (textBox4.Text == "+")
            {
                int resulp = un + dos;

                textBox3.Text = resulp.ToString();
            } else
            {
                int resuln = un - dos;

                textBox3.Text = resuln.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = " ";
        }
    }
}
