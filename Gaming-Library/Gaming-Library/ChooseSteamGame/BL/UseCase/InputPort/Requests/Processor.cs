using System;
using System.Linq;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort.Requests
{
    public class Processor : IProcessor
    {
        private Injector _injector;

        public sealed class Injector
        {

            public RequestModel RequestModel;
            public Interactor.Commands.ICommands Commands;

            public Injector(RequestModel requestModel, Interactor.Commands.ICommands commands)
            {
                RequestModel = requestModel;
                Commands = commands;
            }
        }
        private Processor(Injector injector)
        {
            _injector = injector;
        }
        public static IProcessor Create(Injector injector)
        {
            return new Processor(injector);
        }

        public void Execute()
        {
            Func<IRequest, bool> isValid = request => !(request is null);
            Action<IRequest> execute = request => _injector.Commands.GetCommand(request).Do(request);
            Func<int, bool> isInRange = index => index < _injector.RequestModel.Requests.Count;

            for (int i = 0; isInRange(i) && isValid(_injector.RequestModel.Requests.ElementAt(i)); ++i) {
                execute(_injector.RequestModel.Requests.ElementAt(i));
            }
        }
    }
}
