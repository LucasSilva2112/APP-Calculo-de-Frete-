namespace trabalho_2semestre
{
    partial class telaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.Label();
            this.textBoxNomeUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenhaCadastro = new System.Windows.Forms.TextBox();
            this.buttonCadastrarMatricula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVoltarLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "CADASTRO";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.nome.Location = new System.Drawing.Point(30, 163);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(58, 20);
            this.nome.TabIndex = 6;
            this.nome.Text = "Nome:";
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.matricula.Location = new System.Drawing.Point(30, 221);
            this.matricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(72, 20);
            this.matricula.TabIndex = 3;
            this.matricula.Text = "Usuario:";
            // 
            // textBoxNomeUsuarioCadastro
            // 
            this.textBoxNomeUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.textBoxNomeUsuarioCadastro.Location = new System.Drawing.Point(30, 185);
            this.textBoxNomeUsuarioCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeUsuarioCadastro.Name = "textBoxNomeUsuarioCadastro";
            this.textBoxNomeUsuarioCadastro.Size = new System.Drawing.Size(250, 26);
            this.textBoxNomeUsuarioCadastro.TabIndex = 0;
            this.textBoxNomeUsuarioCadastro.TextChanged += new System.EventHandler(this.textBoxNomeUsuarioCadastro_TextChanged);
            // 
            // textBoxUsuarioCadastro
            // 
            this.textBoxUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.textBoxUsuarioCadastro.Location = new System.Drawing.Point(30, 245);
            this.textBoxUsuarioCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioCadastro.Name = "textBoxUsuarioCadastro";
            this.textBoxUsuarioCadastro.Size = new System.Drawing.Size(250, 26);
            this.textBoxUsuarioCadastro.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.label2.Location = new System.Drawing.Point(30, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha:";
            // 
            // textBoxSenhaCadastro
            // 
            this.textBoxSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.textBoxSenhaCadastro.Location = new System.Drawing.Point(30, 306);
            this.textBoxSenhaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenhaCadastro.Name = "textBoxSenhaCadastro";
            this.textBoxSenhaCadastro.Size = new System.Drawing.Size(250, 26);
            this.textBoxSenhaCadastro.TabIndex = 9;
            // 
            // buttonCadastrarMatricula
            // 
            this.buttonCadastrarMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCadastrarMatricula.Location = new System.Drawing.Point(93, 378);
            this.buttonCadastrarMatricula.Name = "buttonCadastrarMatricula";
            this.buttonCadastrarMatricula.Size = new System.Drawing.Size(128, 35);
            this.buttonCadastrarMatricula.TabIndex = 12;
            this.buttonCadastrarMatricula.Text = "Cadastrar";
            this.buttonCadastrarMatricula.UseVisualStyleBackColor = true;
            this.buttonCadastrarMatricula.Click += new System.EventHandler(this.buttonCadastrarMatricula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelVoltarLogin
            // 
            this.labelVoltarLogin.AutoSize = true;
            this.labelVoltarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVoltarLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltarLogin.Location = new System.Drawing.Point(12, 12);
            this.labelVoltarLogin.Name = "labelVoltarLogin";
            this.labelVoltarLogin.Size = new System.Drawing.Size(47, 13);
            this.labelVoltarLogin.TabIndex = 14;
            this.labelVoltarLogin.Text = "VOLTAR";
            this.labelVoltarLogin.Click += new System.EventHandler(this.labelVoltarLogin_Click);
            // 
            // telaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 503);
            this.Controls.Add(this.labelVoltarLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCadastrarMatricula);
            this.Controls.Add(this.textBoxSenhaCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsuarioCadastro);
            this.Controls.Add(this.textBoxNomeUsuarioCadastro);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Name = "telaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.TextBox textBoxNomeUsuarioCadastro;
        private System.Windows.Forms.TextBox textBoxUsuarioCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenhaCadastro;
        private System.Windows.Forms.Button buttonCadastrarMatricula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVoltarLogin;
    }
}