using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.InputPort;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Game_Library.UseCase.InputPort.Requests.Test
{
    [TestClass]
    public class Processor_Test
    {

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateProcessorTest()
        {
            var requestModel = new RequestModel();
            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            var injector = new Processor.Injector(requestModel, commands.Object);
            var processor = Processor.Create(injector);

            Assert.IsNotNull(processor);
        }

        [TestMethod]
        public void ProcessorExecuteRequestTest()
        {
            var requestModel = new RequestModel();
            var request = new Add();
            requestModel.Requests = new List<IRequest>()
            {
               request
            };

            var command = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommand>();
            command.Setup(x => x.Do(new Add())).Verifiable();

            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            commands.Setup(x => x.GetCommand(request)).Returns(command.Object);

            var injector = new Processor.Injector(requestModel, commands.Object);
            var processor = Processor.Create(injector);

            processor.Execute();
            command.Verify(x => x.Do(It.IsAny<IRequest>()), Times.Once);
        }

        [TestMethod]
        public void ProcessorExecuteMultipleRequestsTest()
        {
            var requestModel = new RequestModel();
            var request = new Add();
            requestModel.Requests = new List<IRequest>()
            {
               request,
               request,
               request,
            };

            var command = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommand>();
            command.Setup(x => x.Do(new Add())).Verifiable();

            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            commands.Setup(x => x.GetCommand(request)).Returns(command.Object);

            var injector = new Processor.Injector(requestModel, commands.Object);
            var processor = Processor.Create(injector);

            processor.Execute();
            command.Verify(x => x.Do(It.IsAny<IRequest>()), Times.Exactly(3));
        }

        [TestMethod]
        public void ProcessorExecuteNoRequestsTest()
        {
            var requestModel = new RequestModel();
            var request = new Add();
            requestModel.Requests = new List<IRequest>();

            var command = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommand>();
            command.Setup(x => x.Do(new Add())).Verifiable();

            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            commands.Setup(x => x.GetCommand(request)).Returns(command.Object);

            var injector = new Processor.Injector(requestModel, commands.Object);
            var processor = Processor.Create(injector);

            processor.Execute();
            command.Verify(x => x.Do(It.IsAny<IRequest>()), Times.Never);
        }

        [TestMethod]
        public void ProcessorExecuteInvalidRequestsTest()
        {
            var requestModel = new RequestModel();
            var request = new Add();
            requestModel.Requests = new List<IRequest>()
            {
                null,
                null
            };

            var command = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommand>();
            command.Setup(x => x.Do(new Add())).Verifiable();

            var commands = new Mock<Gaming_Library.Library.BL.UseCase.Interactor.Commands.ICommands>();
            commands.Setup(x => x.GetCommand(request)).Returns(command.Object);

            var injector = new Processor.Injector(requestModel, commands.Object);
            var processor = Processor.Create(injector);

            processor.Execute();
            command.Verify(x => x.Do(It.IsAny<IRequest>()), Times.Never);
        }


    }
}

