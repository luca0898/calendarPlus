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
    public partial class frmAddEvento : Form
    {
        public frmAddEvento()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            string data = monthCalendar1.SelectionRange.Start.ToShortDateString();
            diaEvento.Text = data;
        }

        private void btnLimparCampos_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja limpar os campos?"
             , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtIDCli.Clear();
                txtNomeCli.Clear();
                pbxImgCli.Image = prototipo.Properties.Resources._1423679952_user;
                txtHoraEvento.Clear();
                txtMinEvento.Clear();
                diaEvento.Text = "Data";
                cbxProcedimento.Text = "";

                txtIDCli.Focus();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cadastrar o novo evento?"
             , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Cliente: " + txtNomeCli.Text + "\nProcedimento: " + cbxProcedimento.Text +"\nData: " + diaEvento.Text + "\nHorário: " + txtHoraEvento.Text + ":" +txtMinEvento.Text);
            }
        }

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {
            if (txtIDCli.Text == "1")
            {
                txtNomeCli.Text = "Cliente 1";
            }

            if (txtIDCli.Text == "2")
            {
                txtNomeCli.Text = "Cliente 2";
            }
        }

        private void frmAddEvento_Load(object sender, EventArgs e)
        {

        }
    }
}
