﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //No le doy un nombre porque no es necesario al solo tener una check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         if(checkBox1.Checked == true){
                MessageBox.Show("Checkbox checked");
            }
            else
            {
                MessageBox.Show("Checkbox unchecked");
            }
            
                
        }
    }
}
