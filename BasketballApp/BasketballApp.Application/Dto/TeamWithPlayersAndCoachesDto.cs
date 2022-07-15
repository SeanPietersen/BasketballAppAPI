namespace BasketballApp.Application.Dto
{
    public class TeamWithPlayersAndCoachesDto : TeamDto
    {
        public int NumberOfPlayers
        {
            get
            {
                return Player.Count;
            }
        }

        public ICollection<PlayerDto> Player { get; set; } = new List<PlayerDto>();
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
