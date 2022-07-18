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
            return await _context.Players.Where(prop => prop.TeamId == teamId).ToListAsync();
        }
    }
}
