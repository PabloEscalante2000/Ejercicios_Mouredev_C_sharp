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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAnagrama_Click(object sender, EventArgs e)
        {
            double n1,n2;

            if (txtNom1.Text.Trim() == String.Empty | txtNom2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Tiene que ingresarse un nombre en cada casilla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Double.TryParse(txtNom1.Text, out n1) | Double.TryParse(txtNom2.Text, out n2))
            {
                MessageBox.Show("Tiene que ingresar cadenas de texto, NO NUMEROS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                String nom1 = txtNom1.Text.Trim();
                String nom2 = txtNom2.Text.Trim();

                // Se aplica el Anagrama

                if (Anagrama(nom1, nom2))
                {
                    MessageBox.Show("Son anagramas!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No son anagramas...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        bool Anagrama(String nom1, String nom2)
        {
            if (nom1.Length != nom2.Length)
            {
                return false;
            }
            else
            {
                List<Char> list1 = new List<Char>();
                List<Char> list2 = new List<Char>();

                foreach (Char ch in nom1)
                {
                    list1.Add(ch);
                }
                foreach (Char ch in nom2)
                {
                    list2.Add(ch);
                }

                var c = 0;

                while (c < list1.Count)
                {
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (list1[c] == list2[i])
                        {

                            c++;
                            break;
                        }

                        if (i == list2.Count - 1)
                        { 
                            return false;
                        }
                    }
                }

                return true;    
            }
        }
    }
}
