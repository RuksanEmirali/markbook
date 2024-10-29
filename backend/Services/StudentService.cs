using Markbook.Models.Response;

namespace Markbook.Services;

public interface IStudentService
{
    public StudentResponse GetAllStudents();
}

public class StudentService : IStudentService
{
    private readonly MarkbookContext _context;

    public StudentService(MarkbookContext context)
    {
        _context = context;
    }

    public StudentResponse GetAllStudents()
    {
        StudentResponse studentResponse = new StudentResponse() {Students = _context.Students.ToList()};
        return studentResponse;
    }
}