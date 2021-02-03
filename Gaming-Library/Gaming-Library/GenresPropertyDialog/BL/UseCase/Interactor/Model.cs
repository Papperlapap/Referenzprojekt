﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.Interactor
{
    public sealed class Model
    {
        public Entity.GenreData Genres { get; set; }

        public bool IsModified { get; set; }

        public void Clone(Model model)
        {
            IsModified = model.IsModified;
            Genres = model.Genres;
        }
    }
}
