namespace EGP_PAINEL
{
    partial class Form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCâmarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_nome_camara = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePartidosToolStripMenuItem,
            this.cadastroDeFunçõesToolStripMenuItem,
            this.cadastroDeParticipantesToolStripMenuItem,
            this.cadastroDeCâmarasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDePartidosToolStripMenuItem
            // 
            this.cadastroDePartidosToolStripMenuItem.Name = "cadastroDePartidosToolStripMenuItem";
            this.cadastroDePartidosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDePartidosToolStripMenuItem.Text = "Cadastro de Partidos";
            this.cadastroDePartidosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDePartidosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePartidosToolStripMenuItem_Click);
            // 
            // cadastroDeFunçõesToolStripMenuItem
            // 
            this.cadastroDeFunçõesToolStripMenuItem.Name = "cadastroDeFunçõesToolStripMenuItem";
            this.cadastroDeFunçõesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeFunçõesToolStripMenuItem.Text = "Cadastro de Funções";
            this.cadastroDeFunçõesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeFunçõesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFunçõesToolStripMenuItem_Click);
            // 
            // cadastroDeParticipantesToolStripMenuItem
            // 
            this.cadastroDeParticipantesToolStripMenuItem.Name = "cadastroDeParticipantesToolStripMenuItem";
            this.cadastroDeParticipantesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeParticipantesToolStripMenuItem.Text = "Cadastro de Participantes";
            this.cadastroDeParticipantesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeParticipantesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeParticipantesToolStripMenuItem_Click);
            // 
            // cadastroDeCâmarasToolStripMenuItem
            // 
            this.cadastroDeCâmarasToolStripMenuItem.Name = "cadastroDeCâmarasToolStripMenuItem";
            this.cadastroDeCâmarasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeCâmarasToolStripMenuItem.Text = "Cadastro de Câmaras";
            this.cadastroDeCâmarasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeCâmarasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCâmarasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_nome_camara);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 698);
            this.panel2.TabIndex = 3;
            // 
            // lbl_nome_camara
            // 
            this.lbl_nome_camara.AutoSize = true;
            this.lbl_nome_camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_camara.Location = new System.Drawing.Point(109, 47);
            this.lbl_nome_camara.Name = "lbl_nome_camara";
            this.lbl_nome_camara.Size = new System.Drawing.Size(600, 42);
            this.lbl_nome_camara.TabIndex = 4;
            this.lbl_nome_camara.Text = "Câmara   Municipal   de   Ji-Paraná";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(30, 192);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(802, 358);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(311, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fazer Leitura da Ata";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inserir Ata";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pauta de hoje  26/11/2020 - Quinta-Feira      Hora: 11:26";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Assunto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(754, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projeto de Lei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(725, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Abrir discussão";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Encerrado";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EGP PAINEL ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_principal_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeParticipantesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_nome_camara;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCâmarasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}

