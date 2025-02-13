using Microsoft.EntityFrameworkCore;
using TestGraphQL.Data;
using TestGraphQL.Models;

namespace TestGraphQL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Product product)
        {
            // não vou criar pois é apenas um teste mas o ideal seria ter validações como,
            // por exemplo, se já existe produto cadastrado com mesmo nome...
            // e em alguma parte da aplicação será necessário tratar exceções, mas também não vou fazer isso agora

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products;
        }
    }
}
