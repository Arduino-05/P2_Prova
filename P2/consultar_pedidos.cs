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

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
