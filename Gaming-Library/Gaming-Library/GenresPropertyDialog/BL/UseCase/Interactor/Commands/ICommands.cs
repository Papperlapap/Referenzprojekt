using System;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.Interactor.Commands
{
    public interface ICommands
    {
        public abstract ICommand GetCommand(InputPort.Requests.IRequest request);
        public abstract void Add(ICommand command);
    }
}
