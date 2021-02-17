using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Entity;
using Gaming_Library.Library.BL.UseCase.Interactor.PathComposer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Game_Library.UseCase.Interactor.PathComposer.Test
{
    [TestClass]
    public class SteamGamePathComposer_Test
    {
        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreatePathComposerTest()
        {
            var composer = Gaming_Library.Library.BL.UseCase.Interactor.PathComposer.SteamGamePathComposer.Create();
            Assert.IsNotNull(composer);
        }

        [TestMethod]
        public void ComposeExecutablePathTest()
        {
            var composer = Gaming_Library.Library.BL.UseCase.Interactor.PathComposer.SteamGamePathComposer.Create();
            var game = new GameData();
            game.SteamId = new Gaming_Library.Library.BL.UseCase.Entity.Types.SteamId(400);
            Assert.AreEqual("steam://rungameid/400", composer.ComposeExecutablePath(game));
        }
    }
}
