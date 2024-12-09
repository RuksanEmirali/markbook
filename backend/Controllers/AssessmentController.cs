using Markbook.Models;
using Markbook.Services;
using Microsoft.AspNetCore.Mvc;

namespace Markbook.Controllers
{
    [ApiController]
    [Route("/assessment")]
    public class AssessmentController : Controller
    {
        private readonly IAssessmentService _service;
        public AssessmentController(IAssessmentService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public ActionResult GetAllAssessments()
        {
            try
            {
                // StudentResponse studentResponse = _service.GetAllStudents();
                // return Ok(studentResponse);
                return Ok();

            }
            catch
            {
                return BadRequest("List of students not found");
            }
        }
    }
}