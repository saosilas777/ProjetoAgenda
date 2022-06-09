using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeCompromisso
{
    static class Cadastros
    {

        private static User[] users =
        {
            new User(){Login = "22" , Senha = "1987"},
            new User(){Login = "16", Senha = "1993"}

        };
        private static User  UserLogado = null;

        public static User UsuarioLogado
        {
            get { return UserLogado; }
            private set {UserLogado = value;}

        }

        public static bool Login(string dia, string ano)
        {
            foreach(User x in users)
            {
                if(x.Login == dia && x.Senha == ano)
                {
                    UserLogado = x;
                    return true;
                }
            }

            return false;
        }
    }
}
