using Microsoft.AspNetCore.Mvc;
using TestGraphQL.Models;
using TestGraphQL.Repositories;

namespace TestGraphQL.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var products = _studentRepository.GetAll();

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent([FromBody] Student student)
        {
            await _studentRepository.Add(student);
            return Ok();
        }
    }
}
