using Microsoft.EntityFrameworkCore;
using TestGraphQL.Data;
using TestGraphQL.Models;

namespace TestGraphQL.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Student student)
        {
            // não vou criar pois é apenas um teste mas o ideal seria ter validações como,
            // por exemplo, se já existe aluno cadastrado com mesmo nome...
            // e em alguma parte da aplicação será necessário tratar exceções, mas também não vou fazer isso agora

            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _dbContext.Students.ToListAsync();
            return students;
        }
    }
}
