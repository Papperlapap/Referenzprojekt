using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class SearchTerm
    {
        public SearchTerm(string searchTerm)
        {
            GameSearchTerm = searchTerm;
        }

        public string GameSearchTerm { get; set; }
        public static bool operator ==(SearchTerm left, SearchTerm right) => Operator.Weave(left, right);
        public static bool operator !=(SearchTerm left, SearchTerm right) => Operator.Weave(left, right);
    }
}
