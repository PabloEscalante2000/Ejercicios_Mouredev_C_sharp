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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int mi_decimal = int.Parse(txtNumber.Text.Trim());

            txtResult.Text = ""+dec_bin(mi_decimal);


        }

        int dec_bin(int a)
        {
            int res = 0;
            double count = 0;

            while (true)
            {
                if (a == 0 | a == 1)
                {
                    res = (int)(res + (a % 2) * Math.Pow(10, count));
                    break;
                }
                else if (a % 2 == 0)
                {
                    a = a / 2;
                    count++;
                }
                else if (a % 2 == 1)
                {
                    res = (int)(res + Math.Pow(10, count));
                    a--;
                    a /= 2;
                    count++;
                }
                
            }

            return res;
        }
    }
}
