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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text.Trim());

            int res = Recursividad(num);

            MessageBox.Show("Resultado: " + res, "FACTORIAL", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        int Recursividad(int a)
        {

            int res = 1;

            if (a != 1)
            {
                res = a * Recursividad(a - 1);
            }

            return res;
        }
    }
}
