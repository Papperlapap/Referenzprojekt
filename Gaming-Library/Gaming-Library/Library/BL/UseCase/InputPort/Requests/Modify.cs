using System.Collections.Generic;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public sealed class Modify : IRequest
    {

        public sealed class GameData
        {
#nullable enable
            public string? SteamId;
            public string? Title;
            public string? Publisher;
            public string? Location;
            public string? Year;
            public string? ImagePath;
            public List<string>? Tags;
            public string? Genres;
            public BL.UseCase.Entity.Types.GameAttributes? Attributes;
#nullable disable
        }
        public readonly int GameIndex;
        public GameData Game;

        public Modify(int gameIndex)
        {
            GameIndex = gameIndex;
            Game = new GameData();
        }
    }
}
