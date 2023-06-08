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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            new UsuariosDAO().Login(textBoxLogin.Text, textBoxSenha.Text);

            if (new UsuariosDAO().Login(textBoxLogin.Text, textBoxSenha.Text) == false) 
            {
                MessageBox.Show("Não foi encontrado o usuário", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("Bem vindo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
