using BasketballApp.Application.Contracts;
using BasketballApp.Domain;
using BasketballApp.Domain.Enums;
using BasketballApp.Infrustructure.Services.Repositories;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BasketballApp.Tests
{
    public class TeamContractTest : ContextTest
    {
        private readonly ITeamContract _teamContract;
        private readonly ITeamRepository _teamRepository;
        public TeamContractTest()
        {
            _teamRepository = Substitute.For<ITeamRepository>();
            _teamContract = new TeamContract(_teamRepository, _mapper);
        }

        [Fact]
        public async Task GetAllTeams_IsSuccessful()
        {
            //Arrange
            var teamInDb = new List<Team>()
            {
                new Team()
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
                    },
                    Coaches = new List<Coach>()
                    {
                        new Coach()
                        {
                            CoachId = 1,
                            FirstName = "Rumer",
                            LastName = "Manis",
                            YearsOfExperience = 5,
                            IsQualified = true,
                            Rank = RankType.Head_Coach
                        }
                    }
                },
                new Team()
                {
                    TeamId = 2,
                    Name = "MOCK Test 2",
                    State = "MOCK Test 2 State",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            PlayerId = 3,
                            FirstName = "Sean2",
                            LastName = "Pietersen2",
                            DateOfBirth = new DateTime(1997,01,14),
                            PlayerHeight = 1.76,
                            PlayerWeight = 82
                        },
                        new Player()
                        {
                            PlayerId = 4,
                            FirstName = "Jason2",
                            LastName = "Pietersen2",
                            DateOfBirth = new DateTime(1994,04,08),
                            PlayerHeight = 1.78,
                            PlayerWeight = 90
                        }
                    },
                    Coaches = new List<Coach>()
                    {
                        new Coach()
                        {
                            CoachId = 2,
                            FirstName = "Rumer2",
                            LastName = "Manis2",
                            YearsOfExperience = 5,
                            IsQualified = true,
                            Rank = RankType.Head_Coach
                        }
                    }
                }
            };

            _teamRepository.GetAllTeamsAsync().Returns(teamInDb);

            //Act
            var actual = await _teamContract.GetAllTeams();

            //Assert
            Assert.Equal(teamInDb.Count, actual.ToList().Count);
        }

        [Fact]
        public async Task GetTeamById_ShouldReturnNull_InvalidTeamId()
        {
            //Arrange
            var teamId = 0;

            _teamRepository.GetTeamByTeamIdAsync(teamId, false, false).ReturnsNull();

            //Act
            var actual = await _teamContract.GetTeamByTeamId(teamId);

            //Assert
            Assert.Null(actual);

        }

        [Fact]
        public async Task GetTeamById_IsSuccessful()
        {
            //Arrange
            var teamId = 1;

            var teamInDb = new Team()
            {
                TeamId = 1,
                Name = "MOCK Test 1",
                State = "MOCK Test 1 State"

            };

            _teamRepository.GetTeamByTeamIdAsync(teamId, false, false).Returns(teamInDb);

            //Act
            var actual = await _teamContract.GetTeamByTeamId(teamId);

            //Assert
            Assert.Equal(teamInDb.Name, actual.Name);
        }

    }
}
