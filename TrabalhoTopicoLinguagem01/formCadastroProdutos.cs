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
    public partial class formCadastroProdutos : Form
    {
        public formCadastroProdutos()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            new ProdutosDAO().Adicionar2(textBoxNome.Text, int.Parse(textBoxCategoria.Text), double.Parse(textBoxQuantidade.Text));

            MessageBox.Show("O produto foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxCategoria.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            new ProdutosDAO().Excluir2(int.Parse(textBoxId.Text));

            MessageBox.Show("O produto foi deletado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxCategoria.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            new ProdutosDAO().Atualizar2(int.Parse(textBoxId.Text), textBoxNome.Text, textBoxCategoria.Text, double.Parse(textBoxQuantidade.Text));

            MessageBox.Show("O produto foi alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxCategoria.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {   
                labelId.Visible = false;
                textBoxId.Visible = false;
                textBoxNome.Enabled = true;
                textBoxCategoria.Enabled = true;
                textBoxQuantidade.Enabled = true;
            }
            else
            {
                labelId.Visible = true;
                textBoxId.Visible = true;
                textBoxNome.Enabled = false;
                textBoxCategoria.Enabled = false;
                textBoxQuantidade.Enabled = false;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja editar um produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                labelId.Visible = true;
                textBoxId.Visible = true;
                textBoxId.Enabled = true;
                textBoxNome.Enabled = true;
                textBoxCategoria.Enabled = true;
                textBoxQuantidade.Enabled = true;
            }
            else
            {
                textBoxId.Enabled = false;
                textBoxNome.Enabled = false;
                textBoxCategoria.Enabled = false;
                textBoxQuantidade.Enabled = false;
            }

        }
    }
}
