using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ITeamContract
    {
        Task<IEnumerable<TeamDto>> GetAllTeams();
        Task <ApiResult<TeamDto>> GetTeamByTeamId(int teamId, bool includePlayers = false, bool includeCoaches = false);
        Task<ApiResult<TeamDto>> CreateTeam(CreateTeamDto teamDto);

    }
}
