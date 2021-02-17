using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    public class Commands : ICommands
    {
        private readonly Dictionary<int, ICommand> _commands = new Dictionary<int, ICommand>();

        public static ICommands Create()
        {
            return new Commands();
        }

        private Commands()
        {

        }
        public void Add(ICommand command)
        {
            _commands.Add(command.GetId(), command);
        }

        public ICommand GetCommand(IRequest request)
        {
            ICommand command;
            _commands.TryGetValue(request.GetType().Name.GetHashCode(), out command);
            return command;
        }
    }
}
