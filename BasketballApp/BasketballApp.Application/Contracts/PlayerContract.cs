using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Infrustructure.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IEnumerable<PlayerDto> GetAllPlayersForTeam(int teamId)
        {
            var team = _teamRepository.GetTeamByTeamIdAsync(teamId, true, false).Result;

            if(team == null)
            {
                return null;
            }

            var players = team.Players;
            return (_mapper.Map<IEnumerable<PlayerDto>>(players));
        }
    }
}
