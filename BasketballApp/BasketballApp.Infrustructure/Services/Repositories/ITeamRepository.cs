using BasketballApp.Domain;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetAllTeamsAsync();
        Task<Team> GetTeamByIdAsync(int teamId, bool includePlayers = false, bool includeCoaches = false);
    }
}
