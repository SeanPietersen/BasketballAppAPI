using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Contracts
{
    public interface IUserContract
    {
        Task<UserDto> RegisterUser(RegisterUserDto userDto);
        Task<UserIdentityDto> UserSigIn(UserSignInDto userDto);
        Task<IEnumerable<UserDto>> GetAllUsers();
        Task<UserDto> GetUserById(int userId);
    }
}
