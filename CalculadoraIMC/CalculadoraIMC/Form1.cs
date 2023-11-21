using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            float altura, peso, media;
            bool verifica;

            verifica = float.TryParse(textAltura.Text, out altura);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na Altura.");
                return;
            }
            verifica = float.TryParse(textPeso.Text, out peso);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na Peso.");
                return;
            }

            altura = float.Parse(textAltura.Text);

            peso = float.Parse(textPeso.Text);

            media = peso / (altura * altura);

            labelResultado.Text = string.Format("IMC: {0}", Math.Round(media, 2));

            if (media < 17)
            {
                labelMensagem.Text = string.Format("Muito abaixo do peso");
            }
            else if (media >= 17 && media < 18.49) 
            {
                labelMensagem.Text = string.Format("Abaixo do peso");
            }
            else if (media >= 18.50 && media < 24.99)
            {
                labelMensagem.Text = string.Format("Peso normal");
            }
            else if (media >= 25 && media < 29.99)
            {
                labelMensagem.Text = string.Format("Acima do peso");
            }
            else if (media >= 30 && media < 34.99)
            {
                labelMensagem.Text = string.Format("Obesidade grau I");
            }
            else if (media >= 35 && media < 40)
            {
                labelMensagem.Text = string.Format("Obesidade grau II");
            }
            else
            {
                labelMensagem.Text = string.Format("Obesidade grau III");
            }

        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textAltura.Text = "";
            textPeso.Text = "";
            labelResultado.Text = "---";
            labelMensagem.Text = "---";
        }
    }
}
