using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propriedade para acessar a tabela de produtos
        public DbSet<Entidades.Produto> Produtos { get; set; }

        //Método para configurar a conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder opcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319388\SQLEXPRESS03;Database=ProdutosCasasBahia;Trusted_Connection=true; TrustServerCertificate=true;";
            opcaoDeConstrucao.UseSqlServer(config);
        }
        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao) //faz o mapeamento da classe
        {
            modeloDeConstrucao.Entity<Entidades.Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto); //Chave primária
                entidade.Property(e => e.NomeDoProduto); //Nome do produto é obrigatório e tem tamanho máximo de 100 caracteres
                entidade.Property(e => e.QuantidadeDeProduto); //Quantidade do produto é obrigatória
                entidade.Property(e => e.ValorDoProduto); //Valor do produto é obrigatório e tem tipo decimal com precisão de 18 e escala de 2
            });


        }
    }
}
