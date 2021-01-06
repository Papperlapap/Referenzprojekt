﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.DA.Repository.Standard
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

            throw new NotImplementedException();
        }
    }
}
