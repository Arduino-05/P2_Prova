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
            string email = text_email.Text.Trim();
            string senha = text_senha.Text.Trim();

            if (string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Esta faltando dados");
                return;
            }

            string linha = $"{email};{senha}";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminho_arquivo, true))
                {
                    sw.WriteLine(linha);
                }

                MessageBox.Show("Usuario Cadastrado");
                carregar_usuarios();
                text_email.Clear();
                text_senha.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar");
            }
        }

        private void carregar_usuarios()
        {
            if (!File.Exists(caminho_arquivo))
                return;

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Email");
            tabela.Columns.Add("Senha");

            try
            {
                string[] linhas = File.ReadAllLines(caminho_arquivo);

                for (int i = 1; i < linhas.Length; i++)
                {
                    string[] dados = linhas[i].Split(';');
                    if (dados.Length == 2)
                        tabela.Rows.Add(dados);
                }

                data_usuarios.DataSource = tabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel carregar usuarios");
            }
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            carregar_usuarios();
        }

        private void data_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_usuarios.Rows[e.RowIndex];
                text_email.Text = row.Cells[0].Value?.ToString();
                text_senha.Text = row.Cells[1].Value?.ToString();
            }
        }




    }


}
