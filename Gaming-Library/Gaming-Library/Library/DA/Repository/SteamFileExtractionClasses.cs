using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.DA.Repository
{
    public class SteamGameList
    {
        public AppList applist { get; set; }
    }
    public class AppList
    {
        public List<App> apps { get; set; }
    }

    public class App
    {
        public App(int appid, string name)
        {
            this.appid = appid;
            this.name = name;
        }

        public int appid { get; set; }
        public string name { get; set; }
    }
}
