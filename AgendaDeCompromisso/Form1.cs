using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeCompromisso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cliente> client = new List<Cliente>();


            client.Add(new Cliente(030820, "HELLWIG MATERIAIS DE CONSTRUCAO LTDA", "5332215615", "53991232384", "megafixadores@gmail.com"));
            client.Add(new Cliente(024072, "I D ALVES", "86 30257897", "86988791492", "kopaf.parafusos@hotmail.com"));
            client.Add(new Cliente(024072, "I D ALVES", "86 30257897", "86988791492", "kopaf.parafusos@hotmail.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));
            client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));

            foreach(Cliente x in client)
            {
               
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
