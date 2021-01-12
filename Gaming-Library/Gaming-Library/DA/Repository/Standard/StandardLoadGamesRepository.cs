﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA.Repository.Standard
{
    public class StandardLoadGamesRepository : ILoadGamesRepository
    {
        public static ILoadGamesRepository Create()
        {
            return new StandardLoadGamesRepository();
        }

        private StandardLoadGamesRepository()
        {

        }
        public List<GameData> LoadAllFromFile(string path)
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<GameData>>(File.ReadAllText(path));
        }
    }
}
