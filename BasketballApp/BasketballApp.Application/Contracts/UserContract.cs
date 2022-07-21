using AutoMapper;
using BasketballApp.Application.Dto;
using BasketballApp.Application.Services;
using BasketballApp.Domain;
using BasketballApp.Infrastructure.Services.Repositories;

namespace BasketballApp.Application.Contracts
{
    public class UserContract : IUserContract
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public UserContract(IUserRepository userRepsitory, IMapper mapper, IJwtService jwtService)
        {
            _userRepository = userRepsitory;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var userEntities = await _userRepository.GetAllUsersAsync();
            return _mapper.Map<IEnumerable<UserDto>>(userEntities);
        }

        public async Task<ApiResult<UserDto>> GetUserById(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);

            if (user == null)
            {
                return new ApiResult<UserDto> ()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Team Does Not Exist" }
                };
            }

            var result = (_mapper.Map<UserDto>(user));
            return new ApiResult<UserDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }

        public async Task<ApiResult<UserDto>> RegisterUser(RegisterUserDto userDto)
        {
            //check if email exists
            var userEmailCheck = await _userRepository.GetUserByEmailAsync(userDto.Email);

            if (userEmailCheck != null)
            {
                // email exists
                return new ApiResult<UserDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Email Does Not Exist" }
                };
            }

            //creating a user
            var createdUser = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password
            };

            await _userRepository.RegisterUserAsync(createdUser);

            var result = _mapper.Map<UserDto>(createdUser);
            return new ApiResult<UserDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }

        public async Task<ApiResult<UserIdentityDto>> UserSigIn(UserSignInDto userDto)
        {
            //check if email exists
            var userEmailCheck = await _userRepository.GetUserByEmailAsync(userDto.Email);

            if (userEmailCheck == null)
            {
                // email/username doesnt exists
                return new ApiResult<UserIdentityDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Username or password is incorrect" }
                };
            }

            //check if password matches email
            if (userEmailCheck.Password != userDto.Password)
            {
                return new ApiResult<UserIdentityDto>()
                {
                    IsSuccess = false,
                    Errors = new string[] { "Username or password is incorrect" }
                };
            }

            var user = new User()
            {
                FirstName = userEmailCheck.FirstName,
                LastName = userEmailCheck.LastName,
            };
            //successful signup returns user
            var userDtoToReturn = _mapper.Map<UserDto>(user);

            var identityToken = _jwtService.GenerateIdentityToken(userDtoToReturn);

            var result =  new UserIdentityDto()
            {
                User = userDtoToReturn,
                IdentityToken = identityToken
            };

            return new ApiResult<UserIdentityDto>()
            {
                IsSuccess = true,
                Body = result
            };
        }
    }
}
