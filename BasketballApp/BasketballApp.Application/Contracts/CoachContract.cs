using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Infrustructure.Services.Repositories;

namespace BasketballApp.Application.Contracts
{
    public class CoachContract : ICoachContract
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ICoachRepository _coachRepository;
        private readonly IMapper _mapper;

        public CoachContract(ITeamRepository teamRepository, ICoachRepository coachRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _coachRepository = coachRepository;
            _mapper = mapper;
        }
        public IEnumerable<CoachDto> GetAllCoachesForTeam(int teamId)
        {
            var team = _teamRepository.GetTeamByIdAsync(teamId, false, true).Result;

            if (team == null)
            {
                return null;
            }

            var coaches = team.Coaches;

            return _mapper.Map<IEnumerable<CoachDto>>(coaches);

        }

        public CoachDto GetCoachByIdForTeam(int teamId, int coachId)
        {

            var team = _teamRepository.GetTeamByIdAsync(teamId, false, true).Result;

            if (team == null)
            {
                return null;
            }
            var coach = _coachRepository.GetCoachByIdForTeamAsync(teamId, coachId).Result;

            if (coach == null)
            {
                return null;
            }

            return _mapper.Map<CoachDto>(coach);
        }
    }
}
