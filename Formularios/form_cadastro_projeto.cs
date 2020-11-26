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
    public partial class form_cadastro_projeto : Form
    {
        public form_cadastro_projeto()
        {
            InitializeComponent();
        }

        private void form_cadastro_projeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void form_cadastro_projeto_Load(object sender, EventArgs e)
        {
            ToolTip tool_sigla  = new ToolTip();
            ToolTip tool_tipo = new ToolTip();


            tool_sigla.ToolTipIcon = ToolTipIcon.Info;
            tool_sigla.ToolTipTitle = "Sigla";
            tool_sigla.IsBalloon = true;
            tool_sigla.ShowAlways = true;
            tool_sigla.AutoPopDelay = 3300;
            tool_sigla.InitialDelay = 50;
            //tool_sigla.ReshowDelay = 200;

            tool_tipo.ToolTipIcon = ToolTipIcon.Info;
            tool_tipo.ToolTipTitle = "Tipo";
            tool_tipo.IsBalloon = true;
            tool_tipo.ShowAlways = true;
            tool_tipo.AutoPopDelay = 3300;
            tool_tipo.InitialDelay = 50;
            //tool_tipo.ReshowDelay = 200;

            tool_sigla.SetToolTip(this.txt_sigla, "Exemplo: 'PL' - Projeto de Lei");
            tool_tipo.SetToolTip(this.txt_tipo, "Exemplo: 'Projeto de Lei'");
        }
    }
}
