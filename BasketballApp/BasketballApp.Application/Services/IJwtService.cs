using BasketballApp.Application.Dto;

namespace BasketballApp.Application.Services
{
    public interface IJwtService
    {
        string GenerateIdentityToken(UserDto userDto);
    }
}
