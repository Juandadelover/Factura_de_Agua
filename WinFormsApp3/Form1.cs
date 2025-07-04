namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupResultadoFactura.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int estrato;
            double consumo;


            if (!int.TryParse(txtEstrato.Text, out estrato) || !double.TryParse(txtConsumo.Text, out consumo))
            {
                MessageBox.Show("Por favor ingrese datos válidos.");
                return;
            }

            double cargoFijo = 0, valorM3 = 0, basuras = 0;


            switch (estrato)
            {
                case 1:
                    cargoFijo = 2500;
                    valorM3 = 2200;
                    basuras = 5500;
                    break;
                case 2:
                    cargoFijo = 2800;
                    valorM3 = 2350;
                    basuras = 6200;
                    break;
                case 3:
                    cargoFijo = 3000;
                    valorM3 = 2600;
                    basuras = 7400;
                    break;
                case 4:
                    cargoFijo = 3300;
                    valorM3 = 3400;
                    basuras = 8600;
                    break;
                case 5:
                    cargoFijo = 3700;
                    valorM3 = 3900;
                    basuras = 9700;
                    break;
                case 6:
                    cargoFijo = 4400;
                    valorM3 = 4800;
                    basuras = 11000;
                    break;
                default:
                    MessageBox.Show("Estrato fuera de rango (1 a 6).");
                    return;
            }


            double valorConsumo = consumo * valorM3;
            double totalPagar = cargoFijo + valorConsumo + basuras;

            // Mostrar resultados en los labels
            lblCargoFijoValor.Text = "$" + cargoFijo.ToString("N0");
            lblValorConsumoValor.Text = "$" + valorConsumo.ToString("N0");
            lblBasurasValor.Text = "$" + basuras.ToString("N0");
            lblTotalValor.Text = "$" + totalPagar.ToString("N0");
            groupResultadoFactura.Visible = true;
        }

        private void lblValorConsumoValor_Click(object sender, EventArgs e)
        {

        }

        private void lblCargoFijoValor_Click(object sender, EventArgs e)
        {

        }

        private void lblBasurasValor_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
