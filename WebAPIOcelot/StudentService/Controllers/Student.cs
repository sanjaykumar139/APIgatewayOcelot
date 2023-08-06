using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //private readonly IStudentRepository _studentRepository;
        //public StudentController(IStudentRepository studentRepository) => (_studentRepository) = (studentRepository);
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Hello from Student");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            int result = id * 50;
            return Ok(result);
        }
    }
}