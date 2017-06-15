using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTeste.Controllers;
using LoginTeste.View;

namespace LoginTeste.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var function = new Login();

            string login;
            string senha;

            login = textBox1.Text;
            senha = textBox2.Text;

            if(!function.entrar(login, senha))
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
            else
            {
                this.Visible = false;
                Inicio inicio = new Inicio();
                inicio.ShowDialog();

                
            }
        }
    }
}
