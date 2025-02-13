using TestGraphQL.Data;

namespace TestGraphQL.Models.GraphQl
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts([Service] AppDbContext context) => context.Products;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Student> GetStudents([Service] AppDbContext context) => context.Students;
    }
}
