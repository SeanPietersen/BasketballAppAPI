using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasketballApp.API.Controllers
{
    [Route("api/teams/{teamId}/player")]
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
        public ActionResult<IEnumerable<PlayerDto>> GeatAllPlayersForTeam(int teamId)
        {
            var players = _playerContract.GetAllPlayersForTeam(teamId);

            if(players == null)
            {
                return NotFound();
            }

            return Ok(players);
        }
    }
}
