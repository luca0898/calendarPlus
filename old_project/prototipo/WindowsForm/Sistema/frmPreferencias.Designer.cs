namespace prototipo
{
    partial class frmPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferencias));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btmVoltar
            // 
            this.btmVoltar.Location = new System.Drawing.Point(360, 152);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(75, 23);
            this.btmVoltar.TabIndex = 2;
            this.btmVoltar.Text = "Voltar";
            this.btmVoltar.UseVisualStyleBackColor = true;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // btmCor
            // 
            this.btmCor.Location = new System.Drawing.Point(12, 12);
            this.btmCor.Name = "btmCor";
            this.btmCor.Size = new System.Drawing.Size(86, 26);
            this.btmCor.TabIndex = 2;
            this.btmCor.Text = "Alterar Cor";
            this.btmCor.UseVisualStyleBackColor = true;
            this.btmCor.Click += new System.EventHandler(this.btmCor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmCor);
            this.Controls.Add(this.btmVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferências | CalendarPlus";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}