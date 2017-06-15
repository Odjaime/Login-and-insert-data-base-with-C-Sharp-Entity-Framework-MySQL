using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginTeste.Models;

namespace LoginTeste.Controllers
{
    class Login
    {
        public bool entrar (string login, string senha)
        {
            var db = new DadosModelo();

            var usuario = db.user.FirstOrDefault(u => u.nome == login && u.senha == senha);

            if(usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        } 
    }
}
