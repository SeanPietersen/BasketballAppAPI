using BasketballApp.Domain;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllPlayersForTeamAsync(int teamId);
        Task<Player> GetPlayerByIdAsync(int teamId, int playerId);

    }
}
