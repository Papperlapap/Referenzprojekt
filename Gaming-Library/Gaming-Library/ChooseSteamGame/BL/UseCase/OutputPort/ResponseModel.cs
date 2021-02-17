using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.OutputPort
{
    public sealed class ResponseModel
    {
        public bool IsModified;
        public Entity.SteamGameData steamGameData { get; set; }
        public ResponseModel()
        {
        }

        public void Clone(ResponseModel model)
        {
            IsModified = model.IsModified;
            steamGameData = model.steamGameData;
        }
    }
}

