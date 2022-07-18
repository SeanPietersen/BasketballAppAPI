using BasketballApp.Domain;
using BasketballApp.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly BasketballAppContext _context;

        public PlayerRepository(BasketballAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Player>> GetAllPlayersForTeamAsync(int teamId)
        {
            return await _context.Players.Where(team => team.TeamId == teamId).ToListAsync();
        }

        public async Task<Player> GetPlayerByIdAsync(int teamId, int playerId)
        {
            return await _context.Players.Where(team => team.TeamId == teamId && team.PlayerId == playerId).FirstOrDefaultAsync();
        }
    }
}
