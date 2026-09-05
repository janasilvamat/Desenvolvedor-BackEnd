

using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class ProdutosContexto : DbContext
    {
        //Propriedades
        public DbSet<Produtos> Produtos { get; set; }

        //Método de configuração do contexto
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            //Configura o contexto para usar o banco de dados SQLite
            string caminho = @"Server=ECFP507D1319388\SQLEXPRESS03;Database=ProdutosCasasBahia; Trusted_Connection=True; TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            //Configura a tabela Produtos
            modeloDeConstrucao.Entity<Produtos>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);
            });
        }
    }
}
