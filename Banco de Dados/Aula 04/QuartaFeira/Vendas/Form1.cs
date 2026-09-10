using Vendas.Classes.Contextos;

namespace Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
           CarregarDados();
        }
void CarregarDados()
        {
            try
            {
                VendasContexto vendasContexto = new VendasContexto();
                var listaDeVendas = vendasContexto.Vendas.ToList();
                dataGridView1.DataSource = listaDeVendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os dados: {ex.Message}");
            }   
        }

   

    }
}
