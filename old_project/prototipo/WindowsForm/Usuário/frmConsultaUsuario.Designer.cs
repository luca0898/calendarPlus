namespace prototipo.WindowsForm.Usuário
{
    partial class frmConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuario));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelUsu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoUsu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmailUsu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeUsu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(18, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Código";
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.Location = new System.Drawing.Point(64, 13);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.Size = new System.Drawing.Size(131, 20);
            this.txtCodUsu.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelUsu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTipoUsu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblEmailUsu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomeUsu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // lblTelUsu
            // 
            this.lblTelUsu.AutoSize = true;
            this.lblTelUsu.Location = new System.Drawing.Point(146, 94);
            this.lblTelUsu.Name = "lblTelUsu";
            this.lblTelUsu.Size = new System.Drawing.Size(10, 13);
            this.lblTelUsu.TabIndex = 15;
            this.lblTelUsu.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo de Usuário";
            // 
            // lblTipoUsu
            // 
            this.lblTipoUsu.AutoSize = true;
            this.lblTipoUsu.Location = new System.Drawing.Point(146, 123);
            this.lblTipoUsu.Name = "lblTipoUsu";
            this.lblTipoUsu.Size = new System.Drawing.Size(10, 13);
            this.lblTipoUsu.TabIndex = 13;
            this.lblTipoUsu.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefone";
            // 
            // lblEmailUsu
            // 
            this.lblEmailUsu.AutoSize = true;
            this.lblEmailUsu.Location = new System.Drawing.Point(146, 65);
            this.lblEmailUsu.Name = "lblEmailUsu";
            this.lblEmailUsu.Size = new System.Drawing.Size(10, 13);
            this.lblEmailUsu.TabIndex = 11;
            this.lblEmailUsu.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-Mail";
            // 
            // lblNomeUsu
            // 
            this.lblNomeUsu.AutoSize = true;
            this.lblNomeUsu.Location = new System.Drawing.Point(146, 36);
            this.lblNomeUsu.Name = "lblNomeUsu";
            this.lblNomeUsu.Size = new System.Drawing.Size(10, 13);
            this.lblNomeUsu.TabIndex = 9;
            this.lblNomeUsu.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(248, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 241);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodUsu);
            this.Controls.Add(this.lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário | CalendarPlus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtCodUsu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipoUsu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmailUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomeUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTelUsu;
        private System.Windows.Forms.Label label2;

    }
}