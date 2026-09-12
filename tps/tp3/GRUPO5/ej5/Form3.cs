using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nmMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nmmin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int minimo, maximo;
            minimo = (int)Nmmin.Value;
            maximo = (int)nmMax.Value;
            ltbPrimos.Items.Clear();
            for (int numero = minimo; numero <= maximo; numero++)
            {
                int divisores = 0;
                for (int divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 2)
                {
                    ltbPrimos.Items.Add(numero);
                }
            }
        }
        private void ltbPrimos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }
    }
}
