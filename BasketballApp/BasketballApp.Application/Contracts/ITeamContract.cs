using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface ITeamContract
    {
        Task<IEnumerable<TeamDto>> GetAllTeams();
    }
}
