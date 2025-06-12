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
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            var produtos = File.ReadAllLines(caminho_produtos);
            foreach (var linha in produtos)
            {
                var dados = linha.Contains(';') ? linha.Split(';') : linha.Split(',');

                if (dados.Length >= 3)
                {
                    select_produtos.Items.Add($"{dados[0]} - {dados[1]} - R${dados[2]}");
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
    }
}
