using APIPessoas.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APIPessoas.Models.Contextos
    public class ProdutosContexto : DbContext
{
    public DbSet<Produtos> Produtos { get; set; }

    //métodos

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string caminho = "";
        opcoesDeConstrucao.UseSqlite(caminho);
    }





