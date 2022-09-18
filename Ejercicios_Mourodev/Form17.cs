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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
            txtMay.Enabled = false;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            string res = "";
            
            foreach (char item in txtMin.Text)
            { 
                res += char.ToUpper(item);
            }

            txtMay.Text = res;
        }
    }
}
