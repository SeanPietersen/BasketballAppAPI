using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface IUserContract
    {
        Task<ApiResult<UserDto>> RegisterUser(RegisterUserDto userDto);
        Task<ApiResult<UserIdentityDto>> UserSigIn(UserSignInDto userDto);
        Task<IEnumerable<UserDto>> GetAllUsers();
        Task<ApiResult<UserDto>> GetUserById(int userId);
    }
}
