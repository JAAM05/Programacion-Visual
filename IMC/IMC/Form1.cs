namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double pesoLibras = Convert.ToDouble(tbPesoLibra.Text);
            double alturaPies = Convert.ToDouble(tbAlturaPies.Text);

            double PesoKilo = pesoLibras * 0.453592;

            double alturaMetros = alturaPies * 0.3048;

            double IMC = PesoKilo/(alturaMetros * alturaMetros);

            NotificacionIMC(IMC);

            // IMC = pesoKilo / (AlturaMetros * AlturaMetros)
        }
        public void NotificacionIMC(double IMC)
        {
            if (IMC < 18.5)
            {
                labelIMC.Text = "Bajo de Peso";
            }
            else if (IMC < 24.9)
            {
                labelIMC.Text = "Peso Normal";
            }
            else if (IMC < 29.9)
            {
                labelIMC.Text = "Sobre de Peso";
            }
            else
            {
                labelIMC.Text = "Obesidad";
            };
        }
    }
}
