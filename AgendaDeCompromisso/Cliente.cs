using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeCompromisso
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Razao { get; set; } 
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }

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
            return Codigo + " " + Razao + " " + Telefone + " " + Email;
        }
    }
}
