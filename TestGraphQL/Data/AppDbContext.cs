using Microsoft.EntityFrameworkCore;
using TestGraphQL.Data.ContextConfiguration;
using TestGraphQL.Models;

namespace TestGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // criando massa de teste
            modelBuilder.ApplyConfiguration(new ProductContextConfiguration());
            modelBuilder.ApplyConfiguration(new StudentContextConfiguration());
        }

        // Adiciona os DbSets para cada entidade
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
