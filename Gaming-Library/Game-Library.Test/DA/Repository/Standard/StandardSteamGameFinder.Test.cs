using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.Library.DA.Repository.Standard;


namespace Game_Library.Library.Test.DA.Repository.Standard
{
    [TestClass]
    public class StandardSteamGameFinderTest
    {
        private readonly string _fileName = "C:\\Users\\haziraj\\Documents\\Referenzprojekt\\Gaming-Library\\Game-Library.Test\\v0002.json";


        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateTest()
        {
            var finder = StandardSteamGameFinder.Create();
            Assert.IsNotNull(finder);
        }

        [TestMethod]
        public void FindGameOneMatchingTest()
        {
            var games = new Gaming_Library.Library.DA.Repository.SteamGameList();
            games.applist = new Gaming_Library.Library.DA.Repository.AppList();
            games.applist.apps = new List<Gaming_Library.Library.DA.Repository.App>()
            {
                new Gaming_Library.Library.DA.Repository.App(1,"Game1"),
                new Gaming_Library.Library.DA.Repository.App(2,"fghfgh"),
                new Gaming_Library.Library.DA.Repository.App(3,"otherStuff"),
            };
            File.WriteAllText(_fileName, System.Text.Json.JsonSerializer.Serialize(games));
            var finder = StandardSteamGameFinder.Create();

            var result = finder.FindGame("Game1", _fileName);
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void FindGameNoneMatchingTest()
        {
            var games = new Gaming_Library.Library.DA.Repository.SteamGameList();
            games.applist = new Gaming_Library.Library.DA.Repository.AppList();
            games.applist.apps = new List<Gaming_Library.Library.DA.Repository.App>()
            {
                new Gaming_Library.Library.DA.Repository.App(1,"Game1"),
                new Gaming_Library.Library.DA.Repository.App(2,"Gam"),
                new Gaming_Library.Library.DA.Repository.App(3,"otherStuff"),
            };
            File.WriteAllText(_fileName, System.Text.Json.JsonSerializer.Serialize(games));
            var finder = StandardSteamGameFinder.Create();

            var result = finder.FindGame("CSGO2", _fileName);
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void FindGameMultipleMatchingTest()
        {
            var games = new Gaming_Library.Library.DA.Repository.SteamGameList();
            games.applist = new Gaming_Library.Library.DA.Repository.AppList();
            games.applist.apps = new List<Gaming_Library.Library.DA.Repository.App>()
            {
                new Gaming_Library.Library.DA.Repository.App(1,"Game1"),
                new Gaming_Library.Library.DA.Repository.App(2,"Gam"),
                new Gaming_Library.Library.DA.Repository.App(3,"otherStuff"),
            };

            File.WriteAllText(_fileName, System.Text.Json.JsonSerializer.Serialize(games));


            var finder = StandardSteamGameFinder.Create();

            var result = finder.FindGame("Gam", _fileName);
            Assert.IsTrue(result.Count == 2);
        }
    }
}
