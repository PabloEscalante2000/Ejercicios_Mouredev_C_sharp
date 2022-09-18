using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Mourodev
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text.Trim();
            string cadena_inv = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            { 
                cadena_inv += cadena[i];
            }

            if (cadena_inv == cadena)
            {
                MessageBox.Show("Son palíndromos!", "YAY!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No son palíndromos...", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
