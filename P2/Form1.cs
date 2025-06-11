namespace P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private string caminho_arquivo = "c:/Users/lardu/Documents/usuario.csv";

        private void inicia_arquivo()
        {
            using (StreamWriter aq = new StreamWriter(caminho_arquivo))
            {
                aq.WriteLine("Login,Senha");
            }
        }

    }
}
