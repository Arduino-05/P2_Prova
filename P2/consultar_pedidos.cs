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
    public partial class consultar_pedidos : Form
    {
        public consultar_pedidos()
        {
            InitializeComponent();
            iniciar_arquivo();
        }

        private string caminho_clientes = "c:/Users/lardu/Documents/clientes.csv";
        private string caminho_pedidos = "c:/Users/lardu/Documents/pedidos.csv";

        private void iniciar_arquivo()
        {
            if (!File.Exists(caminho_clientes))
            {
                using (StreamWriter aq = new StreamWriter(caminho_clientes))
                {
                    aq.WriteLine("Nome;CPF;Email;Endereco;Telefone;Zap");
                }
            }
            else if (!File.Exists(caminho_pedidos))
            {
                using (StreamWriter aq_p = new StreamWriter(caminho_pedidos))
                {
                    aq_p.WriteLine("CPF;Itens,Total");
                }
            }
        }
        class PedidoInfo
        {
            public string Itens { get; set; }
            public string Total { get; set; }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cpf = text_cpf.Text.Trim();
            list_pedidos.Items.Clear();
            list_itens.Items.Clear();
            label_total.Text = "";

            if (string.IsNullOrEmpty(cpf)) return;

            var linhas = File.ReadAllLines(caminho_pedidos).Skip(1);

            foreach (var linha in linhas)
            {
                var partes = linha.Split(';');
                if (partes.Length != 3) continue;

                if (partes[0] == cpf)
                {
                    string itens = partes[1].Trim('"');
                    string total = partes[2];

                    var item = new ListViewItem($"Pedido - Total: R${total}");
                    item.Tag = new PedidoInfo { Itens = itens, Total = total };
                    list_pedidos.Items.Add(item);
                }
            }

            if (list_pedidos.Items.Count == 0)
            {
                MessageBox.Show("Nenhum pedido encontrado para este CPF.");
            }
        }

        private void list_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (list_pedidos.SelectedItems.Count == 0) return;

                list_itens.Items.Clear();
                label_total.Text = "";

                var itemSelecionado = list_pedidos.SelectedItems[0];
                var dados = (PedidoInfo)itemSelecionado.Tag;

                string[] itensSeparados = dados.Itens.Split('|');
                foreach (var i in itensSeparados)
                {
                    list_itens.Items.Add(i.Trim());
                }

                label_total.Text = $"Total: R${dados.Total}";
            }

        }
    }
}
