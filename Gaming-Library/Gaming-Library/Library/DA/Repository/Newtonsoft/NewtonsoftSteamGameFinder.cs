using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Gaming_Library.Library.DA.Repository.Newtonsoft
{
    public class NewtonsoftSteamGameFinder : ISteamGameFinder
    {

        public static ISteamGameFinder Create()
        {
            return new NewtonsoftSteamGameFinder();
        }
        private NewtonsoftSteamGameFinder()
        {
        }


        public List<App> FindGame(string term, string path)
        {
            var applist = JsonConvert.DeserializeObject<SteamGameList>(File.ReadAllText(path));

            return applist.applist.apps.FindAll(item => item.name.Contains(term));
        }
    }
}
