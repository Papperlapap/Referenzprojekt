using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Entity
{
    [Equals]
    public sealed class SteamGameData
    {
        public Entity.Types.SteamGameList searchResultList { get; set; }
        public Entity.Types.SteamGameList allSteamGames { get; set; }
        public Gaming_Library.Library.BL.UseCase.Entity.Types.SteamId steamId { get; set; }
        public Entity.Types.SearchTerm searchTerm { get; set; }

        public SteamGameData()
        {
            searchResultList = new Types.SteamGameList();
            allSteamGames = new Types.SteamGameList();
            steamId = new Gaming_Library.Library.BL.UseCase.Entity.Types.SteamId(null);
            searchTerm = new Types.SearchTerm("");
        }

        public static bool operator ==(SteamGameData left, SteamGameData right) => Operator.Weave(left, right);
        public static bool operator !=(SteamGameData left, SteamGameData right) => Operator.Weave(left, right);
    }
}
