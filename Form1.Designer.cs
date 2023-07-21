namespace GUI
{
    partial class frmTeladeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeladeLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ESCOLA PROFISSIONALIZANTE";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(109, 267);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(119, 322);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 18);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(59, 343);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(173, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(59, 288);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrar.Location = new System.Drawing.Point(100, 381);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(105, 28);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(260, 6);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(28, 23);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 5;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(59, 80);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(173, 169);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmTeladeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(292, 437);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeladeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA-DE-LOGIN";
            this.Load += new System.EventHandler(this.frmTeladeLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

