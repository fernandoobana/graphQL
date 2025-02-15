using Microsoft.EntityFrameworkCore;
using TestGraphQL.Data;
using TestGraphQL.Models;
using TestGraphQL.Repositories;
using Xunit;

namespace TestGraphQL.Tests;

public class ProductRepositoryTests : IDisposable
{
    private readonly AppDbContext _context;
    private readonly ProductRepository _repository;

    public ProductRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new AppDbContext(options);
        _repository = new ProductRepository(_context);
    }

    [Fact]
    [Trait("Category", "ProductRepository")]
    public async Task Add_ShouldAddProduct()
    {
        // Arrange
        var product = new Product { Id = Guid.NewGuid(), Name = "Test Product", Price = 10.0m, Quantity = 5 };

        // Act
        await _repository.Add(product);
        var savedProduct = await _context.Products.FindAsync(product.Id);

        // Assert
        Assert.NotNull(savedProduct);
        Assert.Equal(product.Name, savedProduct.Name);
    }

    [Fact]
    [Trait("Category", "ProductRepository")]
    public async Task GetAll_ShouldReturnAllProducts()
    {
        // Arrange
        var products = new List<Product>
        {
            new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.0m, Quantity = 5 },
            new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 20.0m, Quantity = 10 }
        };

        await _context.Products.AddRangeAsync(products);
        await _context.SaveChangesAsync();

        // Act
        var result = await _repository.GetAll();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Product 1", result.First().Name);
        Assert.Equal("Product 2", result.Last().Name);
    }

    public void Dispose()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }
}
