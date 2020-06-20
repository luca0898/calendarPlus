using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prototipo.WindowsForm
{
    public partial class frmEsquiceuSenha : Form
    {
        public frmEsquiceuSenha()
        {
            InitializeComponent();
        }

        private void frmEsquiceuSenha_Load(object sender, EventArgs e)
        {
            label2.Text = "\tOlá Usuário!\n\nEste é o assistente de recuperação de senha.\n\n" +
                "Para que possamos recuperar seus dados de acesso insira seu Nome e E-Mail" +
                " que será enviado para um usuário administrador do sistema";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsu.Text,
                email = txtEmail.Text;

            if (nome == "" || email == "")
            {
                MessageBox.Show("Por favor, insira os campos que estão em branco!",
                    "Esqueci Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("E-Mail foi enviado com sucesso!",
                    "Esqueci Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a solicitação de dados de acesso?"
                , "Fechar o Esqueci Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmEsqueciSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a solicitação de dados de acesso?"
                , "Fechar o Esqueci Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
