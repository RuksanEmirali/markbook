namespace Markbook.Models.Request;

public class SearchStudentRequest
{
        public int? Id { get; set; }
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public Gender? Gender { get; set; }
        public House? House { get; set; }
        public Year? Year { get; set; }

        public string SearchText()
        {
            return Id.ToString() + Forename + Surname + Gender + House + Year;
        }

        public string Filters => SearchText() == null ? "" : $"&id={Id}&name={Forename}&surname={Surname}&gender={Gender}&house={House}&year={Year}";
}