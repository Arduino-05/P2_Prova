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
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
        }

        private async void buscar_end()
        {
            string cep = text_cep.Text.Trim().Replace("-", "");

            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    string json = await client.GetStringAsync(url);

                    var endereco = JsonSerializer.Deserialize<ViaCepResponse>(json);

                    if (endereco != null && endereco.cep != null)
                    {
                        text_cep.Text = $"{endereco.cep} - {endereco.logradouro}, {endereco.bairro}, {endereco.localidade}-{endereco.uf}";
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

        }

        private void text_cep_Leave(object sender, EventArgs e)
        {
            buscar_end();
        }
    }
}
