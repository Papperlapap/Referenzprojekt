using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.OutputPort
{
    public interface IPresenter
    {
        void Update(ResponseModel responseModel);
    }
}
