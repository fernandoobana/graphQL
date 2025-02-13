using System.ComponentModel.DataAnnotations;

namespace TestGraphQL.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
