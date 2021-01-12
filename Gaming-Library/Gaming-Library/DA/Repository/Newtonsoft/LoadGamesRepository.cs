﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA.Repository
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
