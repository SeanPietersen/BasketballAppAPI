using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasketballApp.API.Controllers
{
    [Route("api/teams/{teamId}/players")]
    [Authorize]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly IPlayerContract _playerContract;

        public PlayerController(IPlayerContract playerContract)
        {
            _playerContract = playerContract;
        }

        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<PlayerDto>>> GetAllPlayersForTeam([FromRoute]int teamId)
        {
            var players = _playerContract.GetAllPlayersForTeam(teamId);

            return Ok(players);
        }

        [HttpGet("{playerId}")]
        public ActionResult<ApiResult<PlayerDto>> GetPlayerForTeam(int teamId, int playerId)
        {
            var player = _playerContract.GetPlayerById(teamId, playerId);

            return Ok(player);
        }


    }
}
