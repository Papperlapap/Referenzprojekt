using System;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.Interactor.Commands
{
    public interface ICommand
    {
        public abstract int GetId();
        public abstract void Do(InputPort.Requests.IRequest request);
    }
}
