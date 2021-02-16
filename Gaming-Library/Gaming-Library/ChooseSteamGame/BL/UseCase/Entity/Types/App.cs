using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.Types
{
        [Equals]
        public sealed class App
        {
            public int appid { get; set; }
            public string name { get; set; }

        public static bool operator ==(App left, App right) => Operator.Weave(left, right);
        public static bool operator !=(App left, App right) => Operator.Weave(left, right);
     }
}
