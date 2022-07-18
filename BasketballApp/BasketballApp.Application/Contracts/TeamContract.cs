using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Infrustructure.Services.Repositories;

namespace BasketballApp.Application.Contracts
{
    public class TeamContract : ITeamContract
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        public TeamContract(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TeamDto>> GetAllTeams()
        {
            var teamEntities = await _teamRepository.GetAllTeamsAsync();

            return _mapper.Map<IEnumerable<TeamDto>>(teamEntities);
        }

        public async Task<TeamDto> GetTeamByTeamId(int teamId, bool includePlayers = false, bool includeCoaches = false)
        {
            var team = await _teamRepository.GetTeamByIdAsync(teamId, includePlayers, includeCoaches);

            if(team == null)
            {
                return null;
            }
            
            if(includePlayers && includeCoaches)
            {
                return (_mapper.Map<TeamWithPlayersAndCoachesDto>(team));
            }

            if(includePlayers)
            {
                return (_mapper.Map<TeamWithPlayersDto>(team));
            }

            if(includeCoaches)
            {
                return (_mapper.Map<TeamWithCoachesDto>(team));
            }

            return (_mapper.Map<TeamDto>(team));
        }
    }
}
