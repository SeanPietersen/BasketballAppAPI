using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasketballApp.API.Controllers
{
    [Route("api/team/{teamId}/coach")]
    [Authorize]
    [ApiController]
    public class CoachController : Controller
    {
        private readonly ICoachContract _coachContract;

        public CoachController(ICoachContract coachContract)
        {
            _coachContract = coachContract;
        }

        [HttpGet]
        public ActionResult<CoachDto> GetAllCoachesForTeam(int teamId)
        {
            var coaches = _coachContract.GetAllCoachesForTeam(teamId);

            if (coaches == null)
            {
                return NotFound();
            }

            return Ok(coaches);
        }

        [HttpGet("{coachId}")]
        public ActionResult<CoachDto> GetCoachByIdForTeam(int teamId, int coachId)
        {
            var coach = _coachContract.GetCoachByIdForTeam(teamId, coachId);

            if (coach == null)
            {
                return NotFound();
            }

            return Ok(coach);
        }
    }
}
