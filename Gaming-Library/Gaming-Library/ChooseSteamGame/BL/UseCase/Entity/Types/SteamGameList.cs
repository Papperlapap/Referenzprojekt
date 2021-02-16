using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class SteamGameList
    {
            public AppList applist { get; set; }

        public static bool operator ==(SteamGameList left, SteamGameList right) => Operator.Weave(left, right);
        public static bool operator !=(SteamGameList left, SteamGameList right) => Operator.Weave(left, right);
    }
}
