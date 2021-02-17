using System;
using System.Collections.Generic;


namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands
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

        public ICommand GetCommand(InputPort.Requests.IRequest request)
        {
            ICommand command;
            _commands.TryGetValue(request.GetType().Name.GetHashCode(), out command);
            return command;
        }
    }
}
