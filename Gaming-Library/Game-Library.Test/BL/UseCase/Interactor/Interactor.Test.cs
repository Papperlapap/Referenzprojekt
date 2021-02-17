using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.InputPort;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.Library.BL.UseCase.Interactor;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.Library.BL.UseCase.OutputPort;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Game_Library.UseCase.Interactor
{
    [TestClass]
    public class Interactor_Test
    {

        [TestCategory("Unit Test")]

        private Gaming_Library.Library.BL.UseCase.Interactor.Interactor CreateInteractor()
        {
            var presenter = new Mock<IPresenter>();
            var responseModel = new ResponseModel();
            presenter.Setup(x => x.Update(responseModel)).Verifiable();

            var interactorModel = new Model();
            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            var injector = new Gaming_Library.Library.BL.UseCase.Interactor.Interactor.Injector(interactorModel, presenter.Object, commands.Object);
            var interactor = Gaming_Library.Library.BL.UseCase.Interactor.Interactor.Create(injector);

            return (Gaming_Library.Library.BL.UseCase.Interactor.Interactor)interactor;
        }

        [TestMethod]
        public void CreatInteractorTest()
        {
            Assert.IsNotNull(CreateInteractor());
        }

        [TestMethod]
        public void UpdateTest()
        {
            var presenter = new Mock<IPresenter>();
            var responseModel = new ResponseModel();
            presenter.Setup(x => x.Update(responseModel)).Verifiable();

            var interactorModel = new Model();
            interactorModel.Games = new List<GameData>()
            {
            };
            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            var injector = new Gaming_Library.Library.BL.UseCase.Interactor.Interactor.Injector(interactorModel, presenter.Object, commands.Object);
            var interactor = Gaming_Library.Library.BL.UseCase.Interactor.Interactor.Create(injector);

            var requestModel = new RequestModel();
            requestModel.Requests = new List<IRequest>();

            interactor.Update(requestModel);
            presenter.Verify(x => x.Update(It.IsAny<ResponseModel>()), Times.Once);

        }


    }
}
