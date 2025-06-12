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
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
            iniciar_arquivos();
        }

        private string caminho_produtos = "c:/Users/lardu/Documents/produtos.csv";
        private string caminho_clientes = "c:/Users/lardu/Documents/clientes.csv";
        private string caminho_pedidos = "c:/Users/lardu/Documents/pedidos.csv";

        private void iniciar_arquivos()
        {
            if (!File.Exists(caminho_produtos))
            {
                using (StreamWriter aq_p = new StreamWriter(caminho_produtos))
                {
                    aq_p.WriteLine("Nome;Preço;Descricao");
                }
            }
            else if (!File.Exists(caminho_clientes))
            {
                using (StreamWriter aq_c = new StreamWriter(caminho_clientes))
                {
                    aq_c.WriteLine("Nome;CPF;Email;Endereco;Telefone;Zap");
                }
            }
            else if (!File.Exists(caminho_pedidos))
            {
                using (StreamWriter aq_c = new StreamWriter(caminho_pedidos))
                {
                    aq_c.WriteLine("CPF;Itens,Total");
                }
            }
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            var produtos = File.ReadAllLines(caminho_produtos);
            for (int i = 1; i < produtos.Length; i++)
            {
                var linha = produtos[i];
                var dados = linha.Contains(';') ? linha.Split(';') : linha.Split(',');

                if (dados.Length >= 3)
                {
                    select_produtos.Items.Add($"{dados[0]} - R${dados[1]} - {dados[2]}");
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cpf = text_cpf.Text.Trim();

            var linhas = File.ReadAllLines(caminho_clientes);
            foreach (var linha in linhas.Skip(1))
            {
                var dados = linha.Split(';');
                if (dados[1] == cpf)
                {
                    text_nome.Text = dados[0];
                    return;
                }
            }

            MessageBox.Show("Cliente não encontrado!");
        }

        List<string> itensPedido = new();
        double totalPedido = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (select_produtos.SelectedItem == null) return;

            var info = select_produtos.SelectedItem.ToString().Split(" - ");
            string nome = info[0];
            double preco = double.Parse(info[1].Replace("R$", ""));
            string descricao = info[2];

            int qtd = int.Parse(text_qtde.Text);
            double totalItem = qtd * preco;

            string itemFormatado = $"{nome};{preco};{descricao};{qtd};{totalItem}";
            itensPedido.Add(itemFormatado);

            list_itens.Items.Add($"{nome} x{qtd} - R${totalItem}");
            totalPedido += totalItem;
            label_total.Text = $"Total: R${totalPedido}";
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            string cpf = text_cpf.Text.Trim();

            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Tem que ter CPF.");
                return;
            }

            if (itensPedido.Count == 0)
            {
                MessageBox.Show("Coloque itens.");
                return;
            }

            var itensFormatados = itensPedido.Select(item =>
            {
                var partes = item.Split(';');
                string nome = partes[0];
                double preco = double.Parse(partes[1]);
                int qtd = int.Parse(partes[3]);
                return $"{nome} x{qtd} R${preco:F2}";
            });

            string itensString = string.Join("|", itensFormatados);

            string linha = $"{cpf};\"{itensString}\";{totalPedido:F2}";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminho_pedidos, true))
                {
                    sw.WriteLine(linha);
                }

                MessageBox.Show("Pedido salvo sucesso!");

                text_cpf.Clear();
                text_nome.Clear();
                text_qtde.Clear();
                select_produtos.SelectedIndex = -1;
                list_itens.Items.Clear();
                itensPedido.Clear();
                totalPedido = 0;
                label_total.Text = "Total: R$0,00";
            }
            catch (Exception)
            {
                MessageBox.Show($"Pedido cancelado");
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
    }
}
