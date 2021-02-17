using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands
{
    public interface ICommand
    {
        public abstract int GetId();
        public abstract void Do(InputPort.Requests.IRequest request);
    }
}
