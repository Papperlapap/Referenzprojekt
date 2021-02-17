using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Interactor.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Game_Library.UseCase.Interactor.Commands.Test
{
    [TestClass]
    public class Commands_Test
    {
        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateCommandsTest()
        {
            var commands = Gaming_Library.Library.BL.UseCase.Interactor.Commands.Commands.Create();
            Assert.IsNotNull(commands);
        }

        [TestMethod]
        public void AddCommandTest()
        {
            var request = new Gaming_Library.Library.BL.UseCase.InputPort.Requests.Add();
            var commands = Gaming_Library.Library.BL.UseCase.Interactor.Commands.Commands.Create();
            var repository = new Mock<Gaming_Library.Library.DA.Repository.ISaveGamesRepository>();
            var command = Add.Create(new Gaming_Library.Library.BL.UseCase.Interactor.Model(), repository.Object);
            commands.Add(command);

            Assert.IsNotNull(commands.GetCommand(request));
        }

        [TestMethod]
        public void AddCommandNullTest()
        {
            var request = new Gaming_Library.Library.BL.UseCase.InputPort.Requests.Add();
            var commands = Gaming_Library.Library.BL.UseCase.Interactor.Commands.Commands.Create();
            Assert.ThrowsException<NullReferenceException>(() => commands.Add(null));
        }

        [TestMethod]
        public void GetCommandNoSuchCommandTest()
        {
            var request = new Gaming_Library.Library.BL.UseCase.InputPort.Requests.OpenProperties(6);
            var commands = Gaming_Library.Library.BL.UseCase.Interactor.Commands.Commands.Create();
            var repository = new Mock<Gaming_Library.Library.DA.Repository.ISaveGamesRepository>();
            var command = Add.Create(new Gaming_Library.Library.BL.UseCase.Interactor.Model(), repository.Object);
            commands.Add(command);
            Assert.IsNull(commands.GetCommand(request));
        }


        [TestMethod]
        public void GetCommandTest()
        {
            var request = new Gaming_Library.Library.BL.UseCase.InputPort.Requests.Add();
            var commands = Gaming_Library.Library.BL.UseCase.Interactor.Commands.Commands.Create();
            var repository = new Mock<Gaming_Library.Library.DA.Repository.ISaveGamesRepository>();
            var command = Add.Create(new Gaming_Library.Library.BL.UseCase.Interactor.Model(), repository.Object);
            commands.Add(command);

            Assert.IsTrue(commands.GetCommand(request).GetType() == typeof(Add));
        }

    }
}
