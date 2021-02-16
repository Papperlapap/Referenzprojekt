using System;

namespace Gaming_Library.Library.BL.UseCase.Interactor.PathComposer
{
    public interface IGamePathComposer
    {
        public string ComposeExecutablePath(Entity.GameData game);
    }
}
