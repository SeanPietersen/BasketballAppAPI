using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Infrustructure.Services.Repositories;

namespace BasketballApp.Application.Contracts
{
    public class PlayerContract : IPlayerContract
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public PlayerContract(IPlayerRepository playerRepository, ITeamRepository teamRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public ApiResult<IEnumerable<PlayerDto>> GetAllPlayersForTeam(int teamId)
        {
            var team = _teamRepository.GetTeamByIdAsync(teamId, true, false).Result;

            if (team == null)
            {
                return new ApiResult<IEnumerable<PlayerDto>>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }

            var players = team.Players;
            var result = (_mapper.Map<IEnumerable<PlayerDto>>(players));
            return new ApiResult<IEnumerable<PlayerDto>>()
            {
                IsSuccess = true,
                Body = result
            };
        }

        public ApiResult<PlayerDto> GetPlayerById(int teamId, int playerId)
        {
            var team = _teamRepository.GetTeamByIdAsync(teamId, true, false).Result;

            if (team == null)
            {
                return new ApiResult<PlayerDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }

            var player = _playerRepository.GetPlayerByIdAsync(teamId, playerId).Result;

            if (player == null)
            {
                return new ApiResult<PlayerDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Player Does Not Exist" }
                };
            }

            var result = _mapper.Map<PlayerDto>(player);
            return new ApiResult<PlayerDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }
    }
}
