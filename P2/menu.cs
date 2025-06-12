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
            menu cliente = new menu();
            cliente.ShowDialog();
            this.Close();
            return;
        }
    }
}
