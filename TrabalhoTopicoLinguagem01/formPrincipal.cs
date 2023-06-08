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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroProdutos formCadastroProdutos = new formCadastroProdutos();
            formCadastroProdutos.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formListaProdutos formListaProdutos = new formListaProdutos();
            formListaProdutos.ShowDialog();
        }
        
private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
                
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaUsuarios formListaUsuarios = new formListaUsuarios();
            formListaUsuarios.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroUsuarios formCadastroUsuarios = new formCadastroUsuarios();
            formCadastroUsuarios.ShowDialog();
        }
    }
}
