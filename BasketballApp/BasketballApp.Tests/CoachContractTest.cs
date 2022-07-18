using BasketballApp.Application.Contracts;
using BasketballApp.Application.Dto;
using BasketballApp.Domain;
using BasketballApp.Domain.Enums;
using BasketballApp.Infrustructure.Services.Repositories;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BasketballApp.Tests
{
    public class CoachContractTest : ContextTest
    {
        private readonly ICoachContract _coachContract;
        private readonly ITeamRepository _teamRepository;
        private readonly ICoachRepository _coachRepository;

        public CoachContractTest()
        {
            _coachRepository = Substitute.For<ICoachRepository>();
            _teamRepository = Substitute.For<ITeamRepository>();
            _coachContract = new CoachContract(_teamRepository,_coachRepository, _mapper);
        }

        [Fact]
        public void GetAllCoachesForTeam_ShouldReturnNull_InvalidTeamId()
        {
            //Arrange
            var teamId = 0;

            _teamRepository.GetTeamByIdAsync(teamId).ReturnsNull();

            //Act
            IEnumerable<CoachDto> actual = _coachContract.GetAllCoachesForTeam(teamId);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void GetAllCoachesForTeam_IsSuccessful()
        {
            //Arrange
            var teamId = 1;

            var teamInDb = new Team()
            {
                TeamId = 1,
                Name = "MOCK Test 1",
                State = "MOCK Test 1 State",
                Coaches = new List<Coach>()
                {
                    new Coach()
                    {
                        CoachId = 1,
                        FirstName = "Sean",
                        LastName = "Pietersen",
                        YearsOfExperience = 1,
                        IsQualified = false,
                        Rank = RankType.Head_Coach
                    },
                    new Coach()
                    {
                        CoachId = 2,
                        FirstName = "Jason",
                        LastName = "Pietersen",
                        YearsOfExperience = 15,
                        IsQualified = true,
                        Rank = RankType.Head_Coach
                    }
                }
            };

            _teamRepository.GetTeamByIdAsync(teamId, false, true).Returns(teamInDb);


            //Act
            IEnumerable<CoachDto> actual = _coachContract.GetAllCoachesForTeam(teamId);

            //Assert
            Assert.Equal(teamInDb.Coaches.Count, actual.ToList().Count);

        }

        [Fact]
        public void GetCoachByIdForTeam_ShouldReturnNull_InvalidTeamId()
        {
            //Arrange
            var teamId = 0;
            var coachId = 1;

            _teamRepository.GetTeamByIdAsync(teamId).ReturnsNull();

            _coachRepository.GetCoachByIdForTeamAsync(teamId, coachId).ReturnsNull();


            //Act
            var actual = _coachContract.GetCoachByIdForTeam(teamId, coachId);

            //Assert
            Assert.Null(actual);

        }

        [Fact]
        public void GetCoachByIdForTeam_ShouldReturnNull_InvalidCoachId()
        {
            //Arrange
            var teamId = 1;
            var coachId = 0;

            var teamInDb = new Team()
            {
                TeamId = 1,
                Name = "MOCK Test 1",
                State = "MOCK Test 1 State",
                Coaches = new List<Coach>()
                {
                    new Coach()
                    {
                        CoachId = 1,
                        FirstName = "Sean",
                        LastName = "Pietersen",
                        YearsOfExperience = 1,
                        IsQualified = false,
                        Rank = RankType.Head_Coach
                    },
                    new Coach()
                    {
                        CoachId = 2,
                        FirstName = "Jason",
                        LastName = "Pietersen",
                        YearsOfExperience = 15,
                        IsQualified = true,
                        Rank = RankType.Head_Coach
                    }
                }
            };

            _teamRepository.GetTeamByIdAsync(teamId, false, true).Returns(teamInDb);
            _coachRepository.GetCoachByIdForTeamAsync(teamId, coachId).ReturnsNull();

            //Act
            var actual = _coachContract.GetCoachByIdForTeam(teamId, coachId);

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void GetCoachByCoachIdAndTeamId_IsSuccessful()
        {
            //Arrange
            var teamId = 1;
            var coachId = 1;

            var coachInfo = new Coach()
            {
                CoachId = 1,
                FirstName = "Sean",
                LastName = "Pietersen",
                YearsOfExperience = 1,
                IsQualified = false,
                Rank = RankType.Head_Coach
            };
            var teamInDb = new Team()
            {
                TeamId = 1,
                Name = "MOCK Test 1",
                State = "MOCK Test 1 State",
                Coaches = new List<Coach>()
                {
                    new Coach()
                    {
                        CoachId = 1,
                        FirstName = "Sean",
                        LastName = "Pietersen",
                        YearsOfExperience = 1,
                        IsQualified = false,
                        Rank = RankType.Head_Coach
                    },
                    new Coach()
                    {
                        CoachId = 2,
                        FirstName = "Jason",
                        LastName = "Pietersen",
                        YearsOfExperience = 15,
                        IsQualified = true,
                        Rank = RankType.Head_Coach
                    }
                }
            };

            _teamRepository.GetTeamByIdAsync(teamId, false, true).Returns(teamInDb);
            _coachRepository.GetCoachByIdForTeamAsync(teamId, coachId).Returns(coachInfo);
            

            //Act
            CoachDto actual = _coachContract.GetCoachByIdForTeam(teamId, coachId);

            //Assert
            Assert.Equal(coachInfo.FirstName, actual.FirstName);
            Assert.Equal(coachInfo.LastName, actual.LastName);
        }


    }
}
