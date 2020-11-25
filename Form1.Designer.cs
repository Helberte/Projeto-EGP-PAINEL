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
            this.bt_novo_participante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_novo_participante
            // 
            this.bt_novo_participante.Location = new System.Drawing.Point(39, 38);
            this.bt_novo_participante.Name = "bt_novo_participante";
            this.bt_novo_participante.Size = new System.Drawing.Size(163, 43);
            this.bt_novo_participante.TabIndex = 0;
            this.bt_novo_participante.Text = "Novo participante";
            this.bt_novo_participante.UseVisualStyleBackColor = true;
            this.bt_novo_participante.Click += new System.EventHandler(this.bt_novo_participante_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_novo_participante);
            this.KeyPreview = true;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EGP PAINEL ";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_principal_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_novo_participante;
    }
}

