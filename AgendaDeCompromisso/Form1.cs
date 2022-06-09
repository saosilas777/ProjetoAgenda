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

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Necessário realizar um Login");
                return;
            }

            string dia = textBox1.Text;
            string ano = textBox2.Text;

            if (Cadastros.Login(dia, ano))
            {
                List<Cliente> client = new List<Cliente>();


                client.Add(new Cliente(030820, "HELLWIG MATERIAIS DE CONSTRUCAO LTDA", "5332215615", "53991232384", "megafixadores@gmail.com"));
                client.Add(new Cliente(024072, "I D ALVES", "86 30257897", "86988791492", "kopaf.parafusos@hotmail.com"));
                client.Add(new Cliente(024072, "I D ALVES", "86 30257897", "86988791492", "kopaf.parafusos@hotmail.com"));
                client.Add(new Cliente(0002340, "IVAN MACHADO & CIA. LTDA.", "81 34422943", "81 34311185", "norte_parafusos@outlook.com"));

                foreach (Cliente x in client)
                {
                    ListBox1.Items.Add(x.Codigo.ToString() + ", " + x.Razao.ToString() + " - (" + x.Telefone.ToString() + ")");
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                AcessoNegado acesso = new AcessoNegado();
                acesso.ShowDialog();
               
            }
            textBox1.Focus();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnLogar.Focus();
            }
        }
    }
}
