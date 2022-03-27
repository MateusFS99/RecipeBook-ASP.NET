using Microsoft.EntityFrameworkCore;
using RecipeBook_ASP.NET.Models;

namespace RecipeBook_ASP.NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Receita>? receitas { get; set; }

        public DbSet<Ingrediente>? ingredientes { get; set; }

        public DbSet<ReceitaIngrediente>? receitasIngredientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ReceitaIngrediente>()
                .HasKey(AD => new { AD.receitaId, AD.ingredienteId });

            builder.Entity<Receita>()
                .HasData(new List<Receita>(){
                    new Receita(1, "Feijoada", ""),
                    new Receita(2, "Cuzcuz", ""),
                    new Receita(3, "Brigadeiro", ""),
                    new Receita(4, "Bolo de Chocolate", "")
                });

            builder.Entity<Ingrediente>()
                .HasData(new List<Ingrediente>{
                    new Ingrediente(1, "Feijão"),
                    new Ingrediente(2, "Fubá"),
                    new Ingrediente(3, "Chocolate"),
                    new Ingrediente(4, "Farinha")
                });

            builder.Entity<ReceitaIngrediente>()
                .HasData(new List<ReceitaIngrediente>() {
                    new ReceitaIngrediente() {receitaId = 1, ingredienteId = 1 },
                    new ReceitaIngrediente() {receitaId = 2, ingredienteId = 2 },
                    new ReceitaIngrediente() {receitaId = 3, ingredienteId = 3 },
                    new ReceitaIngrediente() {receitaId = 4, ingredienteId = 3 },
                    new ReceitaIngrediente() {receitaId = 4, ingredienteId = 4 },
                });
        }
    }
}