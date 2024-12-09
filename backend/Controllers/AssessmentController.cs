using Markbook.Models;
using Markbook.Models.Response;
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
                AssessmentResponse assessmentResponse = _service.GetAllAssessments();
                return Ok(assessmentResponse);

            }
            catch
            {
                return BadRequest("List of assessments not found");
            }
        }
    }
}