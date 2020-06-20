namespace prototipo.WindowsForm.Ususário
{
    partial class frmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.mktTelUsu = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailUsu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoginUsu = new System.Windows.Forms.TextBox();
            this.txtReptSenhaUsu = new System.Windows.Forms.TextBox();
            this.txtSenhaUsu = new System.Windows.Forms.TextBox();
            this.cbxTipoUsu = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Usuário";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNomeUsu);
            this.groupBox3.Controls.Add(this.mktTelUsu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEmailUsu);
            this.groupBox3.Location = new System.Drawing.Point(153, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 137);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.Location = new System.Drawing.Point(9, 28);
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(180, 20);
            this.txtNomeUsu.TabIndex = 0;
            // 
            // mktTelUsu
            // 
            this.mktTelUsu.Location = new System.Drawing.Point(9, 106);
            this.mktTelUsu.Mask = "(99) 0000-0000";
            this.mktTelUsu.Name = "mktTelUsu";
            this.mktTelUsu.Size = new System.Drawing.Size(120, 20);
            this.mktTelUsu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail";
            // 
            // txtEmailUsu
            // 
            this.txtEmailUsu.Location = new System.Drawing.Point(9, 67);
            this.txtEmailUsu.Name = "txtEmailUsu";
            this.txtEmailUsu.Size = new System.Drawing.Size(180, 20);
            this.txtEmailUsu.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCodUsu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLoginUsu);
            this.groupBox2.Controls.Add(this.txtReptSenhaUsu);
            this.groupBox2.Controls.Add(this.txtSenhaUsu);
            this.groupBox2.Controls.Add(this.cbxTipoUsu);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 217);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repita a Senha";
            // 
            // txtLoginUsu
            // 
            this.txtLoginUsu.Location = new System.Drawing.Point(12, 67);
            this.txtLoginUsu.Name = "txtLoginUsu";
            this.txtLoginUsu.Size = new System.Drawing.Size(120, 20);
            this.txtLoginUsu.TabIndex = 0;
            // 
            // txtReptSenhaUsu
            // 
            this.txtReptSenhaUsu.Location = new System.Drawing.Point(12, 145);
            this.txtReptSenhaUsu.Name = "txtReptSenhaUsu";
            this.txtReptSenhaUsu.PasswordChar = '•';
            this.txtReptSenhaUsu.Size = new System.Drawing.Size(120, 20);
            this.txtReptSenhaUsu.TabIndex = 2;
            // 
            // txtSenhaUsu
            // 
            this.txtSenhaUsu.Location = new System.Drawing.Point(12, 106);
            this.txtSenhaUsu.Name = "txtSenhaUsu";
            this.txtSenhaUsu.PasswordChar = '•';
            this.txtSenhaUsu.Size = new System.Drawing.Size(120, 20);
            this.txtSenhaUsu.TabIndex = 1;
            // 
            // cbxTipoUsu
            // 
            this.cbxTipoUsu.FormattingEnabled = true;
            this.cbxTipoUsu.Location = new System.Drawing.Point(12, 184);
            this.cbxTipoUsu.Name = "cbxTipoUsu";
            this.cbxTipoUsu.Size = new System.Drawing.Size(120, 21);
            this.cbxTipoUsu.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(153, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(279, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(390, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // novoToolStripMenuItem
            // 
            //this.novoToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438916101_editor_document_file_add_2;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            //this.editarToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438915988_editor_pencil_pen_edit_write;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            //this.excluirToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438915970_editor_trash_delete_recycle_bin;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            this.excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            this.excluirUsuárioToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Codigo";
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.Enabled = false;
            this.txtCodUsu.Location = new System.Drawing.Point(12, 28);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.Size = new System.Drawing.Size(120, 20);
            this.txtCodUsu.TabIndex = 15;
            // 
            // frmCadastroUsuario
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário | Calendar Plus";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoUsu;
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mktTelUsu;
        private System.Windows.Forms.TextBox txtReptSenhaUsu;
        private System.Windows.Forms.TextBox txtSenhaUsu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLoginUsu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodUsu;
    }
}