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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string cadena1 = txtUno.Text.Trim();
            string cadena2 = txtDos.Text.Trim();

            string cade1_sin2 = cadena_concatenada(cadena1,cadena2);
            string cade2_sin1 = cadena_concatenada(cadena2,cadena1);

            lblUnoSinDos.Text = cade1_sin2;
            lblDosSinUno.Text = cade2_sin1;
        }

        string cadena_concatenada(string cad1, string cad2) 
        {
            string res = "";

            foreach (char c in cad1)
            {
                if (!cad2.Contains(c))
                { 
                    res += c;
                }
            }

            return res;
        }
    }
}
