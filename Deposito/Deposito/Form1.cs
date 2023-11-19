using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float valorDepositado = float.Parse(txtValorDeposito.Text);
            float saldoAtual = float.Parse(txtSaldo.Text);
            float novoSaldo = saldoAtual + valorDepositado;

            labelSaldoAntigo.Text = saldoAtual.ToString();
            labelSaldoAtual.Text = novoSaldo.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSaldo.Text = "";
            txtValorDeposito.Text = "";
            labelSaldoAntigo.Text = "---";
            labelSaldoAtual.Text = "---";
        }

    }
}
