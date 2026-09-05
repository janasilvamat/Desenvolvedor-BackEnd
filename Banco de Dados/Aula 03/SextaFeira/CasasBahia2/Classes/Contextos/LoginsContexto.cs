
using CasasBahia2.Classes.Entidades;    
using Microsoft.EntityFrameworkCore;
namespace CasasBahia2.Classes.Contextos
{
    internal class LoginsContexto : DbContext
    {
        //Propriedades
        public DbSet<Logins> Logins { get; set; }

        //Método de configuração do contexto
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            //Configura o contexto para usar o banco de dados SQLite
            string caminho = @"Server=ECFP507D1319388\SQLEXPRESS03;Database=ProdutosCasasBahia; Trusted_Connection=True; TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            //Configura a tabela Logins
            modeloDeConstrucao.Entity<Logins>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Usuario);
                entidade.Property(e => e.Senha);
                entidade.Property(e => e.Regra);
            });
        }
    }
}
