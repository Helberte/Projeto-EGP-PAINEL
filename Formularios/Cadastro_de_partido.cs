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
    public partial class Cadastro_de_partido : Form
    {
        public Cadastro_de_partido()
        {
            InitializeComponent();
        }

        private void Cadastro_de_partido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {

                pictureBox_partido.SizeMode = PictureBoxSizeMode.StretchImage;

                open.InitialDirectory = "C:\\";

                //estudar
                open.Filter = "Tipos |*.png;*.jpg;*.bmp;*.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_partido.ImageLocation = open.FileName;
                }
            }
        }
    }
}
