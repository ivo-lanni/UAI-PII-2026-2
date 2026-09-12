using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;

            string dato1 = Microsoft.VisualBasic.Interaction.InputBox(
    "Ingrese el primer número",
    "Suma"
);

            string dato2 = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el segundo número",
                "Suma"
            );

            num1 = Decimal.Parse(dato1);
            num2 = Decimal.Parse(dato2);

            resultado = num1 + num2;

            MessageBox.Show("La suma es: " + resultado);
        }
    }
}
