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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            

            // Otorgando propiedades al combo box
            List<string> list = new List<string>();
            list.Add("run");
            list.Add("jump");            
            cbMovimiento.DataSource = list;
            cbMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;

            // Generar carrera
            lblCarrera.Text = Generar_Carrera();
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            lstMovimientos.Items.Add(cbMovimiento.SelectedItem.ToString());
        }

        string Generar_Carrera()
        {
            string carrera = "";
            Random random = new Random();
            int cont = (int)(random.NextDouble() * 30);

            for (int i = 0; i <= cont; i++)
            {
                if (random.NextDouble() > 0.5)
                {
                    carrera += "_ ";
                }
                else
                {
                    carrera += "| ";
                }
            }

            return carrera;
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            lblCarrera.Text = Generar_Carrera();
            lblResultado.Text = "          ";
            lstMovimientos.Items.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstMovimientos.Items.Clear();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            string carrera = lblCarrera.Text.Replace(" ", "");

            List<string> lista = new List<string>();

            string resultado = "";
            int errores = 0;

            foreach (string i in lstMovimientos.Items)
            { 
                lista.Add(i);
            }

            for (int i = 0; i < Math.Min(lista.Count,carrera.Length); i++)
            {
                Console.WriteLine(i);

                if (lista.ElementAt(i) == "run" & carrera[i].Equals('_'))
                {
                    resultado += "_ ";
                }
                else if (lista.ElementAt(i) == "run" & carrera[i].Equals('|'))
                {
                    resultado += "/ ";
                    errores++;
                }
                else if (lista.ElementAt(i) == "jump" & carrera[i].Equals('|'))
                {
                    resultado += "| ";
                }
                else if (lista.ElementAt(i) == "jump" & carrera[i].Equals('_'))
                { 
                    resultado += "x ";
                    errores++;
                }
            }

            if (resultado.Length/2 < carrera.Length)
            {
                MessageBox.Show("No pudiste completar la carrera!, y además tuviste: " + errores + " errores", "Sorryyyy!");
            }
            else
            {
                MessageBox.Show("Completaste la carrera!, obteniendo: " + errores + " errores", "Yupi!!");
            }

            lblResultado.Text = resultado;
        }
    }
}
