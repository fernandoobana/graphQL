using TestGraphQL.Repositories;

namespace TestGraphQL.Models.GraphQl
{
    public class Mutation
    {
        public async Task<bool> AddProduct([Service] IProductRepository productRepository, Product product)
        {
            await productRepository.Add(product);

            return true;
        }
    }
}
