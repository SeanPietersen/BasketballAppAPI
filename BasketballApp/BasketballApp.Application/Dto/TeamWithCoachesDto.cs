namespace BasketballApp.Application.Dto
{
    public class TeamWithCoachesDto : TeamDto
    {
        public int NumberOfCoaches
        {
            get
            {
                return Coach.Count;
            }
        }
        public ICollection<CoachDto> Coach { get; set; } = new List<CoachDto>();
    }
}
