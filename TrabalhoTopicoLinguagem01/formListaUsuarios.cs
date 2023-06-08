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
    public partial class formListaUsuarios : Form
    {
        public formListaUsuarios()
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
            dataGridViewUsuarios.DataSource = new UsuariosDAO().Listar();
        }
    }
}
