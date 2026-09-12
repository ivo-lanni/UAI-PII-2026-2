namespace tp3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[] cantidades = new int[7];
        int totalResultados= 0;

        public Form1()
        {
            InitializeComponent(GetLblDado11());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDado.Rows.Clear();

            for (int numero = 1; numero <= 6; numero++)
            {
                dgvDado.Rows.Add(numero, 0, "0%");
            }
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            int dado1, dado2;

            dado1 = random.Next(1, 7);
            dado2 = random.Next(1, 7);


            cantidades[dado1]++;
            cantidades[dado2]++;
            totalResultados = totalResultados + 2;

            
            dgvDado.Rows.Clear();

            for (int numero = 1; numero <= 6; numero++)
            {
                double porcentaje;

                porcentaje =
                    (double)cantidades[numero] / totalResultados * 100;

                dgvDado.Rows.Add(
                    numero,
                    cantidades[numero],
                    porcentaje.ToString("0.00") + "%"
                );
            }
        }

        private void dgvDado_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }
}