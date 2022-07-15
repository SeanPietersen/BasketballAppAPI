using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasketballApp.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/teams")]
    public class TeamController : Controller
    {
        private readonly ITeamContract _teamContract;
        public TeamController(ITeamContract teamContract)
        {
            _teamContract = teamContract;

        }

        [HttpGet]
        public ActionResult<IEnumerable<TeamDto>> GetAllTeams()
        {
            var teams = _teamContract.GetAllTeams();

            return Ok(teams);

        }
    }
}
