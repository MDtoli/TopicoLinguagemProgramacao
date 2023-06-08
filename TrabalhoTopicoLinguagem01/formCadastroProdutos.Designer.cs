namespace TrabalhoTopicoLinguagem01
{
    partial class formCadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.botoesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(31, 7);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(35, 27);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(415, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Enabled = false;
            this.textBoxCategoria.Location = new System.Drawing.Point(35, 137);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(415, 22);
            this.textBoxCategoria.TabIndex = 3;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(31, 118);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(66, 16);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria";
            // 
            // textBoxNome
            // 
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(35, 82);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(415, 22);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(31, 62);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Enabled = false;
            this.textBoxQuantidade.Location = new System.Drawing.Point(34, 191);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(415, 22);
            this.textBoxQuantidade.TabIndex = 7;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(30, 171);
            this.labelQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(77, 16);
            this.labelQuantidade.TabIndex = 6;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.fecharButton);
            this.botoesPanel.Controls.Add(this.alterarButton);
            this.botoesPanel.Controls.Add(this.excluirButton);
            this.botoesPanel.Controls.Add(this.novoButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(573, 0);
            this.botoesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(445, 372);
            this.botoesPanel.TabIndex = 8;
            // 
            // fecharButton
            // 
            this.fecharButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fecharButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Excluir;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(332, 324);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(4);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 37);
            this.fecharButton.TabIndex = 6;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alterarButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Alterar;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(224, 326);
            this.alterarButton.Margin = new System.Windows.Forms.Padding(4);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(100, 36);
            this.alterarButton.TabIndex = 5;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Excluir2;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(116, 326);
            this.excluirButton.Margin = new System.Windows.Forms.Padding(4);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(100, 36);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Novo;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(8, 326);
            this.novoButton.Margin = new System.Windows.Forms.Padding(4);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(100, 36);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "Novo";
            this.novoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Alterar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(126, 326);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(74, 36);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Novo;
            this.buttonInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInserir.Location = new System.Drawing.Point(34, 326);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(74, 36);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // formCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 372);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.botoesPanel);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro produtos";
            this.botoesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInserir;
    }
}