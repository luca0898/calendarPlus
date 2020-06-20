using prototipo.WindowsForm.Ususário;
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
    public partial class frmPrincipal : Form
    {
        public int permissao;

        public frmPrincipal()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            clienteToolStripMenuItem1.Enabled = false;
            usuarioToolStripMenuItem1.Enabled = false;
            preferenciasStripMenuItem1.Enabled = false;
            sobretoolStripMenuItem2.Enabled = false;
        }

        public void LiberarAcesso(int permissao)
        {
            frmPrincipal principal = new frmPrincipal();
            if (permissao == 1)
            {                
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                clienteToolStripMenuItem1.Enabled = true;
                usuarioToolStripMenuItem1.Enabled = true;
                preferenciasStripMenuItem1.Enabled = true;
                sobretoolStripMenuItem2.Enabled = true;
            }
            if (permissao == 0)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                gerenciarToolStripMenuItem1.Enabled = false;
                clienteToolStripMenuItem1.Enabled = true;
                usuarioToolStripMenuItem1.Enabled = true;
                preferenciasStripMenuItem1.Enabled = true;
                sobretoolStripMenuItem2.Enabled = true;
            }
            this.Refresh();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            string data = monthCalendar1.SelectionRange.Start.ToLongDateString();
            diaHoje.Text = data;
        }

        private void btmAdicionar_Click(object sender, EventArgs e)
        {
            WindowsForm.frmAddEvento addevento = new WindowsForm.frmAddEvento();
            addevento.ShowDialog();
        }

        private void pbxLogo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                frmPrincipal frmPrinci = new frmPrincipal();

                Bitmap logoEmp = new Bitmap(openFileDialog1.FileName);
                Form principal1 = Application.OpenForms["frmPrincipal"];
                PictureBox imagem = (PictureBox)principal1.Controls["pbxLogo"];
                imagem.Image = logoEmp;

                //Image imagem = logoEmp;
                this.Validate();
            }
            catch
            {
                MessageBox.Show("Nenhuma imagem selecionada" + "\n" + " Por favor selecione alguma imagem", "INFORMAÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prototipo.WindowsForm.Ususário.frmCadastroUsuario cadUsu = new frmCadastroUsuario();
            cadUsu.ShowDialog();

        }

        private void preferenciasStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPreferencias FrmConfiguracoes = new frmPreferencias();
            FrmConfiguracoes.ShowDialog();
        }

        private void sobretoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSobre FrmSobre = new frmSobre();
            FrmSobre.ShowDialog();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja encerrar a sessão?"
                 , "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja fechar a aplicação?"
                , "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prototipo.WindowsForm.frmCadastroCliente FrmCadastroCliente = new WindowsForm.frmCadastroCliente();

            FrmCadastroCliente.ShowDialog();
        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario FrmCadastroUsuario = new frmCadastroUsuario();
            FrmCadastroUsuario.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            WindowsForm.Usuário.frmConsultaUsuario FrmConsultaUsuario = new WindowsForm.Usuário.frmConsultaUsuario();
            FrmConsultaUsuario.ShowDialog();
        }
    }
}
