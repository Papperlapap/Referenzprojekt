using System;
using System.IO;
using System.Collections.Generic;


namespace Gaming_Library.Library.DA.Repository.Standard
{
    public class StandardSteamGameFinder : ISteamGameFinder
    {

        public static ISteamGameFinder Create()
        {
            return new StandardSteamGameFinder();
        }
        private StandardSteamGameFinder()
        {
        }

        public List<App> FindGame(string term, string FilePath)
        {
            var applist = System.Text.Json.JsonSerializer.Deserialize<SteamGameList>(File.ReadAllText(FilePath));

            return applist.applist.apps.FindAll(item => item.name.Contains(term));
        }
    }
}
