using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using Image = System.Drawing.Image;

namespace Ejercicios_Mourodev
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            String V = txtImagen.Text.Trim();

            WebClient client = new WebClient();

            Byte[] byteImage = client.DownloadData(V);
            MemoryStream memoryStream = new MemoryStream(byteImage);
            Image image = Image.FromStream(memoryStream);

            Console.WriteLine("alto de imagen: " + image.Height + ", ancho de imagen:" + image.Width);

            int mcd = MCD((int)image.Height, (int)image.Width);

            int h = (int)image.Height / mcd;
            int w = (int)image.Width / mcd;

            MessageBox.Show("La relación entre altura y ancho es: " + h + "/" + w, "Proporcion de imagen", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        int MCD(int a, int b)
        {
            int c = 0;
            if (a >= b)
            {
                c = b;
            }
            else
            {
                c = a;
            }

            int res = 1;

            for (int i = 2; i < c; i++)
            {
                if (a % i == 0 & b % i == 0)
                {
                    do { 
                        res = res * i;
                        a = a/i;
                        b = b/i;
                    }while (a % i == 0 & b % i == 0);
                }
            }

            return res;
        }
    }
}
