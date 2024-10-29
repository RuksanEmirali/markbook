using Markbook.Models.Response;
using Markbook.Services;
using Microsoft.AspNetCore.Mvc;

namespace Markbook.Controllers
{
    [ApiController]
    [Route("/student")]
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public ActionResult GetAllStudents()
        {
            try
            {
                StudentResponse studentResponse = _service.GetAllStudents();
                return Ok(studentResponse);
            }
            catch
            {
                return BadRequest("List of students not found");
            }
        }
    }
}