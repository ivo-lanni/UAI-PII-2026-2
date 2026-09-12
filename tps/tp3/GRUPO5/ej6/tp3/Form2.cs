using System;
using System.Drawing;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form2 : Form
    {
        string mensaje = "¡Bienvenido a Fibonacci!";
        int posicion = 0;

        Color[] colores =
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Orange,
            Color.Purple
        };

        int posicionColor = 0;


        public Form2()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (posicion < mensaje.Length)
            {
                labelBienvenida.Text += mensaje[posicion];
                posicion++;
            }

            labelBienvenida.ForeColor = colores[posicionColor];

            posicionColor++;

            if (posicionColor == colores.Length)
            {
                posicionColor = 0;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            int cantidad;
            int primero = 0;
            int segundo = 1;
            int siguiente;

            cantidad = (int)nudCantidad.Value;

            ltbFibonacci.Items.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                ltbFibonacci.Items.Add(primero);

                siguiente = primero + segundo;
                primero = segundo;
                segundo = siguiente;
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            labelBienvenida.Text = "";

            timer1.Interval = 150;

            timer1.Start();
        }


        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ltbFibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}