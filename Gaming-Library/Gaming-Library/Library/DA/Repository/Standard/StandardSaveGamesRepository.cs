using System;
using System.IO;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository.Standard
{
    public class StandardSaveGamesRepository : ISaveGamesRepository
    {

        public static ISaveGamesRepository Create()
        {
            return new StandardSaveGamesRepository();
        }

        private StandardSaveGamesRepository()
        {

        }
        public void SaveToFile(List<GameData> itemsToSave, string path)
        {
            File.WriteAllText(path, System.Text.Json.JsonSerializer.Serialize<List<GameData>>(itemsToSave));
        }
    }
}