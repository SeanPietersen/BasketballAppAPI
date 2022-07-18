using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;

namespace BasketballApp.Application.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<CreatePlayerDto, Player>();
            CreateMap<UpdatePlayerDto, Player>();
            CreateMap<Player, UpdatePlayerDto>();
        }
    }
}
