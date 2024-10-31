namespace Markbook.Models.Response
{
    public class StudentResponse
    {
        public List<Student>? Students { get; set; }

        public void SetList(List<Student> StudentList)
        {
            Students = new List<Student>();
            foreach (var student in StudentList)
            {
                Student student1 = new Student()
                {
                    Id = student.Id,
                    Forename = student.Forename,
                    Surname = student.Surname,
                    Gender = student.Gender,
                    House = student.House,
                    Year = student.Year
                };

                Students.Add(student1);
            }
        }
    }
}