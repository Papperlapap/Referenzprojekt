using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.DA.Repository.Newtonsoft
{
    public class NewtonsoftSaveGamesRepository : ISaveGamesRepository
    {

        public static ISaveGamesRepository Create()
        {
            return new NewtonsoftSaveGamesRepository();
        }

        private NewtonsoftSaveGamesRepository()
        {

        }
        public void SaveToFile(List<GameData> itemsToSave, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(itemsToSave));
        }
    }
}
