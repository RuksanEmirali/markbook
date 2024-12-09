using Markbook.Models;

namespace Markbook.SeedData
{
    public class SeedAssessments
    {
        private readonly MarkbookContext _context;

        public SeedAssessments(MarkbookContext context)
        {
            _context = context;
        }

        private readonly IList<Assessment> seedAssessmentsData = new List<Assessment>
        {

        };
    }
}