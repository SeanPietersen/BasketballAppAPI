using BasketballApp.Domain;
using BasketballApp.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public class CoachRepository : ICoachRepository
    {
        private readonly BasketballAppContext _context;

        public CoachRepository(BasketballAppContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Coach>> GetAllCoachesForTeamAsync(int teamId)
        {
            return await _context.Coaches.Where(c => c.TeamId == teamId).ToListAsync();
        }

        public async Task<Coach> GetCoachByIdForTeamAsync(int teamId, int coachId)
        {
            return await _context.Coaches.Where(c => c.TeamId == teamId && c.CoachId == coachId).FirstOrDefaultAsync();
        }
    }
}
