using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            iniciar_arquivo();
        }

        private string caminho_arquivo = "c:/Users/lardu/Documents/produtos.csv";

        private void iniciar_arquivo()
        {
            if (!File.Exists(caminho_arquivo))
            {
                using (StreamWriter aq = new StreamWriter(caminho_arquivo))
                {
                    aq.WriteLine("Nome;Preço;Descricao");
                }
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nome = text_nome.Text.Trim();
            string preco = text_preco.Text.Trim();
            string descricao = text_descricao.Text.Trim();

            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(preco) ||
                string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Esta faltando dados");
            }

            string linha = $"{nome},{preco},{descricao}";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminho_arquivo, true))
                {
                    sw.WriteLine(linha);
                }
                MessageBox.Show("Produto criado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_nome.Clear();
                text_preco.Clear();
                text_descricao.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel salvar o produto");
            }
        }
    }
}
