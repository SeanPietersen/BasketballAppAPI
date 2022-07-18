using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;
using BasketballApp.Infrustructure.Services.Repositories;
using BasketballApp.Tests;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BasketballInfo.Tests
{
    public class PlayerContractTest: ContextTest
    {
        private readonly IPlayerContract _playerContract;
        private readonly ITeamRepository _teamRepository;
        private readonly IPlayerRepository _playerRepository;

        public PlayerContractTest()
        {
            _teamRepository = Substitute.For<ITeamRepository>();
            _playerRepository = Substitute.For<IPlayerRepository>();
            _playerContract = new PlayerContract(_playerRepository, _teamRepository, _mapper);
        }

        [Fact]
        public void GetAllPlayersForTeam_ShouldReturnNull_InvalidTeamId()
        {
            //Arrange
            var teamId = 0;

            _teamRepository.GetTeamByTeamIdAsync(teamId).ReturnsNull();

            //Act
            IEnumerable<PlayerDto> actual = _playerContract.GetAllPlayersForTeam(teamId);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void GetAllPlayersForTeam_IsSuccessful()
        {
            //Arrange
            var teamId = 1;

            var teamInDb = new Team()
            {
                TeamId = 1,
                Name = "MOCK Test 1",
                State = "MOCK Test 1 State",
                Players = new List<Player>()
                {
                    new Player()
                    {
                        PlayerId = 1,
                        FirstName = "Sean",
                        LastName = "Pietersen",
                        DateOfBirth = new DateTime(1997,01,14),
                        PlayerHeight = 1.76,
                        PlayerWeight = 82
                    },
                    new Player()
                    {
                        PlayerId = 2,
                        FirstName = "Jason",
                        LastName = "Pietersen",
                        DateOfBirth = new DateTime(1994,04,08),
                        PlayerHeight = 1.78,
                        PlayerWeight = 90
                    }
                }
            };

            _teamRepository.GetTeamByTeamIdAsync(teamId, true, false).Returns(teamInDb);


            //Act
            IEnumerable<PlayerDto> actual = _playerContract.GetAllPlayersForTeam(teamId);

            //Assert
            Assert.Equal(teamInDb.Players.Count, actual.ToList().Count);

        }
    }
}
