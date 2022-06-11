using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeCompromisso
{
    class Cliente
    {
        private int Codigo { get; set; }
        private string Razao { get; set; }
        private string Telefone { get; set; }
        private string Whatsapp { get; set; }
        private string Email { get; set; }
        

        public Cliente(int codigo, string razao, string telefone, string whatsapp, string email)
        {
            Codigo = codigo;
            Razao = razao;
            Telefone = telefone;
            Whatsapp = whatsapp;
            Email = email;

        }

        public override string ToString()
        {
            return "Id: " + Codigo + ", Razão: " + Razao;
        }


    }
}
