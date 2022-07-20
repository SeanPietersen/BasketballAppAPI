using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ICoachContract
    {
        IEnumerable<CoachDto> GetAllCoachesForTeam(int teamId);
        ApiResult<CoachDto> GetCoachByIdForTeam(int teamId, int coachId);
    }
}
