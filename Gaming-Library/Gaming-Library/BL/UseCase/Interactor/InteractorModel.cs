﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.Interactor
{
    public sealed class InteractorModel
    {
        public Entity.GameData Game { get; }
        public bool IsModified { get; }
    }
}
