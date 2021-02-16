using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor
{
    [Equals]
    public sealed class Model
    {
        public Entity.SteamGameData steamGameData { get; set; }
        public Gaming_Library.BL.UseCase.Entity.Types.SteamId steamId { get; set; }

        public bool IsModified { get; set; }

        public void Clone(Model model)
        {
            IsModified = model.IsModified;
            steamGameData = model.steamGameData;
        }
    }
}
