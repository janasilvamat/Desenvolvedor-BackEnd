
namespace CasasBahia2.Classes.Entidades
{
    internal class Produtos
    {
        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }
        public decimal ValorDoProduto { get; set; }
        
        //Construtor
        public Produtos(string nome, int quantidade, decimal preco)
        {
            NomeDoProduto = nome;
            QuantidadeDeProduto = quantidade;
            ValorDoProduto = preco;
        }
    }
}
