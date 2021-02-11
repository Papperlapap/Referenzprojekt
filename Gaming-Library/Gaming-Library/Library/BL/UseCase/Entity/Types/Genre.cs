using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class Genre
    {
        public Genre(string gameGenre)
        {
            GameGenre = gameGenre;
        }

        public string GameGenre { get; }
        public static bool operator ==(Genre left, Genre right) => Operator.Weave(left, right);
        public static bool operator !=(Genre left, Genre right) => Operator.Weave(left, right);

        public override string ToString()
        {
            return GameGenre;
        }
    }
}
