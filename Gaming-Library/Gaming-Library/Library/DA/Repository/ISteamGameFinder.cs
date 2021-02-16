using System;
using System.Collections.Generic;

namespace Gaming_Library.Library.DA.Repository
{
    public interface ISteamGameFinder
    {
        List<App> FindGame(string term, string FilePath);
    }
}
