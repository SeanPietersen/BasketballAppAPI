using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasketballApp.API.Controllers
{
    [ApiController]

    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserContract _userContract;

        public UserController(IUserContract userContract)
        {
            _userContract = userContract;
        }

        [HttpPost("register")]
        public ActionResult<ApiResult<UserDto>> RegisterUser([FromBody] RegisterUserDto userDto)
        {
            var user = _userContract.RegisterUser(userDto).Result;

            return Ok(user);
        }

        [HttpPost("signin")]
        public ActionResult<ApiResult<UserIdentityDto>> UserSignIn([FromBody] UserSignInDto userDto)
        {
            var user = _userContract.UserSigIn(userDto).Result;

            return Ok(user);
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetAllUsers()
        {

            var user = _userContract.GetAllUsers().Result;

            return Ok(user);
        }

        [Authorize]
        [HttpGet("{userId}")]
        public ActionResult<ApiResult<UserDto>> GetUserById(int userId)
        {
            var user = _userContract.GetUserById(userId).Result;

            return Ok(user);
        }
    }
}
