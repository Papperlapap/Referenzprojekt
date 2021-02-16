using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands
{
    public interface ICommands
    {
        public abstract ICommand GetCommand(InputPort.Requests.IRequest request);
        public abstract void Add(ICommand command);
    }
}
