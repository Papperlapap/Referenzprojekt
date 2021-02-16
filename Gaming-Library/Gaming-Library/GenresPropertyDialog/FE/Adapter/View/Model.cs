using System;
using System.Collections.Generic;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.View
{
    public sealed class Model
    {
        public sealed class GenreData
        {

            public List<string> Genres;

            public GenreData()
            {
                Genres = new List<string>();
            }
        }

        public bool IsInvalidGame;
        public bool IsModified;
        public GenreData Genres { get; set; }

        public Model()
        {
            Genres = new GenreData();
        }

        public void Clone(Model model)
        {
            Genres = model.Genres;
        }
    }
}
