using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.OutputPort
{
    public sealed class ResponseModel : IResponseModel
    {
        public sealed class GameData
        {
            public Entity.Types.SteamId SteamId;
            public Entity.Types.Title Title;
            public Entity.Types.Publisher Publisher;
            public Entity.Types.Location Location;
            public Entity.Types.YearOfPublication Year;
            public Entity.Types.Image Image;
            public List<Entity.Types.Tag> Tags;
            public Entity.Types.Genre[] Genres;
            public Entity.Types.GameAttributes Attributes;
        }

        public bool IsModified;
        public List<GameData> Games { get; set; }

        public ResponseModel()
        {
            Games = new List<GameData>();
        }

        public void Clone(ResponseModel model)
        {
            IsModified = model.IsModified;
            Games = model.Games;
        }
    }
}

