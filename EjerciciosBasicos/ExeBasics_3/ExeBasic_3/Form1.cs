using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasic_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox texboxevento = (TextBox)sender;
            String dedins = texboxevento.Text;

            int dos = Convert.ToInt32(dedins);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButt_Click(object sender, EventArgs e)
        {
            int un = Int32.Parse(OpBox1.Text);
            int dos = Int32.Parse(OpBox2.Text);
            int resul = un + dos;

            OpBox3.Text = resul.ToString();
        }

        private void ResButt2_Click(object sender, EventArgs e)
        {
            OpBox1.Text = "0";
            OpBox2.Text = "0";
            OpBox3.Text = "0";
        }
    }
}
