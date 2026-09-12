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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvPlazofijo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudDias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void lblTasa_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto, tasa, interes, total;
            int dias;
            monto= decimal.Parse(txtMonto.Text);
            tasa = decimal.Parse(txtTasa.Text);
            dias = (int)nudDias.Value;
            interes = monto * tasa * dias / 36500;
            total= monto + interes;
            dgvPlazofijo.Rows.Add(monto, tasa, dias, interes, total);
        }
    }
}
