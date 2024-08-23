using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulasWindowsForms
{
    public partial class FrmRestoDaDivisao : Form
    {
        public FrmRestoDaDivisao()
        {
            InitializeComponent();
        }

        private void FrmRestoDivisao_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = Convert.ToInt32(txtDividendo.Text);
                int divisor = Convert.ToInt32(txtDivisor.Text);
                int resto = dividendo % divisor;
                txtResto.Text = resto.ToString();
            }
            catch (FormatException exc)
            {
            MessageBox.Show("Entrada de dados inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            catch (Exception exc)
            {
                MessageBox.Show("Não é possível dividir por zero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
