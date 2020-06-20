using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo.WindowsForm
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            try
            {
                Bitmap imagem = new Bitmap(openFileDialog1.FileName);
                pbxImgCli.Image = imagem;
                this.Validate();
            }
            catch
            {
                MessageBox.Show("Nenhuma imagem selecionada" + "\n" + " Por favor selecione alguma imagem", "INFORMAÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // salvar os dados do cadastro
            MessageBox.Show("Os dados do usuário foram salvos com sucesso",
                "Salvar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // fazer um try cacth para testar se o formulario foi salvo no bd com sucesso
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            txtIDCli.Enabled = false;

            tabControl1.Enabled = false;            

            // Adiciona as causas da estria ------------------------------------------------
            String[] causa = { "Adolescência", "Gravidez", "Alteração do Peso", "Hipertrofia Muscular" };
            cbxCausas.Items.AddRange(causa);
            // -----------------------------------------------------------------------------

            rtbJaRecebeu.Enabled = false;
            rtbCosmetico.Enabled = false;
            rtbAlergia.Enabled = false;
            rtbIngAgua.Enabled = false;
            rtbIngAlcool.Enabled = false;
            rtbMedicamento.Enabled = false;
            rtbAtivFisica.Enabled = false;
            rtbCicloMenstr.Enabled = false;
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            txtIDCli.Enabled = true;
        }

        private void cbxJaRecebeu_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbJaRecebeu.Enabled == false)
            {
                rtbJaRecebeu.Enabled = true;
            }
            else
            {
                rtbJaRecebeu.Enabled = false;
            }
        }

        private void cbxCosmetico_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbCosmetico.Enabled == false)
            {
                rtbCosmetico.Enabled = true;
            }
            else
            {
                rtbCosmetico.Enabled = false;
            }
        }

        private void cbxAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbAlergia.Enabled == false)
            {
                rtbAlergia.Enabled = true;
            }
            else
            {
                rtbAlergia.Enabled = false;
            }
        }

        private void cbxIngAgua_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbIngAgua.Enabled == false)
            {
                rtbIngAgua.Enabled = true;
            }
            else
            {
                rtbIngAgua.Enabled = false;
            }
        }

        private void cbxIngAlcool_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbIngAlcool.Enabled == false)
            {
                rtbIngAlcool.Enabled = true;
            }
            else
            {
                rtbIngAlcool.Enabled = false;
            }
        }

        private void cbxMedicamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbMedicamento.Enabled == false)
            {
                rtbMedicamento.Enabled = true;
            }
            else
            {
                rtbMedicamento.Enabled = false;
            }
        }

        private void cbxAtivFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbAtivFisica.Enabled == false)
            {
                rtbAtivFisica.Enabled = true;
            }
            else
            {
                rtbAtivFisica.Enabled = false;
            }
        }

        private void cbxCicloMenstr_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbCicloMenstr.Enabled == false)
            {
                rtbCicloMenstr.Enabled = true;
            }
            else
            {
                rtbCicloMenstr.Enabled = false;
            }
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            cbxCicloMenstr.Enabled = false;
        }

        private void rsbFem_CheckedChanged(object sender, EventArgs e)
        {
            cbxCicloMenstr.Enabled = true;
        }

        private void cbxCelulite_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbCelulite.Enabled == false)
            {
                gpbCelulite.Enabled = true;
            }
            else
            {
                gpbCelulite.Enabled = false;
            }
        }

        private void chbAtvFlacidez_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbFlacidez.Enabled == false)
            {
                gpbFlacidez.Enabled = true;
            }
            else
            {
                gpbFlacidez.Enabled = false;
            }
        }

        private void chbAtvEstrias_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbEstrias.Enabled == false)
            {
                gpbEstrias.Enabled = true;
            }
            else
            {
                gpbEstrias.Enabled = false;
            }
        }

        private void chbAtvGorLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbGordLoc.Enabled == false)
            {
                gpbGordLoc.Enabled = true;
            }
            else
            {
                gpbGordLoc.Enabled = false;
            }
        }

        private void chbAtvPosOper_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbPosOper.Enabled == false)
            {
                gpbPosOper.Enabled = true;
            }
            else
            {
                gpbPosOper.Enabled = false;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ----------------------------------------------------------------
            // --------------------verifica campos vazios --------------------
            // ----------------------------------------------------------------

            if ((rbnHABom.Checked == false || rbnHARegular.Checked == false || rbnHARuim.Checked == false) &&
                (rbnQSBom.Checked == false || rbnQSRegular.Checked == false || rbnQSRuim.Checked == false) &&
                txtAltura.Text == "" || txtPeso.Text == "" || txtCintura.Text == "" || txtCinturaAlta.Text == "" ||
                txtCinturaBaixa.Text == "" || txtQuadril.Text == "" || txtCulote.Text == "" || txtCoxaDireita.Text == "" ||
                txtCoxaEsquerda.Text == "" && (rdbMasc.Checked == false || rsbFem.Checked == false))
            {
                MessageBox.Show("Preencha os Campos Obrigatórios", "Salvar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cliente Salvo Com Sucesso", "Salvar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.Enabled = false;
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja imprimir a ficha de avaliação?"
               , "Imprimir Avaliação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Avaliação imprimida com sucesso!", "Imprimir Ficha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No){}
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            txtIDCli.Enabled = false;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIDCli.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gpbHabAlimentares.Enabled == false)
            {
                gpbHabAlimentares.Enabled = true;
            }
            else
            {
                gpbHabAlimentares.Enabled = false;
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtIDCli.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este usuário?"
                   , "Excluir Usuário?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Usuário excluido com sucesso!", "Excluir Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campo ID em branco, por favor, insira um código de cliente para exclui-lo!", 
                    "Excluir Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabInfoPessoal_Click(object sender, EventArgs e)
        {

        }
    }
}