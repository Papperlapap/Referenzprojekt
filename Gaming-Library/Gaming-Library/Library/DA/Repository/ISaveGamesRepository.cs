using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository
{
    public interface ISaveGamesRepository
    {
        public void SaveToFile(List<GameData> itemsToSave, string path);
    }
}
