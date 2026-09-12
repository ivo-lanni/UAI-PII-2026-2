namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboInicial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            { 
            double valorInicial;
            double celsius = 0;
            double resultado = 0;

            valorInicial = Double.Parse(txtTemperatura.Text);

            string escalaInicial = cboInicial.Text;
            string escalaFinal = cboFinal.Text;


            if (escalaInicial == "Celsius")
            {
                celsius = valorInicial;
            }
            else if (escalaInicial == "Fahrenheit")
            {
                celsius = (valorInicial - 32) * 5 / 9;
            }
            else if (escalaInicial == "Kelvin")
            {
                celsius = valorInicial - 273.15;
            }
            else if (escalaInicial == "Rankine")
            {
                celsius = (valorInicial - 491.67) * 5 / 9;
            }



            if (escalaFinal == "Celsius")
            {
                resultado = celsius;
            }
            else if (escalaFinal == "Fahrenheit")
            {
                resultado = (celsius * 9 / 5) + 32;
            }
            else if (escalaFinal == "Kelvin")
            {
                resultado = celsius + 273.15;
            }
            else if (escalaFinal == "Rankine")
            {
                resultado = (celsius + 273.15) * 9 / 5;
            }



            dgvConversiones.Rows.Add(
                valorInicial,
                escalaInicial,
                escalaFinal,
                resultado.ToString("0.00")
            );
        }
        
        }

        private void dgvConversiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
