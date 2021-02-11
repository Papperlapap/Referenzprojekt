using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Controller
{
    public class ToAddRequest
    {

        private View.Model.GameData _game;
        public static ToAddRequest Create(View.Model.GameData game)
        {
            return new ToAddRequest(game);
        }

        private ToAddRequest(View.Model.GameData game)
        {
            _game = game;
        }

        public BL.UseCase.InputPort.Requests.Add CreateAddRequest()
        {
            var addRequest = new BL.UseCase.InputPort.Requests.Add();

            addRequest.Game.Attributes = _game.Attributes;
            addRequest.Game.Genre = _game.Genres;
            addRequest.Game.ImagePath = _game.ImagePath;
            addRequest.Game.Location = _game.Location;
            addRequest.Game.SteamId = _game.SteamId;
            addRequest.Game.Tags = _game.Tags;
            addRequest.Game.Title = _game.Title;
            addRequest.Game.Year = _game.Year;

            return addRequest;
        }
    }
}
