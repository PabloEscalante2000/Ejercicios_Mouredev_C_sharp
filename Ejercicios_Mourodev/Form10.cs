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
    public partial class Form10 : Form
    {
        List<String> abc = new List<String> { "A","B","C","CH","D","E","F","G","H","I","J","K",
        "L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6",
        "7","8","9",".",",","?","\"","/"};

        List<String> abc_morse = new List<String> { "·—", "—···", "—·—·",
        "————","—··",".","··—·","——·","····","··","·———","—·—",
        "·—··","——","—·","——·——","———","·——·","——·—","·—·","···",
        "—","··—","···—","·——","—··—","—·——","——··","—————",
        "·————","··———","···——","····—","·····","—····","——···","———··",
        "————·","·—·—·—","——··——","··——··","·—··—·","—··—·"};

        public Form10()
        {
            InitializeComponent();
        }

        private void btnTransformar_Click(object sender, EventArgs e)
        {
            String palabra = txtTexto.Text.Trim();
            String res = "";

            if (palabra == String.Empty)
            {
                MessageBox.Show("Tienes que ingresar texto");
            }
            else
            {
                foreach (char ch in palabra)
                {
                    if (abc.Contains(Char.ToString(ch)))
                    {
                        int i = abc.IndexOf(Char.ToString(ch));
                        res = res + abc_morse[i] + " ";
                    }
                    else if (ch == ' ')
                    {
                        res += "  ";
                    }
                    else
                    {
                        res += ch;
                    }
                }
            }

            lblMorse.Text = res;

        }
    }
}
