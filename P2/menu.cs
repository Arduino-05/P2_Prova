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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
            this.Close();
            return;
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
            this.Close();
            return;
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            pedidos pedidos = new pedidos();
            pedidos.ShowDialog();
            this.Close();
            return;
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuario usuarios = new usuario();
            usuarios.ShowDialog();
            this.Close();
            return;
        }
    }
}
