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
            var teams = _teamContract.GetAllTeams().Result;

            return Ok(teams);

        }

        [HttpGet("{teamId}")]
        public ActionResult<ApiResult<TeamDto>> GetTeamByTeamId([FromRoute] int teamId, bool includePlayers, bool includeCoaches)
        {
            var team = _teamContract.GetTeamByTeamId(teamId, includePlayers, includeCoaches).Result;

            return Ok(team);
        }

        [HttpPost("addTeam")]
        public ActionResult<ApiResult<TeamDto>> CreateTeam([FromBody] CreateTeamDto teamRequest)
        {
            var teamToCreate = _teamContract.CreateTeam(teamRequest).Result;

            return Ok(teamToCreate);
        }
    }
}
