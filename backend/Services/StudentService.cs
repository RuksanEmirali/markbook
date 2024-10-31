using Markbook.Models;
using Markbook.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Markbook.Services;

public interface IStudentService
{
    public StudentResponse GetAllStudents();
    public StudentResponse GetBySurname(string surname);
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

    public StudentResponse GetBySurname(string surname)
    {
        List<Student> students = _context
                                .Students.Where(student => student.Surname.ToLower() == surname.ToLower())
                                .ToList();
        if (students.Count() != 0)
        {
        StudentResponse studentResponse = new StudentResponse();
        studentResponse.SetList(students);
        return studentResponse;
        }
        else
        {
            return null;
        }
    }

    
}