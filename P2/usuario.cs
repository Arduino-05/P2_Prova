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
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private string caminho_arquivo = "c:/Users/lardu/Documents/usuario.csv";

        private void iniciar_arquivo()
        {
            if (!File.Exists(caminho_arquivo))
            {
                using (StreamWriter aq = new StreamWriter(caminho_arquivo))
                {
                    aq.WriteLine("Login,Senha");
                }
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }


}
