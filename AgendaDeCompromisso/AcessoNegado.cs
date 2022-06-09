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
    public partial class AcessoNegado : Form
    {
        public AcessoNegado()
        {
            InitializeComponent();
        }

        private void AcessoNegado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }

        }
    }
}
