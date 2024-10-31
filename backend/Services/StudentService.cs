using Markbook.Models;
using Markbook.Models.Request;
using Markbook.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Markbook.Services;

public interface IStudentService
{
    public StudentResponse GetAllStudents();
    public StudentResponse GetBySurname(string surname);
    public StudentResponse SearchStudent(SearchStudentRequest search);
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

    public StudentResponse SearchStudent(SearchStudentRequest search)
    {
        List<Student> students = _context.Students
                                .Where(s => search.Id == null || s.Id == search.Id)
                                .Where(s => search.Forename == null || s.Forename == search.Forename)
                                .Where(s => search.Surname == null || s.Surname == search.Surname)
                                .Where(s => search.Gender == null || s.Gender == search.Gender)
                                .Where(s => search.House == null || s.House == search.House)
                                .Where(s => search.Year == null || s.Year == search.Year)
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