namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.gradoscent.Text);
            float fahr = (cent * 9 / 5) + 32;
            this.resultado.Text = fahr.ToString();
        }
    }
}
