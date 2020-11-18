﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Gateway;

namespace Gaming_Library.BL.UseCase.Entity
{
    struct EntityModel
    {
        public IRepositoryModel RepositoryModel;
        public GameData Game;
    }
}