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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            var res = (int)Math.Abs(dtpFecha1.Value.Day - dtpFecha2.Value.Day);

            lblResultado.Text = res.ToString();
        }
    }
}
