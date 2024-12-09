using Markbook.Models;
using Markbook.Models.Request;
using Markbook.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Markbook.Services;

public interface IAssessmentService
{
    public AssessmentResponse GetAllAssessments();

}

public class AssessmentService : IAssessmentService
{
    private readonly MarkbookContext _context;

    public AssessmentService(MarkbookContext context)
    {
        _context = context;
    }

    public AssessmentResponse GetAllAssessments()
    {
        AssessmentResponse assessmentResponse = new AssessmentResponse() {Assessments = _context.Assessments.ToList()};
        return assessmentResponse;
    }
    
}