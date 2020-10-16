using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Class1_Click(object sender, EventArgs e)
        {
            redactBox.Text = StudentsBox.Items[0].ToString() + " " + StudentsBox.Items[1].ToString() + " " + StudentsBox.Items[2].ToString();
        }

        private void Class2_Click(object sender, EventArgs e)
        {
            redactBox.Text = StudentsBox.Items[2].ToString() + " " + StudentsBox.Items[1].ToString() + " " + StudentsBox.Items[0].ToString();
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            StudentsBox.Items.Clear();
        }

        private void StudentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            redactBox.Text = StudentsBox.Text;
        }
    }
}
