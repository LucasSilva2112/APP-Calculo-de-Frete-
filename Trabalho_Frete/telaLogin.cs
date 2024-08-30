using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_2semestre
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();

            textBoxSenhaLogin.UseSystemPasswordChar = true;
        }


        private void labelCadastro_Click(object sender, EventArgs e)
        {
            telaCadastro cadastro = new telaCadastro();
            cadastro.ShowDialog();
        }

        private void labelEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Consulte a caixa de entrada do seu e-mail, enviaremos um link de confirmação para alteração de senha.");
        }

        private void textBoxUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Obtem as credenciais do usuário
            string usuario = textBoxUsuarioLogin.Text;
            string senha = textBoxSenhaLogin.Text;

            // Cria a conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;pwd='';database=db_trabalho"))
            {
                // Usa uma instrução SQL parametrizada para evitar SQL Injection
                string sql = "SELECT COUNT(*) FROM funcionarios WHERE usuario = @Usuario AND senha = @Senha";

                // Cria e configura o MySqlCommand
                using (MySqlCommand cmm = new MySqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros com seus valores
                    cmm.Parameters.AddWithValue("@Usuario", usuario);
                    cmm.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        // Abre a conexão
                        conn.Open();

                        // Executa a consulta
                        int count = Convert.ToInt32(cmm.ExecuteScalar());

                        // Verifica se as credenciais são válidas
                        if (count > 0)
                        {
                            MessageBox.Show("Login bem-sucedido!");

                            // Abre a tela principal
                            telaPrincipal telaPrincipal = new telaPrincipal();
                            telaPrincipal.Show();


                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas. Por favor, tente novamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro de login: {ex.Message}");
                    }
                }
            }
        }

        private void textBoxSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
