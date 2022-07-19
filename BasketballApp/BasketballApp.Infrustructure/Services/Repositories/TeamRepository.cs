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

        public async Task<Team> GetTeamByIdAsync(int teamId, bool includePlayers = false, bool includeCoaches = false)
        {
            if (includePlayers && includeCoaches)
            {
                return await _context.Teams.Include(coaches => coaches.Coaches).Include(players => players.Players)
                    .Where(team => team.TeamId == teamId).FirstOrDefaultAsync();
            }

            if (includePlayers)
            {
                return await _context.Teams.Include(players => players.Players)
                    .Where(team => team.TeamId == teamId).FirstOrDefaultAsync();
            }

            if (includeCoaches)
            {
                return await _context.Teams.Include(coaches => coaches.Coaches)
                    .Where(team => team.TeamId == teamId).FirstOrDefaultAsync();
            }
            return await _context.Teams.Where(team => team.TeamId == teamId).FirstOrDefaultAsync();
        }

        public async Task<Team> CreateTeamAsync(Team team)
        {
            var entity = await _context.Teams.AddAsync(team);

            if (entity.State == EntityState.Added)
            {
                _context.SaveChanges();
            }

            return entity.Entity;
        }

        public async Task<Team> GetTeamByNameAsync(string name)
        {
            try
            {
                return await _context.Teams.Where(s => s.Name == name).FirstOrDefaultAsync<Team>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
