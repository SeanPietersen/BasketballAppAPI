using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ICoachContract
    {
        IEnumerable<CoachDto> GetAllCoachesForTeam(int teamId);
        CoachDto GetCoachByIdForTeam(int teamId, int coachId);
    }
}
