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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;
            num1= decimal.Parse(txtNumero1.Text);
            num2 = decimal.Parse(txtNumero2.Text);
            resultado = num1 + num2;
            lblResultado.Text = "Resultado:" + resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;
            num1 = decimal.Parse(txtNumero1.Text);
            num2 = decimal.Parse(txtNumero2.Text);
            resultado = num1 - num2;
            lblResultado.Text = "Resultado:" + resultado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;
            num1 = decimal.Parse(txtNumero1.Text);
            num2 = decimal.Parse(txtNumero2.Text);
            resultado = num1 * num2;
            lblResultado.Text = "Resultado:" + resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal num1, num2, resultado;
            num1 = decimal.Parse(txtNumero1.Text);
            num2 = decimal.Parse(txtNumero2.Text);
            resultado = num1 / num2;
            lblResultado.Text = "Resultado:" + resultado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = double.Parse(txtNumero1.Text);    
            num2 = double.Parse(txtNumero2.Text);
            resultado = Math.Pow(num1, num2);
            lblResultado.Text = "Resultado:" + resultado;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            double num1, num2, resultado;
            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text); 
            if (num2 != 0)
            {  
            resultado = Math.Pow(num1, 1.0 / num2);
            lblResultado.Text = "Resultado:" + resultado;
            }
            else
            {
                lblResultado.Text = "Error: No se puede calcular la raíz de un número con índice 0.";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
