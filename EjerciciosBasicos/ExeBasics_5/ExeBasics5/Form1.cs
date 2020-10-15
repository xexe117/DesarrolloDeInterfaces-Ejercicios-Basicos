using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (Mause.Checked == true && Cat.Checked == true && Dog.Checked == true)
            {
                AnimaltextBox.Text = "You choose the animals: Mouse Cat and Dog";
            }
            if (Mause.Checked == true && Cat.Checked == true && Dog.Checked == false)
            {
                AnimaltextBox.Text = "You choose the animals: Mouse and Cat";
            }
            if (Mause.Checked == true && Cat.Checked == false && Dog.Checked == false)
            {
                AnimaltextBox.Text = "You choose the animal: Mouse";
            }
            if (Mause.Checked == false && Cat.Checked == true && Dog.Checked == true)
            {
                AnimaltextBox.Text = "You choose the animals: Cat and Dog";
            }
            if (Mause.Checked == false && Cat.Checked == true && Dog.Checked == false)
            {
                AnimaltextBox.Text = "You choose the animal: Cat";
            }
            if (Mause.Checked == false && Cat.Checked == false && Dog.Checked == true)
            {
                AnimaltextBox.Text = "You choose the animal: dog";
            }
            if (Mause.Checked == true && Cat.Checked == false && Dog.Checked == true)
            {
                AnimaltextBox.Text = "You choose the animals: Mause and Dog";
            }
            if (Mause.Checked == false && Cat.Checked == false && Dog.Checked == false)
            {
                AnimaltextBox.Text = "You didn't choose";
            }
        }
    }
}