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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnArmostrong_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text.Trim());
            int sum = 0;

            foreach (char c in txtNum.Text.Trim())
            {
                sum += (int)Math.Pow(int.Parse(Char.ToString(c)), 3);
            }

            if (num == sum)
            {
                MessageBox.Show("Es un número de Armostrong!", "YAY!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es un número de Armostrong...", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
