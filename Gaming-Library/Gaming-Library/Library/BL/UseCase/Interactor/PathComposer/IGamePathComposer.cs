using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.InputPort;

namespace Gaming_Library.Library.BL.UseCase.Interactor.PathComposer
{
    public interface IGamePathComposer
    {
        public string ComposeExecutablePath(Entity.GameData game);
    }
}
