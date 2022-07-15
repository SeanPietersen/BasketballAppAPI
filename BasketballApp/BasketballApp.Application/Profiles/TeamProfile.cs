using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;

namespace BasketballApp.Application.Profiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDto>();
            CreateMap<Team, TeamWithPlayersAndCoachesDto>();
            CreateMap<Team, TeamWithPlayersDto>();
            CreateMap<Team, TeamWithCoachesDto>();
        }
    }
}
