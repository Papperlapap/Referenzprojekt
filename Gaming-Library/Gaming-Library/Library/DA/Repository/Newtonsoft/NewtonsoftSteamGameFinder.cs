using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

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
