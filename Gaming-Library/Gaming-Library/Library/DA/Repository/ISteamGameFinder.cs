using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.DA.Repository
{
    public interface ISteamGameFinder
    {
        List<App> FindGame(string term, string FilePath);
    }
}
