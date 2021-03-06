<<<<<<< HEAD
﻿using System;
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
        form_cadastro_participante frm_cad_participante;
        form_cadastro_funcoes frm_cad_funcoes;
        form_cadastro_de_partido frm_cad_partido;
        Form_principal frm_principal;
        form_cadastro_camara frm_cad_camaras;
        form_cadastro_projeto frm_cad_pauta;
        Form_discusao frm_discusao;

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
        
        private void cadastroDePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_partido = new form_cadastro_de_partido();
            frm_cad_partido.ShowDialog();
        }

        private void cadastroDeFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_funcoes = new form_cadastro_funcoes();
            frm_cad_funcoes.ShowDialog();
        }

        private void cadastroDeParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_participante = new form_cadastro_participante();
            frm_cad_participante.ShowDialog();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            frm_principal = this;
            panel_pauta_hoje.Top = 200;
            panel_pauta_hoje.Left = (frm_principal.Width / 2) - (panel_pauta_hoje.Width / 2);

            lbl_nome_camara.Top = 75;
            lbl_nome_camara.Left = (frm_principal.Width / 2) - (lbl_nome_camara.Width / 2);


            //Panel teste = new Panel();
            //teste.Size = new Size(300, 600);
            //teste.BackColor = Color.Red;
            //teste.Location = new Point(100, this.panel1.Location.Y + this.panel1.Height);
            //this.Controls.Add(teste);
            //this.AutoScroll = true;
        }

        private void cadastroDeCâmarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_camaras = new form_cadastro_camara();
            frm_cad_camaras.ShowDialog();
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_cad_pauta = new form_cadastro_projeto();
            frm_cad_pauta.ShowDialog();
        }

        private void Form_principal_Activated(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_discusao = new Form_discusao();
            frm_discusao.ShowDialog();
        }
    }
}
=======
﻿using System;
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
        form_cadastro_participante frm_cad_participante;
        form_cadastro_funcoes frm_cad_funcoes;
        form_cadastro_de_partido frm_cad_partido;
        Form_principal frm_principal;
        form_cadastro_camara frm_cad_camaras;
        form_cadastro_pauta frm_cad_pauta;

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
        
        private void cadastroDePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_partido = new form_cadastro_de_partido();
            frm_cad_partido.ShowDialog();
        }

        private void cadastroDeFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_funcoes = new form_cadastro_funcoes();
            frm_cad_funcoes.ShowDialog();
        }

        private void cadastroDeParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_participante = new form_cadastro_participante();
            frm_cad_participante.ShowDialog();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            frm_principal = this;
            panel1.Top = 200;
            panel1.Left = (frm_principal.Width / 2) - (panel1.Width / 2);

            lbl_nome_camara.Top = 75;
            lbl_nome_camara.Left = (frm_principal.Width / 2) - (lbl_nome_camara.Width / 2);
        }

        private void cadastroDeCâmarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_camaras = new form_cadastro_camara();
            frm_cad_camaras.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_cad_pauta = new form_cadastro_pauta();
            frm_cad_pauta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> main
