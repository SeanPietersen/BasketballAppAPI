using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ITeamContract
    {
        Task<IEnumerable<TeamDto>> GetAllTeams();
        Task <TeamDto> GetTeamByTeamId(int teamId, bool includePlayers = false, bool includeCoaches = false);

    }
}
