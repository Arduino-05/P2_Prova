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
                carregar_produtos();
                text_nome.Clear();
                text_preco.Clear();
                text_descricao.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel salvar o produto");
            }
        }

        private void carregar_produtos()
        {
            if (!File.Exists(caminho_arquivo))
                return;

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Nome");
            tabela.Columns.Add("Preço");
            tabela.Columns.Add("Descrição");

            try
            {
                string[] linha = File.ReadAllLines(caminho_arquivo);

                for (int i = 1; i < linha.Length; i++)
                {
                    string[] dados = linha[i].Split(',');
                    if (dados.Length == 3)
                        tabela.Rows.Add(dados);


                }
                data_produto.DataSource = tabela;

            }
            catch
            {
                MessageBox.Show("Dados nao carregados");
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            carregar_produtos();
        }

        private void data_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_produto.Rows[e.RowIndex];
                text_nome.Text = row.Cells[0].Value?.ToString();
                text_preco.Text = row.Cells[1].Value?.ToString();
                text_descricao.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (data_produto.CurrentRow == null) return;
            int index = data_produto.CurrentRow.Index;
            string[] linhas = File.ReadAllLines(caminho_arquivo).ToArray();
            if (index + 1 >= linhas.Length) return;
            string novaLinha = $"{text_nome.Text};{text_preco.Text};{text_descricao.Text}";
            linhas[index + 1] = novaLinha;
            File.WriteAllLines(caminho_arquivo, linhas);
            MessageBox.Show("Produto editado com sucesso!");
            carregar_produtos();
            text_nome.Clear();
            text_preco.Clear();
            text_descricao.Clear();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (data_produto.CurrentRow == null) return;
            int index = data_produto.CurrentRow.Index;
            List<string> linhas = File.ReadAllLines(caminho_arquivo).ToList();
            if (index + 1 >= linhas.Count) return;
            linhas.RemoveAt(index + 1);
            File.WriteAllLines(caminho_arquivo, linhas);
            MessageBox.Show("Produto deletado com sucesso!");
            carregar_produtos();
            text_nome.Clear();
            text_preco.Clear();
            text_descricao.Clear();
        }
    }
}
