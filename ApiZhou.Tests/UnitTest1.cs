using ApiZhou.Data;
using LibraryZhou;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZhou.Tests
{
    public class Tests
    {
        private Mock<DbSet<Game>> mockSet;
        private Mock<GameDbContext> mockContext;

        [SetUp]
        public void Setup()
        {
            var data = new List<Game>
            {
                new Game { GameId = 1, Country = "USA", Continent = "North America", Gender = "Male" },
                new Game { GameId = 2, Country = "Canada", Continent = "North America", Gender = "Female" }
            }.AsQueryable();

            mockSet = new Mock<DbSet<Game>>();
            mockSet.As<IQueryable<Game>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Game>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Game>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Game>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mockContext = new Mock<GameDbContext>();
            mockContext.Setup(c => c.Games).Returns(mockSet.Object);
        }

        [Test]
        public async Task GetAllGames_ReturnsAllGames()
        {
            var service = new GamesService(mockContext.Object); // Assuming you have a service class that handles the business logic.
            var games = await service.GetAllGamesAsync(); // Method in your service to get all games.

            Assert.IsNotNull(games);
            Assert.AreEqual(2, games.Count(), "Should return two games");
            Assert.AreEqual("USA", games.First().Country, "The first game's country should be USA");
        }
    }
}
