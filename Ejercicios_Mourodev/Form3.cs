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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<Int32> list = new List<Int32>();

            var i = 0;
            var j = 1;
            var c = 0;

            list.Add(i);
            list.Add(j);

            for (int k = 0; k < 48; k++)
            {
                list.Add(list[list.Count - 1] + list[list.Count - 2]);
            }

            lstFibonacci.DataSource = list;
            Console.WriteLine(list.Count);

        }


    }
}
