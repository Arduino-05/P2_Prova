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

        private string caminho_pedidos = "c:/Users/lardu/Documents/pedidos.csv";
        private string caminho_clientes = "c:/Users/lardu/Documents/clientes.csv";

        private void iniciar_arquivos()
        {
            if (!File.Exists(caminho_pedidos))
            {
                using (StreamWriter aq_p = new StreamWriter(caminho_pedidos))
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
        }
    }
}
