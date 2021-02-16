using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.Interactor.PathComposer
{
    public class SteamGamePathComposer : IGamePathComposer
    {
        public static IGamePathComposer Create()
        {
            return new SteamGamePathComposer();
        }
        private SteamGamePathComposer()
        {
        }

        public string ComposeExecutablePath(Entity.GameData game)
        {
            return "steam://rungameid/" + game.SteamId.ToString();
        }
    }
}
