using System;
using Gaming_Library.Library.BL.UseCase.Entity.Types;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.Entity
{
    [Equals]
    public sealed class GenreData
    {
        public Genre[] Genres { get; set; }

        public GenreData()
        {
            Genres = new Genre[0];
        }

        public static bool operator ==(GenreData left, GenreData right) => Operator.Weave(left, right);
        public static bool operator !=(GenreData left, GenreData right) => Operator.Weave(left, right);
    }
}
