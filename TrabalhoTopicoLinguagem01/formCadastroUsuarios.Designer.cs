namespace TrabalhoTopicoLinguagem01
{
    partial class formCadastroUsuarios
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxTipoUsuario = new System.Windows.Forms.TextBox();
            this.labelTipoUsuario = new System.Windows.Forms.Label();
            this.botoesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Alterar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(100, 328);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(74, 36);
            this.buttonEditar.TabIndex = 21;
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
            this.buttonInserir.Location = new System.Drawing.Point(8, 328);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(74, 36);
            this.buttonInserir.TabIndex = 20;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.fecharButton);
            this.botoesPanel.Controls.Add(this.alterarButton);
            this.botoesPanel.Controls.Add(this.excluirButton);
            this.botoesPanel.Controls.Add(this.novoButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(528, 0);
            this.botoesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(445, 374);
            this.botoesPanel.TabIndex = 19;
            // 
            // fecharButton
            // 
            this.fecharButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fecharButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Excluir;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(332, 326);
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
            this.alterarButton.Enabled = false;
            this.alterarButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Alterar;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(224, 328);
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
            this.excluirButton.Enabled = false;
            this.excluirButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Excluir2;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(116, 328);
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
            this.novoButton.Enabled = false;
            this.novoButton.Image = global::TrabalhoTopicoLinguagem01.Properties.Resources.Novo;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(8, 328);
            this.novoButton.Margin = new System.Windows.Forms.Padding(4);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(100, 36);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "Novo";
            this.novoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Location = new System.Drawing.Point(19, 191);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(415, 22);
            this.textBoxSenha.TabIndex = 18;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(15, 171);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(46, 16);
            this.labelSenha.TabIndex = 17;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxNome
            // 
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(20, 82);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(415, 22);
            this.textBoxNome.TabIndex = 16;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(16, 62);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Nome";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(20, 137);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(415, 22);
            this.textBoxLogin.TabIndex = 14;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(16, 118);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 16);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(20, 27);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(415, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(16, 7);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "Id";
            // 
            // textBoxTipoUsuario
            // 
            this.textBoxTipoUsuario.Enabled = false;
            this.textBoxTipoUsuario.Location = new System.Drawing.Point(20, 256);
            this.textBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTipoUsuario.Name = "textBoxTipoUsuario";
            this.textBoxTipoUsuario.Size = new System.Drawing.Size(415, 22);
            this.textBoxTipoUsuario.TabIndex = 23;
            // 
            // labelTipoUsuario
            // 
            this.labelTipoUsuario.AutoSize = true;
            this.labelTipoUsuario.Location = new System.Drawing.Point(16, 236);
            this.labelTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoUsuario.Name = "labelTipoUsuario";
            this.labelTipoUsuario.Size = new System.Drawing.Size(82, 16);
            this.labelTipoUsuario.TabIndex = 22;
            this.labelTipoUsuario.Text = "Tipo usuário";
            // 
            // formCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 374);
            this.Controls.Add(this.textBoxTipoUsuario);
            this.Controls.Add(this.labelTipoUsuario);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.botoesPanel);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Name = "formCadastroUsuarios";
            this.Text = "Cadastro usuários";
            this.botoesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxTipoUsuario;
        private System.Windows.Forms.Label labelTipoUsuario;
    }
}