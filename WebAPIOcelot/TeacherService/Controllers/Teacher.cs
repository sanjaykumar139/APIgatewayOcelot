using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeacherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        //private readonly ITeacherRepository _repository;
        //public TeacherController(ITeacherRepository repository) => _repository = repository;
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Hello from Teacher");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            int result = id * 40;
            return Ok(result);
        }
    }
}