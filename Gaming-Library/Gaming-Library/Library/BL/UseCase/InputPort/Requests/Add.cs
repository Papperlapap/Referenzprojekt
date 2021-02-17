using System;
using System.Collections.Generic;


namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public class Add : IRequest
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
            public Entity.Types.GameAttributes? Attributes;
#nullable disable
        }
        public GameData Game = new GameData();
    }
}
