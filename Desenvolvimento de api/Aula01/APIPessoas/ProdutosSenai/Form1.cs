using System.Net.Http.Json;
namespace ProdutosSenai
{
    public partial class Form1 : Form
    {
        private readonly HttpClient clienteHttp = new()
        {
            BaseAddress = new Uri("http://localhost:5293")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Botão Criar
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            mensagem = clienteHttp.GetStringAsync("Produto").Result;
            MessageBox.Show(mensagem);
        }
    }
}
