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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No puedes dejar la cadena vacía", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtNombre.Focus();
            }
            else
            {
                lblResul.Text = Invertir(txtNombre.Text.Trim());
                txtNombre.Focus();
                lblResul.ForeColor = Color.BlueViolet;
            }
        }

        string Invertir(string nombre)
        {
            string res = "";

            for (int i = nombre.Length - 1; i >= 0; i--)
            {
                res += nombre[i];
                Console.WriteLine(nombre[i]);
            }

            return res;
        }
    }
}
