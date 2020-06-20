using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class frmLogin : Form
    {
        frmPrincipal principal = new frmPrincipal();
        int i = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void frmLogin_Load(object sender, EventArgs e)
        {
            string[] ids = { "adm", "usu01" };

            cbxID.Items.AddRange(ids);
        }

        public void btmAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                String id = Convert.ToString(cbxID.Text);
                int senha = Convert.ToInt32(txtSenha.Text);

                if (id == "adm" && senha == 123)
                {
                    principal.permissao = 1;
                    MessageBox.Show("Logado como administrador",
                        "Acesso Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LiberarAcesso(principal.permissao);
                }
                else if (id == "usu01" && senha == 123)
                {
                    principal.permissao = 0;
                    MessageBox.Show("Logado como usuário",
                        "Acesso Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LiberarAcesso(principal.permissao);
                }
                else
                {
                    txtSenha.Focus();
                    txtSenha.Clear();
                    if (i > 0)
                    {
                        label4.Text = "\tSenha Inválida!\nPreencha novamente!\nTentativas: " + i;
                        this.label4.ForeColor = Color.Red;
                        label4.Font = new Font(label1.Font, FontStyle.Bold);
                        i--;
                    }
                    else
                    {
                        label4.Text = "";
                        /*
                        MessageBox.Show("Tentativas esgotadas!\nEntrando no assistente de recuperação de dados de acesso!"
                            , "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        WindowsForm.frmEsquiceuSenha esqSenha = new WindowsForm.frmEsquiceuSenha();
                        esqSenha.ShowDialog();*/

                        DialogResult dialogResult = MessageBox.Show("Deseja entrar no assistente de recuperação de dados de acesso?"
                            , "Assistente de Recuperação de Dados de Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            WindowsForm.frmEsquiceuSenha esqSenha = new WindowsForm.frmEsquiceuSenha();
                            esqSenha.ShowDialog();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }

            catch
            {
                MessageBox.Show("Preencha os campos necessarios!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lklblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prototipo.WindowsForm.frmEsquiceuSenha esqSenha = new WindowsForm.frmEsquiceuSenha();
            esqSenha.ShowDialog();
        }
    }
}
