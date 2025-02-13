using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestGraphQL.Models;

namespace TestGraphQL.Data.ContextConfiguration
{
    public class ProductContextConfiguration : IEntityTypeConfiguration<Product>
    {
        public ProductContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasData(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Product 1",
                        Description = "Description 1",
                        Price = 10.5m,
                        Quantity = 10
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Product 2",
                        Description = "Description 2",
                        Price = 20.5m,
                        Quantity = 20
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Abelha Product",
                        Description = "Description Abelha",
                        Price = 25m,
                        Quantity = 12
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zimbabué Product",
                        Description = "Teste Description",
                        Price = 40.5m,
                        Quantity = 4
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Best Product",
                        Description = "Besta Description",
                        Price = 2m,
                        Quantity = 1
                    }
            );
        }
    }
}
