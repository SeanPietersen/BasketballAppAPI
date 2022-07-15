using BasketballApp.Domain;
using BasketballApp.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BasketballAppContext _context;

        public TeamRepository(BasketballAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.OrderBy(name => name.Name).ToListAsync();
        }
    }
}
