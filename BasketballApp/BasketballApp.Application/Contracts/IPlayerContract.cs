﻿using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface IPlayerContract
    {
        IEnumerable<PlayerDto> GetAllPlayersForTeam(int teamId);
        ApiResult<PlayerDto> GetPlayerById(int teamId, int playerId);

    }
}
