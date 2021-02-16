using System;
using System.Collections.Generic;

namespace Gaming_Library.Library.BL.UseCase.Interactor
{
    public sealed class Model
    {
        public List<Entity.GameData> Games { get; set; }

        public bool IsModified { get; set; }

        public Model()
        {
            Games = new List<Entity.GameData>();
        }

        public void Clone(Model model)
        {
            IsModified = model.IsModified;
            Games = model.Games;
        }
    }
}
