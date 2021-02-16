using System;

namespace Gaming_Library.Library.BL.UseCase.Interactor.PathComposer
{
    public class SteamGamePathComposer : IGamePathComposer
    {
        public static IGamePathComposer Create()
        {
            return new SteamGamePathComposer();
        }
        private SteamGamePathComposer()
        {
        }

        public string ComposeExecutablePath(Entity.GameData game)
        {
            return "steam://rungameid/" + game.SteamId.ToString();
        }
    }
}
