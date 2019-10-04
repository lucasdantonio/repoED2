namespace projFilaAtendimento {
    partial class FormAtendimento {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonAdicionarGuiche = new System.Windows.Forms.Button();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.labelTituloQuantidadeGuiches = new System.Windows.Forms.Label();
            this.labelQuantidadeGuiches = new System.Windows.Forms.Label();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.listBoxAtendimentos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(93, 30);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(72, 291);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(130, 23);
            this.buttonListarSenhas.TabIndex = 1;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.ButtonListarSenhas_Click);
            // 
            // buttonAdicionarGuiche
            // 
            this.buttonAdicionarGuiche.Location = new System.Drawing.Point(265, 158);
            this.buttonAdicionarGuiche.Name = "buttonAdicionarGuiche";
            this.buttonAdicionarGuiche.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarGuiche.TabIndex = 2;
            this.buttonAdicionarGuiche.Text = "Adicionar";
            this.buttonAdicionarGuiche.UseVisualStyleBackColor = true;
            this.buttonAdicionarGuiche.Click += new System.EventHandler(this.ButtonAdicionarGuiche_Click);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(522, 30);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(93, 23);
            this.buttonChamar.TabIndex = 3;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.ButtonChamar_Click);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(455, 291);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(160, 23);
            this.buttonListarAtendimentos.TabIndex = 4;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.ButtonListarAtendimentos_Click);
            // 
            // labelTituloQuantidadeGuiches
            // 
            this.labelTituloQuantidadeGuiches.AllowDrop = true;
            this.labelTituloQuantidadeGuiches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTituloQuantidadeGuiches.Location = new System.Drawing.Point(263, 31);
            this.labelTituloQuantidadeGuiches.Name = "labelTituloQuantidadeGuiches";
            this.labelTituloQuantidadeGuiches.Size = new System.Drawing.Size(78, 86);
            this.labelTituloQuantidadeGuiches.TabIndex = 5;
            this.labelTituloQuantidadeGuiches.Text = "Quantidade Guichês";
            this.labelTituloQuantidadeGuiches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantidadeGuiches
            // 
            this.labelQuantidadeGuiches.AutoSize = true;
            this.labelQuantidadeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeGuiches.Location = new System.Drawing.Point(292, 112);
            this.labelQuantidadeGuiches.Name = "labelQuantidadeGuiches";
            this.labelQuantidadeGuiches.Size = new System.Drawing.Size(24, 26);
            this.labelQuantidadeGuiches.TabIndex = 6;
            this.labelQuantidadeGuiches.Text = "0";
            // 
            // labelGuiche
            // 
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Location = new System.Drawing.Point(407, 35);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(44, 13);
            this.labelGuiche.TabIndex = 7;
            this.labelGuiche.Text = "Guiche:";
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(458, 32);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(58, 20);
            this.textBoxGuiche.TabIndex = 8;
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.Location = new System.Drawing.Point(12, 62);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(245, 212);
            this.listBoxSenhas.TabIndex = 9;
            // 
            // listBoxAtendimentos
            // 
            this.listBoxAtendimentos.FormattingEnabled = true;
            this.listBoxAtendimentos.Location = new System.Drawing.Point(347, 62);
            this.listBoxAtendimentos.Name = "listBoxAtendimentos";
            this.listBoxAtendimentos.Size = new System.Drawing.Size(343, 212);
            this.listBoxAtendimentos.TabIndex = 10;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 326);
            this.Controls.Add(this.listBoxAtendimentos);
            this.Controls.Add(this.listBoxSenhas);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.labelQuantidadeGuiches);
            this.Controls.Add(this.labelTituloQuantidadeGuiches);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.buttonAdicionarGuiche);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonGerar);
            this.Name = "FormAtendimento";
            this.Text = "Gerenciador de Atendimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonAdicionarGuiche;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Button buttonListarAtendimentos;
        private System.Windows.Forms.Label labelTituloQuantidadeGuiches;
        private System.Windows.Forms.Label labelQuantidadeGuiches;
        private System.Windows.Forms.Label labelGuiche;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.ListBox listBoxAtendimentos;
    }
}

