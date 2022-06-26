namespace CafeMgmtTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            if (zeroitLollipopTextBox1.PasswordChar == '*')
            {
                zeroitLollipopTextBox1.PasswordChar = '\0';
                pbShowPass.Image = Properties.Resources.close;
            }
            else
            {
                zeroitLollipopTextBox1.PasswordChar = '*';
                pbShowPass.Image = Properties.Resources.open;
            }
        }
    }
}