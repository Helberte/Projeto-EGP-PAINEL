using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Formularios;

namespace EGP_PAINEL
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void Form_principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Deseja realmente sair do EGP?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }           
        }

        private void bt_novo_participante_Click(object sender, EventArgs e)
        {
            form_cadastro_participante frm_cad_participante = new form_cadastro_participante();
            frm_cad_participante.ShowDialog();
        }
    }
}
