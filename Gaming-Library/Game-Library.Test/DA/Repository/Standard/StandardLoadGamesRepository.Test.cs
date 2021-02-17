using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.Library.DA.Repository.Standard;
using Gaming_Library.Library.BL.UseCase.Entity;
using System.IO;

namespace Game_Library.Test.DA.Repository.Standard
{
    [TestClass]
    public class StandardLoadGamesRepositoryTest
    {
        private readonly string _fileName = "C:\\Users\\haziraj\\Desktop\\testGames.json";

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateFileHandlerTest()
        {
            var fileHandler = StandardLoadGamesRepository.Create();
            Assert.IsNotNull(fileHandler);
        }

        [TestMethod]
        public void LoadAllFromFileNoItemsTest()
        {
            var fileHandler = StandardLoadGamesRepository.Create();
            File.WriteAllText(_fileName, "");
            Assert.IsTrue(fileHandler.LoadAllFromFile(_fileName) == null);
        }

        [TestMethod]
        public void LoadAllFromFileMultipleTest()
        {
            var fileHandler = StandardLoadGamesRepository.Create();

            var games = new List<GameData>
            {
                new GameData(),
                new GameData(),
                new GameData()
            };
            var gamesString = System.Text.Json.JsonSerializer.Serialize(games);
            File.WriteAllText(_fileName, gamesString);

            Assert.IsTrue(fileHandler.LoadAllFromFile(_fileName).Count == 3);
        }
    }
}
