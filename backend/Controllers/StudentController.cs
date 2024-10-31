using Markbook.Models.Request;
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

        [HttpGetAttribute("/{surname}")]
        public ActionResult GetBySurname([FromRoute] string surname)
        {
            try
            {
                StudentResponse studentResponse = _service.GetBySurname(surname);
                if (studentResponse != null)
                {
                return Ok(studentResponse);
                }
                else
                {
                    return BadRequest($"Student with surname {surname} doesn't exist");
                }
            }
            catch
            {
                return BadRequest($"Student with surname {surname} doesn't exist");
            }
        }

        [HttpGetAttribute("/search")]
        public ActionResult SearchStudent([FromQuery] SearchStudentRequest search)
        {
            try
            {
                StudentResponse studentResponse = _service.SearchStudent(search);
                if (studentResponse != null)
                {
                return Ok(studentResponse);
                }
                else
                {
                    return BadRequest("Student does not exist");
                }
            }
            catch
            {
                return BadRequest("Student does not exist");
            }
        }
    }

    
}