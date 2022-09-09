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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            rbRectángulo.Checked = true;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (txtAlto.Enabled)
            {
                if (rbTriangulo.Checked)
                {
                    double res = area(double.Parse(txtAlto.Text), double.Parse(txtAncho.Text), 0);
                    MessageBox.Show("El area del triángulo es: " + res, "AREA DE TRIANGULO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    double res = area(double.Parse(txtAlto.Text), double.Parse(txtAncho.Text), 1);
                    MessageBox.Show("El area del rectángulo es: " + res, "AREA DE RECTÁNGULO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                double res = area(double.Parse(txtAncho.Text), -1, 0);
                MessageBox.Show("El area del cuadrado es: " + res, "AREA DE CUADRADO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        double area(double a, double b, int i)
        {
            if (b == -1)
            {
                return a * a;
            }
            else if (i == 1)
            {
                return b * a;
            }
            else
            { 
                return (b*a)/2;
            }
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblAlto.Text = "Alto: ";
            lblAncho.Text = "Ancho: ";
            txtAlto.Enabled = true;
        }

        private void rbRectángulo_CheckedChanged(object sender, EventArgs e)
        {
            lblAlto.Text = "Alto: ";
            lblAncho.Text = "Ancho: ";
            txtAlto.Enabled = true;
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        { 
            lblAlto.Text = "-";
            lblAncho.Text = "Lado";
            txtAlto.Enabled = false;
        }
    }
}
