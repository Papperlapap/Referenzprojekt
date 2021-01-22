﻿using Gaming_Library.BL.UseCase.InputPort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace Game_Library.FE.Dialog.Adapter.Presenter
{
    [TestClass]
    public class Controller_Test
    {

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateControllerTest()
        {
            var viewModel = new Gaming_Library.FE.Dialog.Adapter.View.Model();
            var interactor = new Mock<IInteractor>();

            var injector = new Gaming_Library.FE.Dialog.Adapter.Controller.Controller.Injector(viewModel, interactor.Object);
            var controller = Gaming_Library.FE.Dialog.Adapter.Controller.Controller.Create(injector);

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void ControllerUpdateInteractorTest()
        {
            var viewModel = new Gaming_Library.FE.Dialog.Adapter.View.Model();
            var interactor = new Mock<IInteractor>();

            var injector = new Gaming_Library.FE.Dialog.Adapter.Controller.Controller.Injector(viewModel, interactor.Object);
            var controller = Gaming_Library.FE.Dialog.Adapter.Controller.Controller.Create(injector);

            Assert.IsNotNull(controller);
        }
    }
}
