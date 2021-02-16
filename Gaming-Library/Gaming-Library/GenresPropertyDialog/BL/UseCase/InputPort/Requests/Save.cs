using System;
using Gaming_Library.GenresPropertyDialog.BL.UseCase.Entity;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.InputPort.Requests
{
    public sealed class Save : IRequest
    {
        public GenreData Genres { get; }

        public Save(GenreData genres)
        {
            Genres = genres;
        }
    }
}
