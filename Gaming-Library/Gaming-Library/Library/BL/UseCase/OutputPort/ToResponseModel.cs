using System;
using Gaming_Library.Library.BL.UseCase.Interactor;

namespace Gaming_Library.Library.BL.UseCase.OutputPort
{
    public class ToResponseModel : IToResponseModel
    {
        public struct Injector
        {
            public Interactor.Model InteractorModel;

            public Injector(Model interactorModel)
            {
                InteractorModel = interactorModel;
            }
        };

        private readonly Injector _injector;

        public static ToResponseModel Create(Injector injector)
        {
            return new ToResponseModel(injector);
        }
        private ToResponseModel(Injector injector)
        {
            _injector = injector;
        }


        public ResponseModel CreateResponseModel()
        {
            var responseModel = new ResponseModel();
            responseModel.IsModified = _injector.InteractorModel.IsModified;

            foreach (var game in _injector.InteractorModel.Games) {
                var responseGame = new ResponseModel.GameData();

                responseGame.Genres = game.Genres;
                responseGame.Image = game.Image;
                responseGame.Location = game.Location;
                responseGame.Publisher = game.Publisher;
                responseGame.SteamId = game.SteamId;
                responseGame.Tags = game.Tags;
                responseGame.Title = game.Title;
                responseGame.Year = game.Year;
                responseGame.Attributes = game.Attributes;

                responseModel.Games.Add(responseGame);
            }
            return responseModel;
        }
    }
}
