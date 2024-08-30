using System;

namespace trabalho_2semestre
{
    partial class telaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.labelEsqueciaSenha = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(36, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(36, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(100, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "LOGIN";
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(40, 217);
            this.textBoxUsuarioLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(236, 26);
            this.textBoxUsuarioLogin.TabIndex = 16;
            this.textBoxUsuarioLogin.TextChanged += new System.EventHandler(this.textBoxUsuarioLogin_TextChanged);
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(40, 276);
            this.textBoxSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(236, 26);
            this.textBoxSenhaLogin.TabIndex = 18;
            this.textBoxSenhaLogin.TextChanged += new System.EventHandler(this.textBoxSenhaLogin_TextChanged);
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCadastro.Location = new System.Drawing.Point(36, 330);
            this.labelCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(101, 20);
            this.labelCadastro.TabIndex = 22;
            this.labelCadastro.Text = "Cadastre-se";
            this.labelCadastro.Click += new System.EventHandler(this.labelCadastro_Click);
            // 
            // labelEsqueciaSenha
            // 
            this.labelEsqueciaSenha.AutoSize = true;
            this.labelEsqueciaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEsqueciaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEsqueciaSenha.Location = new System.Drawing.Point(90, 390);
            this.labelEsqueciaSenha.Name = "labelEsqueciaSenha";
            this.labelEsqueciaSenha.Size = new System.Drawing.Size(133, 20);
            this.labelEsqueciaSenha.TabIndex = 21;
            this.labelEsqueciaSenha.Text = "Esqueci a senha";
            this.labelEsqueciaSenha.Click += new System.EventHandler(this.labelEsqueciSenha_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonLogin.Location = new System.Drawing.Point(195, 325);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(83, 38);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelEsqueciaSenha);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LabelEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label labelEsqueciaSenha;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

