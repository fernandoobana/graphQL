using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestGraphQL.Models;

namespace TestGraphQL.Data.ContextConfiguration
{
    public class StudentContextConfiguration : IEntityTypeConfiguration<Student>
    {
        public StudentContextConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "João",
                    Age = 25
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Maria",
                    Age = 30
                }
            );
        }
    }
}
