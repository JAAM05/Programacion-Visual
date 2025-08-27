namespace LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;
            if(username == "Jeremy" && password == "2005")
            {
                MessageBox.Show("Login Sucess","info",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login Error");
            }
        }
    }
}
