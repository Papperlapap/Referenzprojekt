using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.ChooseSteamGame.BL.UseCase.Entity;
using Gaming_Library.Library.BL.UseCase.Entity.Types;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort.Requests
{ 
        public sealed class SearchGames : IRequest
        {
            public SteamGameData steamGameData { get; }

            public SearchGames(SteamGameData steamGameData)
            {
                this.steamGameData = steamGameData;
            }
        }
    
}
