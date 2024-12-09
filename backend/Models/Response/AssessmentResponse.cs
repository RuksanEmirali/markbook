namespace Markbook.Models.Response
{
    public class AssessmentResponse
    {
        public List<Assessment>? Assessments { get; set; }

        public void SetList(List<Assessment> AssessmentList)
        {
            Assessments = new List<Assessment>();
            foreach (var assessment in AssessmentList)
            {
                Assessment assessment1 = new Assessment()
                {
                    Id = assessment.Id,
                    TestName = assessment.TestName,
                    Year = assessment.Year,
                    Type = assessment.Type,
                    MarksAvailable = assessment.MarksAvailable,
                    MarksAchieved = assessment.MarksAchieved,
                };

                Assessments.Add(assessment1);
            }
        }
    }
}