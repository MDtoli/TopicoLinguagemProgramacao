using System;
using System.Windows.Forms;

namespace TrabalhoTopicoLinguagem01
{
    public partial class formListaProdutos : Form
    {
        public formListaProdutos()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }                    
        }

        private void buscarButton_Click(object sender, EventArgs e)
        { 
            dataGridView1.DataSource = new ProdutosDAO().Listar2();
        }

        private void botoesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {          
        }
    }
}
