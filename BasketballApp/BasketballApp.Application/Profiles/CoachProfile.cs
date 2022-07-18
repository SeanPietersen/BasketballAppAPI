using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;

namespace BasketballApp.Application.Profiles
{
    public class CoachProfile : Profile
    {
        public CoachProfile()
        {
            CreateMap<Coach, CoachDto>();
        }
    }
}
