using Markbook.Models;
using Markbook.Models.Request;
using Markbook.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Markbook.Services;

public interface IAssessmentService
{
    public StudentResponse GetAllAssessments();

}

public class AssessmentService : IAssessmentService
{
    private readonly MarkbookContext _context;

    public AssessmentService(MarkbookContext context)
    {
        _context = context;
    }

    public StudentResponse GetAllAssessments()
    {
        return null;
    }
    
}