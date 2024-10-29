using Markbook.Models;

namespace Markbook.SeedData
{
    public class SeedStudents
    {
        private readonly MarkbookContext _context;

        public SeedStudents(MarkbookContext context)
        {
            _context = context;
        }

        private readonly IList<Student>  seedStudentsData = new List<Student>
        {
            new Student() 
            {
                Id = 1,
                Forename = "Ruksan",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 2,
                Forename = "Aliye",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Cedars,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 3,
                Forename = "Orbay",
                Surname = "Emirali",
                Gender = Gender.Male,
                House = House.Collinson,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 4,
                Forename = "Matthew",
                Surname = "Whitmore",
                Gender = Gender.Male,
                House = House.School,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 5,
                Forename = "Arlo",
                Surname = "Emirali-Ray",
                Gender = Gender.NB,
                House = House.Cedars,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 6,
                Forename = "Emete",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.FourthForm
            },
            new Student() 
            {
                Id = 7,
                Forename = "Ruksan",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 8,
                Forename = "Aliye",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Cedars,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 9,
                Forename = "Orbay",
                Surname = "Emirali",
                Gender = Gender.Male,
                House = House.Collinson,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 10,
                Forename = "Matthew",
                Surname = "Whitmore",
                Gender = Gender.Male,
                House = House.School,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 11,
                Forename = "Arlo",
                Surname = "Emirali-Ray",
                Gender = Gender.NB,
                House = House.Cedars,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 12,
                Forename = "Emete",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.Remove
            },
            new Student() 
            {
                Id = 13,
                Forename = "Ruksan",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 14,
                Forename = "Aliye",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Cedars,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 15,
                Forename = "Orbay",
                Surname = "Emirali",
                Gender = Gender.Male,
                House = House.Collinson,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 16,
                Forename = "Matthew",
                Surname = "Whitmore",
                Gender = Gender.Male,
                House = House.School,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 17,
                Forename = "Arlo",
                Surname = "Emirali-Ray",
                Gender = Gender.NB,
                House = House.Cedars,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 18,
                Forename = "Emete",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.FifthForm
            },
            new Student() 
            {
                Id = 19,
                Forename = "Ruksan",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 20,
                Forename = "Aliye",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Cedars,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 21,
                Forename = "Orbay",
                Surname = "Emirali",
                Gender = Gender.Male,
                House = House.Collinson,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 22,
                Forename = "Matthew",
                Surname = "Whitmore",
                Gender = Gender.Male,
                House = House.School,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 23,
                Forename = "Arlo",
                Surname = "Emirali-Ray",
                Gender = Gender.NB,
                House = House.Cedars,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 24,
                Forename = "Emete",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.LowerSixth
            },
            new Student() 
            {
                Id = 25,
                Forename = "Ruksan",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.UpperSixth
            },
            new Student() 
            {
                Id = 26,
                Forename = "Aliye",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Cedars,
                Year = Year.UpperSixth
            },
            new Student() 
            {
                Id = 27,
                Forename = "Orbay",
                Surname = "Emirali",
                Gender = Gender.Male,
                House = House.Collinson,
                Year = Year.UpperSixth
            },
            new Student() 
            {
                Id = 28,
                Forename = "Matthew",
                Surname = "Whitmore",
                Gender = Gender.Male,
                House = House.School,
                Year = Year.UpperSixth
            },
            new Student() 
            {
                Id = 29,
                Forename = "Arlo",
                Surname = "Emirali-Ray",
                Gender = Gender.NB,
                House = House.Cedars,
                Year = Year.UpperSixth
            },
            new Student() 
            {
                Id = 30,
                Forename = "Emete",
                Surname = "Emirali",
                Gender = Gender.Female,
                House = House.Atkinson,
                Year = Year.UpperSixth
            },
        };
        public void SeedStudent()
        {
            if (!_context.Students.Any())
            {
                _context.Students.AddRange(seedStudentsData);
                _context.SaveChanges();
            }
        }
    }
}