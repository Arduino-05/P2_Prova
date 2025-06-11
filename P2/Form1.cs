namespace P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicia_arquivo();

        }
        private string caminho_arquivo = "c:/Users/lardu/Documents/usuario.csv";


        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = text_login.Text.Trim();
            string senha = text_senha.Text.Trim();

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Esta faltando dados");
                return;
            }

            if (!File.Exists(caminho_arquivo))
            {
                MessageBox.Show("Banco de dados nao encontrado");
                return;
            }

            string[] linhas = File.ReadAllLines(caminho_arquivo);

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',');

                if (dados.Length == 2)
                {
                    string logins = dados[0];
                    string senhas = dados[1];

                    if (logins.Equals(login, StringComparison.OrdinalIgnoreCase) && senhas == senha)
                    {
                        MessageBox.Show("Bem vindo");
                        this.Hide();
                        menu Menu = new menu();
                        Menu.ShowDialog();
                        this.Close();
                        return;
                    }
                }
            }

            MessageBox.Show("Dados invalidos");
        }


        private void inicia_arquivo()
        {
            using (StreamWriter aq = new StreamWriter(caminho_arquivo))
            {
                aq.WriteLine("Login,Senha");
            }
        }

    }
}
