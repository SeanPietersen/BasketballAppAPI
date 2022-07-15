using BasketballApp.Domain.Enums;

namespace BasketballApp.Application.Dto
{
    public class CoachDto
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsOfExperience { get; set; }
        public bool IsQualified { get; set; }
        public RankType Rank { get; set; }
    }
}
