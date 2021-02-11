using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Entity;
using Gaming_Library.Library.BL.UseCase.Entity.Types;
using System.Drawing;

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
            public string[]? Tags;
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
