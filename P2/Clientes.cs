using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P2
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            iniciar_arquivo();
        }

        private string caminho_arquivo = "c:/Users/lardu/Documents/clientes.csv";

        private void iniciar_arquivo()
        {
            if (!File.Exists(caminho_arquivo))
            {
                using (StreamWriter aq = new StreamWriter(caminho_arquivo))
                {
                    aq.WriteLine("Nome,CPF,Email,Endereco,Telefone,Zap");
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu voltar = new menu();
            voltar.ShowDialog();
            this.Close();
            return;
        }
        public class ViaCepResponse
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
        }

        private async void buscar_end()
        {
            string cep = text_cep.Text;

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    string json = await client.GetStringAsync(url);

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var endereco = JsonSerializer.Deserialize<ViaCepResponse>(json, options);

                    if (endereco != null && endereco.Cep != null)
                    {
                        text_cep.Text = $"{endereco.Cep} - {endereco.Logradouro}, {endereco.Bairro}, {endereco.Localidade}-{endereco.Uf}";
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar CEP.");
            }
        }






        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = text_nome.Text.Trim();
            string email = text_email.Text.Trim();
            string cpf = text_cpf.Text.Trim();  
            string zap = text_zap.Text.Trim();
            string tele = text_tele.Text.Trim();
            string end = text_cep.Text.Trim();   

            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(cpf) ||
                string.IsNullOrEmpty(zap) ||
                string.IsNullOrEmpty(tele) ||
                string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string linha = $"{nome};{email};{cpf};{zap};{tele};{end}";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminho_arquivo, true))
                {
                    sw.WriteLine(linha);
                }

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                text_nome.Clear();
                text_email.Clear();
                text_cpf.Clear();
                text_zap.Clear();
                text_tele.Clear();
                text_cep.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void text_cep_Leave(object sender, EventArgs e)
        {
            buscar_end();
        }
    }
}
