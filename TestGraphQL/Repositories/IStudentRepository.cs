using TestGraphQL.Models;

namespace TestGraphQL.Repositories
{
    public interface IStudentRepository
    {
        // como é um exemplo de graphql, não vou criar métodos de update, delete, etc
        Task<IEnumerable<Student>> GetAll();
        Task Add(Student student);
    }
}
