using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class YearOfPublication
    {
        public YearOfPublication(DateTime publicationYear)
        {
            PublicationYear = publicationYear;
        }

        public DateTime PublicationYear { get; }
        public static bool operator ==(YearOfPublication left, YearOfPublication right) => Operator.Weave(left, right);
        public static bool operator !=(YearOfPublication left, YearOfPublication right) => Operator.Weave(left, right);
        public override string ToString()
        {
            return PublicationYear.ToString("yyyy-mm-dd");
        }
    }
}
