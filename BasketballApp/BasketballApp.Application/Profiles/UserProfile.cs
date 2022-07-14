using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;

namespace BasketballApp.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, RegisterUserDto>();
            CreateMap<UserDto, RegisterUserDto>();
            CreateMap<RegisterUserDto, UserDto>();
        }
    }
}
