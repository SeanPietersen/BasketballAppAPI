using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;
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

        public async Task<ApiResult<TeamDto>> GetTeamByTeamId(int teamId, bool includePlayers = false, bool includeCoaches = false)
        {
            var team = await _teamRepository.GetTeamByIdAsync(teamId, includePlayers, includeCoaches);

            if(team == null)
            {
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }
            
            if(includePlayers && includeCoaches)
            {
                var result = (_mapper.Map<TeamWithPlayersAndCoachesDto>(team));
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = true,
                    Body = result
                };
                
            }

            if(includePlayers)
            {
                var result = (_mapper.Map<TeamWithPlayersDto>(team));
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = true,
                    Body = result
                };
            }

            if(includeCoaches)
            {
                var result = (_mapper.Map<TeamWithCoachesDto>(team));
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = true,
                    Body = result
                };

            }

            var resultTeam = (_mapper.Map<TeamDto>(team)); 
            return new ApiResult<TeamDto>()
            {
                IsSuccess = true,
                Body = resultTeam
            };
        }

        public async Task<ApiResult<TeamDto>> CreateTeam(CreateTeamDto teamDto)
        {
            var teamEntity = await _teamRepository.GetTeamByNameAsync(teamDto.Name);

            if (teamEntity!= null)
            {
                // team exists
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Already Exists" }
                };
            }

            var createdTeam = new Team()
            {
                Name = teamDto.Name,
                State = teamDto.State,
            };

            await _teamRepository.CreateTeamAsync(createdTeam);

            var createdTeamResult = _mapper.Map<TeamDto>(createdTeam);

            return new ApiResult<TeamDto>()
            {
                IsSuccess = true,
                Body = createdTeamResult
            };
        }

        public async Task<ApiResult<TeamDto>> DeleteTeam(int teamId)
        {
            var teamEntity = await _teamRepository.GetTeamByIdAsync(teamId);
            
            if(teamEntity == null)
            {
                return new ApiResult<TeamDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }

            _teamRepository.DeleteTeamAsync(teamEntity);

            await _teamRepository.SaveChangesAsync();

            var team = new TeamDto();

            var result = _mapper.Map(teamEntity, team);

            return new ApiResult<TeamDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }
    }
}
