using AutoMapper;
using BasketballApp.Application.Profiles;

namespace BasketballApp.Tests
{
    public class ContextTest
    {
        public static IMapper _mapper;

        public ContextTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new UserProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }
    }
}
