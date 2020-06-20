using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo.WindowsForm.Ususário
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            txtCodUsu.Enabled = false;

            String[] tipoUsu = { "Administrador", "Normal" };
            cbxTipoUsu.Items.AddRange(tipoUsu);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtCodUsu.Enabled = false;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtCodUsu.Enabled = true;
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este usuário?"
               , "Deletar Usuário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Usuário deletado com sucesso!", 
                    "Deletar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupBox1.Enabled = false;
                txtCodUsu.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(txtSenhaUsu);
            string b = Convert.ToString(txtReptSenhaUsu.Text);

            if(txtLoginUsu.Text == "" || txtSenhaUsu.Text == "" || txtReptSenhaUsu.Text == "" || txtEmailUsu.Text == "" ||
                mktTelUsu.Text == "" || txtNomeUsu.Text == "" || cbxTipoUsu.Text == "")
            {
                MessageBox.Show("Por favor insira os campos obrigatórios!","Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (1 == 1)
                {
                    MessageBox.Show("Usuário Cadastrado com sucesso!",
                    "Dados Cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = false;
                    Limpar();
                }
                /*
                 else
                {
                    messagebox.show("senha não corresponde!\npor favor reinsira a senha desejada!",
                        "senhas não correspondem", messageboxbuttons.ok, messageboxicon.exclamation);
                }
                 */
            }
        }

        public void Limpar(){
            txtNomeUsu.Clear();
            txtEmailUsu.Clear();
            txtSenhaUsu.Clear();
            txtReptSenhaUsu.Clear();
            txtLoginUsu.Clear();
            mktTelUsu.Clear();
            cbxTipoUsu.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
