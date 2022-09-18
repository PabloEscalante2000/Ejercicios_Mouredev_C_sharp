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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnEquilibrada_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text.Trim();
            List<char> expresionList = new List<char> { '{','}','[',']','(',')'};    
            List<char> llaves = new List<char>();

            foreach (char c in expresion)
            {
                if (expresionList.Contains(c))
                { 
                    llaves.Add(c);
                }
            }

            while (llaves.Count % 2 == 0 & llaves.Count != 0)
            {
                int prob = llaves.Count;
                for (int i = 0; i < llaves.Count-1; i++)
                {
                    if ((llaves[i] == '(' & llaves[i + 1] == ')') | (llaves[i] == '[' & llaves[i + 1] == ']') |
                        (llaves[i] == '{' & llaves[i + 1] == '}'))
                    {
                        llaves.RemoveAt(i);
                        llaves.RemoveAt(i);
                        break;
                    }
                }
                if (prob == llaves.Count)
                { 
                    break;
                }
            }

            if (llaves.Count != 0)
            {
                MessageBox.Show("Expresion No equilibrada", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Expresion equilibrada!!", "YAY!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
