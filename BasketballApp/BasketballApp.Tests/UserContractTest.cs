using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using BasketballApp.Application.Services;
using BasketballApp.Domain;
using BasketballApp.Infrastructure.Services.Repositories;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BasketballApp.Tests
{
    public class UserContractTest : ContextTest
    {
        private readonly IUserContract userContract;
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;
        public UserContractTest()
        {
            _userRepository = Substitute.For<IUserRepository>();
            userContract = new UserContract(_userRepository, _mapper, _jwtService);
        }

        [Fact]
        public async Task RegisterUser_ShouldReturnNull_UserAlreadyExists()
        {
            //Arrange

            var userInDb = new User()
            {
                UserId = 1,
                FirstName = "Sean",
                LastName = "Pietersen",
                Email = "seanpietersen7@gmail.com",
                Password = "Sean2563"
            };


            var createdUser = new RegisterUserDto()
            {
                FirstName = "Percy",
                LastName = "Pietersen",
                Email = "seanpietersen7@gmail.com",
                Password = "Sean2563"
            };

            _userRepository.GetUserByEmailAsync(createdUser.Email).Returns(userInDb);

            //Act
            var actual = await userContract.RegisterUser(createdUser);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public async Task RegisterUser_Successful()
        {
            //Arrange
            var userInDb = new List<User>()
            {
                new User()
                {
                    UserId = 1,
                    FirstName = "Sean",
                    LastName = "Pietersen",
                    Email = "seanpietersen7@gmail.com",
                    Password = "Sean2563"
                },
                 new User()
                {
                    UserId = 2,
                    FirstName = "Jason",
                    LastName = "Pietersen",
                    Email = "jase.pietersen7@gmail.com",
                    Password = "Jason2563"
                }
             };


            var createdUserDto = new RegisterUserDto()
            {
                FirstName = "Percy",
                LastName = "Pietersen",
                Email = "pfpietersen@gmail.com",
                Password = "Sean2563"
            };

            var createdUser = new User()
            {
                FirstName = "Percy",
                LastName = "Pietersen",
                Email = "pfpietersen@gmail.com",
                Password = "Sean2563"
            };

            var expected = new UserDto()
            {
                FirstName = "Percy",
                LastName = "Pietersen",
                Email = "pfpietersen@gmail.com",
                Password = "Sean2563"
            };

            _userRepository.GetUserByEmailAsync(createdUserDto.Email).ReturnsNull();
            _userRepository.RegisterUserAsync(createdUser).Returns(createdUser);

            //Act
            var actual = await userContract.RegisterUser(createdUserDto);

            //Assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.Email, actual.Email);
        }
        [Fact]
        public async Task UserSignUp_ShouldReturnNull_EmailDoesntExist()
        {
            //Arrange
            var userInDb = new List<User>()
            {
                new User()
                {
                    UserId = 1,
                    FirstName = "Sean",
                    LastName = "Pietersen",
                    Email = "seanpietersen7@gmail.com",
                    Password = "Sean2563"
                },
                 new User()
                {
                    UserId = 2,
                    FirstName = "Jason",
                    LastName = "Pietersen",
                    Email = "jase.pietersen7@gmail.com",
                    Password = "Jason2563"
                }
             };


            var signUpUserDto = new UserSignInDto()
            {
                Email = "pfpietersen@gmail.com",
                Password = "Sean2563"
            };

            _userRepository.GetUserByEmailAsync(signUpUserDto.Email).ReturnsNull();

            //Act
            var actual = await userContract.UserSigIn(signUpUserDto);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public async Task UserSignUp_ShouldReturnNull_PasswordDoesNotMatchEmail()
        {
            //Arrange
            var userInDb = new User()
            {
                UserId = 1,
                FirstName = "Jason",
                LastName = "Pietersen",
                Email = "jase.pietersen@gmail.com",
                Password = "Jason2563"
            };

            var signUpUserDto = new UserSignInDto()
            {
                Email = "jase.pietersen@gmail.com",
                Password = "Sean2563"
            };

            _userRepository.GetUserByEmailAsync(signUpUserDto.Email).Returns(userInDb);

            //Act
            var actual = await userContract.UserSigIn(signUpUserDto);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public async Task UserSignUp_Successful()
        {
            //Arrange
            var userInDb = new User()
            {
                UserId = 1,
                FirstName = "Jason",
                LastName = "Pietersen",
                Email = "jase.pietersen@gmail.com",
                Password = "Jason2563"
            };

            var signUpUserDto = new UserSignInDto()
            {
                Email = "jase.pietersen@gmail.com",
                Password = "Jason2563"
            };

            _userRepository.GetUserByEmailAsync(signUpUserDto.Email).Returns(userInDb);

            //Act
            var actual = await userContract.UserSigIn(signUpUserDto);

            //Assert
            Assert.Equal(userInDb.FirstName, actual.User.FirstName);
        }

        [Fact]
        public async Task GetAllUsers_IsSuccessful()
        {
            //Arrange
            var userInDb = new List<User>()
            {
                new User()
                {
                    UserId = 1,
                    FirstName = "Sean",
                    LastName = "Pietersen",
                    Email = "seanpietersen7@gmail.com",
                    Password = "Sean2563"
                },
                 new User()
                {
                    UserId = 2,
                    FirstName = "Jason",
                    LastName = "Pietersen",
                    Email = "jase.pietersen7@gmail.com",
                    Password = "Jason2563"
                },
                  new User()
                {
                    UserId =31,
                    FirstName = "Rumer",
                    LastName = "Manis",
                    Email = "rumerkerm@gmail.com",
                    Password = "Rumer1234"
                },

            };

            _userRepository.GetAllUsersAsync().Returns(userInDb);

            //Act
            var actual = await userContract.GetAllUsers();

            //Assert
            Assert.Equal(userInDb.Count, actual.ToList().Count);
        }

        [Fact]
        public async Task GetUserById_ShouldReturnNull_InvalidUserId()
        {
            //Arrange
            var userId = 0;

            _userRepository.GetUserByIdAsync(userId).ReturnsNull();

            //Act
            var actual = await userContract.GetUserById(userId);

            //Assert
            Assert.Null(actual);

        }

        [Fact]
        public async Task GetUserByUserId_IsSuccessful()
        {
            //Arrange
            var userId = 1;

            var userInDb = new User()
            {
                UserId = 1,
                FirstName = "Sean",
                LastName = "Pietersen",
                Email = "seanpietersen7@gmail.com",
                Password = "Sean2563"
            };

            _userRepository.GetUserByIdAsync(userId).Returns(userInDb);

            //Act
            var actual = await userContract.GetUserById(userId);

            //Assert
            Assert.Equal(userInDb.FirstName, actual.FirstName);
            Assert.Equal(userInDb.Email, actual.Email);
            Assert.Equal(userInDb.Password, actual.Password);
        }
    }
}
