using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTopicoLinguagem01
{
    public partial class formCadastroUsuarios : Form
    {
        public formCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                labelId.Visible = false;
                textBoxId.Visible = false;
                textBoxNome.Enabled = true;
                textBoxLogin.Enabled = true;
                textBoxSenha.Enabled = true;
                textBoxTipoUsuario.Enabled = true;

                novoButton.Enabled = true;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar um novo usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                labelId.Visible = true;
                textBoxId.Visible = true;
                textBoxId.Enabled = true;
                textBoxNome.Enabled = true;
                textBoxLogin.Enabled = true;
                textBoxSenha.Enabled = true;
                textBoxTipoUsuario.Enabled = true;

                excluirButton.Enabled = true;
                alterarButton.Enabled = true;
            }
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new UsuariosDAO().Adicionar(textBoxNome.Text, textBoxLogin.Text, textBoxSenha.Text, int.Parse(textBoxTipoUsuario.Text));

            MessageBox.Show("O usuário foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxSenha.Text = string.Empty;
            textBoxTipoUsuario.Text = string.Empty;

            novoButton.Enabled = false;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            new UsuariosDAO().Excluir(int.Parse(textBoxId.Text));

            MessageBox.Show("O usuário foi deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxSenha.Text = string.Empty;
            textBoxTipoUsuario.Text = string.Empty;

            excluirButton.Enabled = false;
            alterarButton.Enabled = false;
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            new UsuariosDAO().Atualizar(int.Parse(textBoxId.Text), textBoxNome.Text, textBoxLogin.Text, textBoxSenha.Text, int.Parse(textBoxTipoUsuario.Text));

            MessageBox.Show("O usuário foi alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxSenha.Text = string.Empty;
            textBoxTipoUsuario.Text = string.Empty;

            excluirButton.Enabled = false;
            alterarButton.Enabled = false;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
