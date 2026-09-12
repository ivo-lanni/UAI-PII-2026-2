using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form1 : Form
    {
        private IContainer components = null;
        private Label labelBienvenida;
        private NumericUpDown nudCantidad;
        private ListBox ltbFibonacci;
        private Timer timer1;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.components = new Container();
            this.labelBienvenida = new Label();
            this.nudCantidad = new NumericUpDown();
            this.ltbFibonacci = new ListBox();
            this.timer1 = new Timer(this.components);
            this.btnCalcular = new Button();

            // Propiedades mínimas para que compile (ajusta según necesites)
            ((ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();

            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Location = new Point(12, 9);

            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Location = new Point(12, 40);

            this.ltbFibonacci.Name = "ltbFibonacci";
            this.ltbFibonacci.Location = new Point(12, 80);

            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Location = new Point(120, 40);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            this.timer1.Tick += new EventHandler(this.timer1_Tick);

            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.ltbFibonacci);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";

            ((ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string mensaje = "Bienvenido a la aplicación";
        private int posicion = 0;
        private Color[] colores = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Orange };
        private int posicionColor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad;
            int primero = 0;
            int segundo = 1;
            int siguiente;
            cantidad = (int)nudCantidad.Value;
            ltbFibonacci.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (i == 0)
                {
                    siguiente = primero;
                }
                else if (i == 1)
                {
                    siguiente = segundo;
                }
                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                }
                ltbFibonacci.Items.Add(siguiente);
            }
        }

        private void ltbFibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if  (posicion < mensaje.Length)
            {
                labelBienvenida.Text += mensaje[posicion];
                posicion++;

                labelBienvenida.ForeColor = colores[posicionColor];

                posicionColor++;

                if (posicionColor == colores.Length)
                {
                    posicionColor = 0;
                }
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
