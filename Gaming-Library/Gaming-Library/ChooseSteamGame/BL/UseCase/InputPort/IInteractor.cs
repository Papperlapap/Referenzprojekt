using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort
{
    public interface IInteractor
    {
        abstract void Update(RequestModel requestmodel);
    }
}
