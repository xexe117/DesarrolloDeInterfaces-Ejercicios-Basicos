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


        private void button4_Click(object sender, EventArgs e)
        {
            NumBox1.Text = "0";
            NumBox2.Text = "0";
            ResutBox.Text = "0";
            OperationBox4.Text = " ";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectlistBox.Text == "+")
            {
                OperationBox4.Text = "+";
            }
            else
            {
                OperationBox4.Text = "-";
            }
        }

        private void Calculbutt_Click(object sender, EventArgs e)
        {
            int un = Int32.Parse(NumBox1.Text);
            int dos = Int32.Parse(NumBox2.Text);

            if (SelectlistBox.Text == "+")
            {
                int resulp = un + dos;

                ResutBox.Text = resulp.ToString();
            }
            else
            {
                int resuln = un - dos;

                ResutBox.Text = resuln.ToString();
            }
        }

        private void Restbutton_Click(object sender, EventArgs e)
        {
            NumBox1.Text = "0";
            NumBox2.Text = "0";
            ResutBox.Text = "0";
            OperationBox4.Text = " ";
        }
    }
}
