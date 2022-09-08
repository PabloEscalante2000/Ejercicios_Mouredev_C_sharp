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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            //Creando la lista
            List<Object> list = new List<Object>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 & i % 3 == 0)
                {
                    list.Add("FIZZBUZZ");
                }
                else if (i % 5 == 0)
                {
                    list.Add("BUZZ");
                }
                else if (i % 3 == 0)
                {
                    list.Add("FIZZ");
                }
                else
                {
                    list.Add(i);
                }
            }

            lstNumeros.DataSource = list;
        }
    }
}
