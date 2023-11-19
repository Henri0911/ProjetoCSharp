using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if(textLogin.Text == User && textSenha.Text == Password)
            {
                MessageBox.Show("Acesso Autorizado");
                Form2 frMain = new Form2();
                frMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login/Senha Incorreta");
            }
        }
    }
}
