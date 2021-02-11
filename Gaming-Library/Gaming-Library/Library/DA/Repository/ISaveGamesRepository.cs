using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository
{
    public interface ISaveGamesRepository
    {
        public void SaveToFile(List<GameData> itemsToSave, string path);
    }
}
