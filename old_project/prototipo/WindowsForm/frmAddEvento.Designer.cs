namespace prototipo.WindowsForm
{
    partial class frmAddEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEvento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.pbxImgCli = new System.Windows.Forms.PictureBox();
            this.txtIDCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProcedimento = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.diaEvento = new System.Windows.Forms.Label();
            this.txtHoraEvento = new System.Windows.Forms.TextBox();
            this.txtMinEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscarDados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCli.Enabled = false;
            this.txtNomeCli.Location = new System.Drawing.Point(96, 47);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(295, 20);
            this.txtNomeCli.TabIndex = 1;
            // 
            // btmVoltar
            // 
            this.btmVoltar.Location = new System.Drawing.Point(423, 244);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(75, 23);
            this.btmVoltar.TabIndex = 5;
            this.btmVoltar.Text = "Voltar";
            this.btmVoltar.UseVisualStyleBackColor = true;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // pbxImgCli
            // 
            //this.pbxImgCli.Image = global::prototipo.Properties.Resources._1423679952_user;
            this.pbxImgCli.Location = new System.Drawing.Point(398, 16);
            this.pbxImgCli.Name = "pbxImgCli";
            this.pbxImgCli.Size = new System.Drawing.Size(100, 100);
            this.pbxImgCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgCli.TabIndex = 11;
            this.pbxImgCli.TabStop = false;
            // 
            // txtIDCli
            // 
            this.txtIDCli.Location = new System.Drawing.Point(96, 18);
            this.txtIDCli.Name = "txtIDCli";
            this.txtIDCli.Size = new System.Drawing.Size(68, 20);
            this.txtIDCli.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procedimento";
            // 
            // cbxProcedimento
            // 
            this.cbxProcedimento.FormattingEnabled = true;
            this.cbxProcedimento.Items.AddRange(new object[] {
            "Massagem relaxante",
            "Massagem modeladora",
            "Massagem redutora",
            "Massagem facial",
            "Drenagem linfática",
            "Bandagem",
            "Argiloterapia",
            "Gessoterapia",
            "Desintoxicação"});
            this.cbxProcedimento.Location = new System.Drawing.Point(96, 78);
            this.cbxProcedimento.Name = "cbxProcedimento";
            this.cbxProcedimento.Size = new System.Drawing.Size(295, 21);
            this.cbxProcedimento.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 109);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // diaEvento
            // 
            this.diaEvento.AutoSize = true;
            this.diaEvento.Location = new System.Drawing.Point(6, 20);
            this.diaEvento.Name = "diaEvento";
            this.diaEvento.Size = new System.Drawing.Size(30, 13);
            this.diaEvento.TabIndex = 0;
            this.diaEvento.Text = "Data";
            // 
            // txtHoraEvento
            // 
            this.txtHoraEvento.Location = new System.Drawing.Point(53, 40);
            this.txtHoraEvento.Name = "txtHoraEvento";
            this.txtHoraEvento.Size = new System.Drawing.Size(27, 20);
            this.txtHoraEvento.TabIndex = 3;
            // 
            // txtMinEvento
            // 
            this.txtMinEvento.Location = new System.Drawing.Point(92, 40);
            this.txtMinEvento.Name = "txtMinEvento";
            this.txtMinEvento.Size = new System.Drawing.Size(27, 20);
            this.txtMinEvento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = ":";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(340, 244);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCampos.TabIndex = 28;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horário";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(257, 244);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarDados
            // 
            this.btnBuscarDados.Location = new System.Drawing.Point(316, 16);
            this.btnBuscarDados.Name = "btnBuscarDados";
            this.btnBuscarDados.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDados.TabIndex = 30;
            this.btnBuscarDados.Text = "Buscar";
            this.btnBuscarDados.UseVisualStyleBackColor = true;
            this.btnBuscarDados.Click += new System.EventHandler(this.btnBuscarDados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diaEvento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoraEvento);
            this.groupBox1.Controls.Add(this.txtMinEvento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(257, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 71);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data e Horário";
            // 
            // frmAddEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarDados);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cbxProcedimento);
            this.Controls.Add(this.txtIDCli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxImgCli);
            this.Controls.Add(this.btmVoltar);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar evento | CalendarPlus";
            this.Load += new System.EventHandler(this.frmAddEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.PictureBox pbxImgCli;
        private System.Windows.Forms.TextBox txtIDCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProcedimento;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label diaEvento;
        private System.Windows.Forms.TextBox txtHoraEvento;
        private System.Windows.Forms.TextBox txtMinEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBuscarDados;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}