﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA.Repository
{
    public interface ILoadGamesRepository
    {
        public List<GameData> LoadAllFromFile(string path);
    }
}