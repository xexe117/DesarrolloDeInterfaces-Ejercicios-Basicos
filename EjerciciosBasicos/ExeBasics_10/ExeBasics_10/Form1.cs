using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeBasics_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int valor = ScrollBar.Value;
            NumberBox.Text = valor.ToString() + " %";
        }

        //Hen los parametros de la scrolbar he puesto que el numero maximo sea 90 porque si ponia 80 en la textbar solo me llegava hasta el numero 70
    }
}
