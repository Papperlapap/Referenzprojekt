﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaming_Library.BL.UseCase.Entity.Types;

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
