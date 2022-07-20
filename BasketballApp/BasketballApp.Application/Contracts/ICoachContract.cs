using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ICoachContract
    {
        ApiResult<IEnumerable<CoachDto>> GetAllCoachesForTeam(int teamId);
        ApiResult<CoachDto> GetCoachByIdForTeam(int teamId, int coachId);
    }
}
