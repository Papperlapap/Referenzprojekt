﻿using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository
{
    public interface ILoadGamesRepository
    {
        public List<GameData> LoadAllFromFile(string path);
    }
}
