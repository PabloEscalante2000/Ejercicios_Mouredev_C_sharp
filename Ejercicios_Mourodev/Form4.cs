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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(txtPrimo.Text);

            if (primo(num))
            {
                MessageBox.Show("Es un Primo!!", "ACERTASTE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es un primo, sorry :'v", "UPS!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        bool primo(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else if (num == 2)
            { 
                return true;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    { 
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
