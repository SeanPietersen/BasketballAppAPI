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
        public ApiResult<IEnumerable<CoachDto>> GetAllCoachesForTeam(int teamId)
        {
            var team = _teamRepository.GetTeamByIdAsync(teamId, false, true).Result;

            if (team == null)
            {
                return new ApiResult<IEnumerable<CoachDto>>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }

            var coaches = team.Coaches;

            var result = _mapper.Map<IEnumerable<CoachDto>>(coaches);
            return new ApiResult<IEnumerable<CoachDto>>()
            {
                IsSuccess = true,
                Body = result
            };

        }

        public ApiResult<CoachDto> GetCoachByIdForTeam(int teamId, int coachId)
        {

            var team = _teamRepository.GetTeamByIdAsync(teamId, false, true).Result;

            if (team == null)
            {
                return new ApiResult<CoachDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }
            var coach = _coachRepository.GetCoachByIdForTeamAsync(teamId, coachId).Result;

            if (coach == null)
            {
                return new ApiResult<CoachDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Coach Does Not Exist" }
                };
            }

            var result = _mapper.Map<CoachDto>(coach);
            return new ApiResult<CoachDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }
    }
}
