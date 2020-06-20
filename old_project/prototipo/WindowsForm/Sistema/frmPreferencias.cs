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
    public partial class frmPreferencias : Form
    {
        frmLogin FrmLogin = new frmLogin();

        public frmPreferencias()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btmCor_Click(object sender, EventArgs e)
        {
            //WindowsForm.Sistema.frmSelect cor = new WindowsForm.Sistema.frmSelect();
            //cor.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Form principal1 = Application.OpenForms["frmPrincipal"];
                principal1.BackColor = colorDialog1.Color;
            }
        }

        }

    }
