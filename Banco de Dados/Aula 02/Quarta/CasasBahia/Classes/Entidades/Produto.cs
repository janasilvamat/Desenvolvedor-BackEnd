using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia.Classes.Entidades
{
    internal class Produto
    {

        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        //Construtor
        public Produto(string nomeDoProduto, int quantidadeDeProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDeProduto = quantidadeDeProduto;
            ValorDoProduto = valorDoProduto;
        }

        //Método para exibir as informações do produto
        public void ExibirDados()
        {
            Console.WriteLine("\n--Dados do Produto--");
            Console.WriteLine($"\nCódigo do Produto: {CodigoDoProduto}");
            Console.WriteLine($"Nome do Produto: {NomeDoProduto}");
            Console.WriteLine($"Quantidade do Produto: {QuantidadeDeProduto}");
            Console.WriteLine($"Valor do Produto: {ValorDoProduto:C}");
        }

    }
}
