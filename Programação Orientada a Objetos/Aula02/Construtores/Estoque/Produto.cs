

namespace Estoque
{
    internal class Produto
    {
        //Campos 
        string nome;
        int quantidade;
        double preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        //Construtor
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        //Métodos
        public void AdicionarProdutos(int qtd)
        {
           quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }   

        public double ValorTotal()
        {
            return quantidade * preco;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto: {nome}, Quantidade: {quantidade},Preço unitário: R$ {preco:c}, Valor total: R$ {ValorTotal():c}");  
        }
    }
}
