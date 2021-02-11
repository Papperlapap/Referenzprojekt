using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.Interactor.PathComposer
{
    class GamePathComposerFactory
    {
        public static IGamePathComposer CreatePathComposer(PathTypes type)
        {
            switch (type) {
                case PathTypes.STEAM:
                    return SteamGamePathComposer.Create();
                case PathTypes.NON_STEAM:
                    return null;
                default:
                    return null;
            }
        }
    }
}
