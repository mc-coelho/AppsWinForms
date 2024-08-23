namespace trocaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string a = TxtValor1.Text;
            TxtValor1.Text = TxtValor2.Text;
            TxtValor2.Text = a;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
