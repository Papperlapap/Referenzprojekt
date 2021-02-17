using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository.Newtonsoft
{
    public class NewtonsoftLoadGamesRepository : ILoadGamesRepository
    {
        public static ILoadGamesRepository Create()
        {
            return new NewtonsoftLoadGamesRepository();
        }

        private NewtonsoftLoadGamesRepository()
        {

        }
        public List<GameData> LoadAllFromFile(string path)
        {
            return JsonConvert.DeserializeObject<List<GameData>>(File.ReadAllText(path));
        }
    }
}
