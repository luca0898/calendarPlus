namespace prototipo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lklblEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.btmAcessar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxIcone = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(16, 196);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(252, 22);
            this.cbxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(16, 242);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(252, 22);
            this.txtSenha.TabIndex = 4;
            // 
            // lklblEsqueciSenha
            // 
            this.lklblEsqueciSenha.AutoSize = true;
            this.lklblEsqueciSenha.Location = new System.Drawing.Point(92, 340);
            this.lklblEsqueciSenha.Name = "lklblEsqueciSenha";
            this.lklblEsqueciSenha.Size = new System.Drawing.Size(96, 14);
            this.lklblEsqueciSenha.TabIndex = 5;
            this.lklblEsqueciSenha.TabStop = true;
            this.lklblEsqueciSenha.Tag = "";
            this.lklblEsqueciSenha.Text = "Esqueci a Senha";
            this.lklblEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblEsqueciSenha_LinkClicked);
            // 
            // btmAcessar
            // 
            this.btmAcessar.Location = new System.Drawing.Point(103, 384);
            this.btmAcessar.Name = "btmAcessar";
            this.btmAcessar.Size = new System.Drawing.Size(75, 25);
            this.btmAcessar.TabIndex = 6;
            this.btmAcessar.Text = "Acessar";
            this.btmAcessar.UseVisualStyleBackColor = true;
            this.btmAcessar.Click += new System.EventHandler(this.btmAcessar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(246, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Copyright® 2015";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxIcone
            // 
            this.pbxIcone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.pbxIcone.Image = global::prototipo.Properties.Resources._1423679952_user;
            this.pbxIcone.Location = new System.Drawing.Point(84, 38);
            this.pbxIcone.Name = "pbxIcone";
            this.pbxIcone.Size = new System.Drawing.Size(112, 113);
            this.pbxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIcone.TabIndex = 0;
            this.pbxIcone.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btmAcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(280, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmAcessar);
            this.Controls.Add(this.lklblEsqueciSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxIcone);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 517);
            this.MinimumSize = new System.Drawing.Size(280, 517);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarPlus";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxIcone;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.LinkLabel lklblEsqueciSenha;
        private System.Windows.Forms.Button btmAcessar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

