using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTeste.View;
using MySql.Data.MySqlClient;

namespace LoginTeste
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm logar = new LoginForm();
            if(logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new View.Inicio());
            }

        }
    }
}
