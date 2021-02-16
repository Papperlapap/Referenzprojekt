using System;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Controller
{
    public class ToModifyRequest
    {

        private View.Model.GameData _game;
        private int _gameIndex;
        public static ToModifyRequest Create(int gameIndex, View.Model.GameData game)
        {
            return new ToModifyRequest(gameIndex, game);
        }

        private ToModifyRequest(int gameIndex, View.Model.GameData game)
        {
            _game = game;
            _gameIndex = gameIndex;
        }

        public BL.UseCase.InputPort.Requests.Modify CreateModifyRequest()
        {
            var modifyRequest = new BL.UseCase.InputPort.Requests.Modify(_gameIndex);

            modifyRequest.Game.Attributes = _game.Attributes;
            modifyRequest.Game.Genres = _game.Genres;
            modifyRequest.Game.ImagePath = _game.ImagePath;
            modifyRequest.Game.Location = _game.Location;
            modifyRequest.Game.SteamId = _game.SteamId;
            modifyRequest.Game.Tags = _game.Tags;
            modifyRequest.Game.Title = _game.Title;
            modifyRequest.Game.Year = _game.Year;
            modifyRequest.Game.Publisher = _game.Publisher;

            return modifyRequest;
        }
    }
}
