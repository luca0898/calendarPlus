namespace prototipo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobretoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.diaHoje = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btmAdicionar = new System.Windows.Forms.Button();
            this.btmEditar = new System.Windows.Forms.Button();
            this.btmPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.usuarioToolStripMenuItem1,
            this.preferenciasStripMenuItem1,
            this.sobretoolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem1
            // 
            this.sistemaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.encerrarToolStripMenuItem});
            this.sistemaToolStripMenuItem1.Name = "sistemaToolStripMenuItem1";
            this.sistemaToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem1.Text = "Sistema";
            // 
            // entrarToolStripMenuItem
            // 
            //this.entrarToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438915556_common_login_enter_signin;
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // encerrarToolStripMenuItem
            // 
            //this.encerrarToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438915556_sair1;
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // gerenciarToolStripMenuItem
            // 
            //this.gerenciarToolStripMenuItem.Image = global::prototipo.Properties.Resources._1438916328_device_projector_screen_content_chart_presentation;
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem1,
            this.consultarToolStripMenuItem2});
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem1.Text = "Usuário";
            // 
            // gerenciarToolStripMenuItem1
            // 
            //this.gerenciarToolStripMenuItem1.Image = global::prototipo.Properties.Resources._1438916328_device_projector_screen_content_chart_presentation;
            this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
            this.gerenciarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.gerenciarToolStripMenuItem1.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem1.Click += new System.EventHandler(this.gerenciarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            //this.consultarToolStripMenuItem2.Image = global::prototipo.Properties.Resources._1438915946_common_search_lookup_;
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // preferenciasStripMenuItem1
            // 
            this.preferenciasStripMenuItem1.Name = "preferenciasStripMenuItem1";
            this.preferenciasStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.preferenciasStripMenuItem1.Text = "Preferências";
            this.preferenciasStripMenuItem1.Click += new System.EventHandler(this.preferenciasStripMenuItem1_Click);
            // 
            // sobretoolStripMenuItem2
            // 
            this.sobretoolStripMenuItem2.Name = "sobretoolStripMenuItem2";
            this.sobretoolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.sobretoolStripMenuItem2.Text = "Sobre";
            this.sobretoolStripMenuItem2.Click += new System.EventHandler(this.sobretoolStripMenuItem2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxLogo);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pbxLogo
            // 
            //this.pbxLogo.Image = global::prototipo.Properties.Resources.Sem_título;
            this.pbxLogo.Location = new System.Drawing.Point(6, 15);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(235, 124);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.DoubleClick += new System.EventHandler(this.pbxLogo_DoubleClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 263);
            this.monthCalendar1.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(480, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Copyright® 2015";
            // 
            // diaHoje
            // 
            this.diaHoje.AutoSize = true;
            this.diaHoje.Location = new System.Drawing.Point(275, 100);
            this.diaHoje.Name = "diaHoje";
            this.diaHoje.Size = new System.Drawing.Size(0, 13);
            this.diaHoje.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btmAdicionar
            // 
            this.btmAdicionar.Location = new System.Drawing.Point(11, 45);
            this.btmAdicionar.Name = "btmAdicionar";
            this.btmAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btmAdicionar.TabIndex = 3;
            this.btmAdicionar.Text = "Adicionar";
            this.btmAdicionar.UseVisualStyleBackColor = true;
            this.btmAdicionar.Click += new System.EventHandler(this.btmAdicionar_Click);
            // 
            // btmEditar
            // 
            this.btmEditar.Enabled = false;
            this.btmEditar.Location = new System.Drawing.Point(172, 45);
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(75, 23);
            this.btmEditar.TabIndex = 4;
            this.btmEditar.Text = "Editar";
            this.btmEditar.UseVisualStyleBackColor = true;
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.Location = new System.Drawing.Point(495, 13);
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btmPesquisar.TabIndex = 2;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(333, 45);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(11, 74);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(559, 340);
            this.dgvAgenda.TabIndex = 7;
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Location = new System.Drawing.Point(495, 45);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btmAtualizar.TabIndex = 6;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(11, 15);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(478, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btmAtualizar);
            this.groupBox2.Controls.Add(this.dgvAgenda);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btmPesquisar);
            this.groupBox2.Controls.Add(this.btmEditar);
            this.groupBox2.Controls.Add(this.btmAdicionar);
            this.groupBox2.Location = new System.Drawing.Point(262, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 437);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 475);
            this.Controls.Add(this.diaHoje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 514);
            this.MinimumSize = new System.Drawing.Size(860, 514);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal | CalendarPlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pbxLogo;
        public System.Windows.Forms.Label diaHoje;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem1;
        private System.Windows.Forms.Button btmAdicionar;
        private System.Windows.Forms.Button btmEditar;
        private System.Windows.Forms.Button btmPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem preferenciasStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem sobretoolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
    }
}