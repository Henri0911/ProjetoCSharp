using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, media;

            bool verifica;

            string status;

            verifica = float.TryParse(textNota1.Text, out nota1);
            if(verifica == false)
            {
                MessageBox.Show("Formato de valor inválido no Nota 1");
                return;
            }

            verifica = float.TryParse(textNota2.Text, out nota2);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido no Nota 2");
                return;
            }

            verifica = float.TryParse(textNota3.Text, out nota3);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido no Nota 3");
                return;
            }

            verifica = float.TryParse(textNota4.Text, out nota4);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido no Nota 4");
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(media >= 6)
            {
                status = "Aluno aprovado!!!";
            }
            else
            {
                status = "Aluno reprovado!!!";
            }

            mediaNotas.Text = string.Format("Média: {0} - {1}", Math.Round( media, 2), status);
        }

    }
}
