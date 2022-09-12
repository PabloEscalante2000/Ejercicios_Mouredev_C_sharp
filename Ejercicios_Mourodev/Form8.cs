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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            List<char> ch = new List<char> { '(' , ')' , '.' , ' ' , '-' , ',' , ';', '[' , ']' , '{' , '}' };
            List<string> lista = new List<string>();

            string texto = txtTexto.Text.Trim();

            string nom = "";

            foreach (char i in texto)
            {
                if (ch.Contains(i) & nom == String.Empty)
                {
                    continue;
                }
                else if (ch.Contains(i) & nom != String.Empty)
                {
                    lista.Add(nom);
                    Console.WriteLine(nom);
                    nom = "";
                }
                else if (!ch.Contains(i))
                { 
                    nom += i;
                }
            }

            if (nom != String.Empty)
            {
                lista.Add(nom);
            }

            var data = lista.GroupBy(x => x).Select(x => new { Element = x.Key, Count = x.Count() }).ToList();

            List<string> result = new List<string>();

            foreach (var i in data)
            {
                result.Add(i.Element + " -> " + i.Count);
            }

            lstPalabras.DataSource = result;
        }
    }
}
