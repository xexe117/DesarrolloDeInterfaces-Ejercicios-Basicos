using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EvenButt_Click(object sender, EventArgs e)
        {
            NumComboBox.Items.Clear();
            for (int i = 1; i < 10; i++)
            {
                i++;
                NumComboBox.Items.Add("Nº " + i);
            }
        }

        private void OddButt_Click(object sender, EventArgs e)
        {
            NumComboBox.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                i++;
                NumComboBox.Items.Add("Nº " + i);
            }
        }

        private void NumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplicaText.Text = NumComboBox.Text;
        }
    }
}
