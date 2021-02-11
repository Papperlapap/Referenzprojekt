using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            public string[]? Tags;
            public string? Genre;
            public Entity.Types.GameAttributes? Attributes;
#nullable disable
        }
        public GameData Game = new GameData();
    }
}
