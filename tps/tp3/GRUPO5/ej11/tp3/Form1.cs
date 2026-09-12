namespace tp3
{
    public partial class Form1 : Form
    {
        private void Jugar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (boton.Text == "")
            {
                if (turnoX)
                {
                    boton.Text = "X";
                    lblTurno.Text = "Turno: O";
                }
                else
                {
                    boton.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }
        private void VerificarGanador()
        {
            string ganador = "";
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
                ganador = button1.Text;
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text) ganador = button4.Text;
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text) ganador = button7.Text;
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text) ganador = button1.Text;
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text) ganador = button2.Text;
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text) ganador = button3.Text;
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text) ganador = button3.Text;
            if (ganador != "")
            {
                MessageBox.Show("Ganó " + ganador);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTurno.Text = "Turno X";
        }
        bool turnoX = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turnoX)
                {
                    button1.Text = "X";
                    lblTurno.Text = "turno O";
                }
                else
                {
                    button1.Text = "O";
                    lblTurno.Text = "Turno: X";
                }
                turnoX = !turnoX;
                VerificarGanador();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            turnoX = true;
            lblTurno.Text = "Turno: X";

        }
    }
    }

