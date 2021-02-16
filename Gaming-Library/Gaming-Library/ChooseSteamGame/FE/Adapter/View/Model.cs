using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using System.Drawing;

namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter.View
{
    public sealed class Model
    {
        public Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.SteamGameData steamGameData { get; set; }

        public bool IsInvalidGame;
        public bool IsModified;

        public Model()
        {
            steamGameData = new Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.SteamGameData();
        }

        public void Clone(Model model)
        {
           steamGameData = model.steamGameData;
        }
    }
}
