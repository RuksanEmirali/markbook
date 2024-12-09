namespace Markbook.Models
{
    public enum Gender
    {
        Male,
        Female,
        NB
    }

    public enum House
    {
        Atkinson,
        Cedars,
        Collinson,
        School
    }

    public enum Year
    {
        FourthForm,
        Remove,
        FifthForm,
        LowerSixth,
        UpperSixth
    } 

    public class Student
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public House House { get; set; }
        public Year Year { get; set; }
        public List<Assessment>? Assessments { get; set; }
    }
}