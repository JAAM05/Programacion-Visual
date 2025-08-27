namespace ContadorClic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            count++;
            textBox1.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
