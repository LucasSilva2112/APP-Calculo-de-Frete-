using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trabalho_2semestre
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();

            textBoxSenhaCadastro.UseSystemPasswordChar = true;

        }

        private void textBoxNomeUsuarioCadastro_TextChanged(object sender, EventArgs e)
        {
           
  
        }

        private void buttonCadastrarMatricula_Click(object sender, EventArgs e)
        {
            // Obtem os valores dos TextBoxes
            string usuario = textBoxUsuarioCadastro.Text;
            string nome = textBoxNomeUsuarioCadastro.Text;
            string senha = textBoxSenhaCadastro.Text;

            // Cria a conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;pwd='';database=db_trabalho"))
            {
                // Usa  parâmetros na instrução SQL
                string sql = "INSERT INTO funcionarios(usuario, nome, senha) VALUES (@Usuario, @Nome, @Senha)";

                // Cria e configura o MySqlCommand
                using (MySqlCommand cmm = new MySqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros com seus valores
                    cmm.Parameters.AddWithValue("@Usuario", usuario);
                    cmm.Parameters.AddWithValue("@Nome", nome);
                    cmm.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        // Abre a conexão, executa a instrução e fecha a conexão
                        conn.Open();
                        cmm.ExecuteNonQuery();

                        // Exibe a mensagem de cadastro bem-sucedido
                        MessageBox.Show("Cadastro realizado com sucesso!");

                        // Limpa os campos após o cadastro
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao cadastrar: {ex.Message}");
                    }
                }
            }
        }

        private void LimparCampos()
        {
            textBoxUsuarioCadastro.Text = "";
            textBoxNomeUsuarioCadastro.Text = "";
            textBoxSenhaCadastro.Text = "";
        }


        private void labelVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLogin telaLogin = new telaLogin();
            telaLogin.ShowDialog();
    }
    }
}
