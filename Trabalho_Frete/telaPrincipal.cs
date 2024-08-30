using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.WebSockets;


namespace trabalho_2semestre
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCep.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                return; // Encerra o códigoz
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        String response = responseReader.ReadToEnd();
                        MessageBox.Show(response);
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        MessageBox.Show(response);

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        string uf = "";

                        foreach (var substring in substrings)
                        {
                            // CEP
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(':');
                                txtCep.Text = valor[1].ToString();
                            }

                            // Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(':');
                                txtLogradouro.Text = valor[1].ToString();
                            }


                            // Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(':');
                                txtBairro.Text = valor[1].ToString();
                            }

                            // Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(':');
                                txtCidade.Text = valor[1].ToString();
                            }

                            // UF
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(':');
                                uf = valor[1].ToString();
                                txtUF.Text = uf;
                            }
                            cont++;
                        }
                         // Chama o método CalcularFrete apenas se a UF não estiver vazia
    if (!string.IsNullOrEmpty(uf))
    {
        CalcularFrete(uf);
    }
                    }
                }
            }


        }

        public void CalcularFrete(string uf)
        {

            // Verifica se o valor digitado é válido
            if (!decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Digite um valor válido.");
                return;
            }

            // Converte a UF para maiúsculas
            uf = uf.ToUpper();

            // Declaro e inicializo as variáveis frete e total
            decimal frete = 0, total = 0;

            // Faço o teste condicional para calcular o valor do frete
            if (valor > 1000)
            {
                frete = 0;
            }
            else
            {
                switch (uf)
                {
                    case "SP":
                        frete = 5;
                        break;
                    case "RJ":
                        frete = 10;
                        break;
                    case "MG":
                        frete = 20;
                        break;
                    default:
                        frete = 15;
                        break;
                }
            }

            //Armazeno na variável total o valor digitado mais o frete que acabei de calcular
            total = valor + frete;

            //Armazeno os valores nos respectivos labels
            lblValorCompra.Text = valor.ToString("C");
            lblValorFrete.Text = frete.ToString("C");
            lblValorTotal.Text = total.ToString("C");
        }
        public void LimparCampos()
        {
            //Finalizando, crio este método para limpar as variáveis
            txtCep.Text = "";
            txtValor.Text = "";
            txtLogradouro.Text ="";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            lblValorCompra.Text = "";
            lblValorFrete.Text = "";
            lblValorTotal.Text = "";
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete("");
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }
        
        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
