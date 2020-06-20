using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prototipo.WindowsForm.Usuário
{
    public partial class frmConsultaUsuario : Form
    {
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod = txtCodUsu.Text;

            if(cod == "1")
            {
                lblNomeUsu.Text = "Administrador do Sistema";
                lblEmailUsu.Text = "administrador@exemplo.com";
                lblTelUsu.Text = "(19)99999-9999";
                lblTipoUsu.Text = "Administrador";
            }
            if (cod == "2")
            {
                lblNomeUsu.Text = "Usuário Normal 1";
                lblEmailUsu.Text = "usuario1@exemplo.com";
                lblTelUsu.Text = "(19)98888-8888";
                lblTipoUsu.Text = "Normal";
            }
            if (cod == "3")
            {
                lblNomeUsu.Text = "Usuário Normal 2";
                lblEmailUsu.Text = "usu_normal@exemplo.com";
                lblTelUsu.Text = "(19)97777-7777";
                lblTipoUsu.Text = "Normal";
            }
        }
    }
}
