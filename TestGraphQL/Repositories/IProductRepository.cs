using TestGraphQL.Models;

namespace TestGraphQL.Repositories
{
    public interface IProductRepository
    {
        // como é um exemplo de graphql, não vou criar métodos de update, delete, etc
        Task<IEnumerable<Product>> GetAll();
        Task Add(Product product);
    }
}
