using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_PAINEL.Formularios
{
    public partial class Cadastro_funcoes : Form
    {
        public Cadastro_funcoes()
        {
            InitializeComponent();
        }

        private void Cadastro_funcoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
