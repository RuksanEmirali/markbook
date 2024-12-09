namespace Markbook.Models
{
    public enum AssessmentType
    {
        Homework,
        EndOfUnitTest,
        EndOfYearTest,
        MockExam
    }

    public class Assessment
    {
        public int Id { get; set; }
        public string? TestName { get; set; }
        public Year Year { get; set; }
        public AssessmentType Type { get; set; }
        public int MarksAvailable { get; set; }
        public int MarksAchieved { get; set; }
    }
}