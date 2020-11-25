using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGP_PAINEL.Formularios
{
    public partial class form_cadastro_participante : Form
    {
        form_cadastro_participante frm_cad_participante;
        public form_cadastro_participante()
        {
            InitializeComponent();
            frm_cad_participante = this;
        }

        private void form_cadastro_participante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                frm_cad_participante.Close();
            }           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           //if (char.IsLetter(e.KeyChar))
           // {
           //     e.Handled = true;
           // }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
