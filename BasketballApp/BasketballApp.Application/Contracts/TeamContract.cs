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
    }
}
