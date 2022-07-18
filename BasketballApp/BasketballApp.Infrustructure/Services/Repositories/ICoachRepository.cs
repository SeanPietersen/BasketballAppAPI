using BasketballApp.Domain;

namespace BasketballApp.Infrustructure.Services.Repositories
{
    public interface ICoachRepository
    {
        Task<IEnumerable<Coach>> GetAllCoachesForTeamAsync(int teamId);
        Task<Coach> GetCoachByIdForTeamAsync(int teamId, int coachId);

    }
}
