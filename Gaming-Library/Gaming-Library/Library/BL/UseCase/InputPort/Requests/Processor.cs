using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Interactor.Commands;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public class Processor : IProcessor
    {
        private Injector _injector;

        public sealed class Injector
        {

            public RequestModel RequestModel;
            public Interactor.Commands.ICommands Commands;

            public Injector(RequestModel requestModel, ICommands commands)
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
