using System;
using System.Linq;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.OutputPort;
using Gaming_Library.Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Presenter
{
    public sealed class ToViewModel : IToViewModel
    {
        private readonly Injector _injector;

        public struct Injector
        {
            public Injector(IResponseModel responseModel)
            {
                ResponseModel = (ResponseModel)responseModel;
            }

            public ResponseModel ResponseModel { get; }
        }


        public static IToViewModel Create(Injector injector)
        {
            return new ToViewModel(injector);
        }
        private ToViewModel(Injector injector)
        {
            _injector = injector;
        }

        public Model CreateViewModel()
        {
            var viewModel = new View.Model();

            viewModel.IsModified = _injector.ResponseModel.IsModified;

            foreach (var game in _injector.ResponseModel.Games) {
                var viewGame = new View.Model.GameData();
                viewGame.Attributes = game.Attributes;

                foreach (var genre in game.Genres) {
                    viewGame.Genres += genre.ToString() + ", ";
                }

                viewGame.Genres = viewGame.Genres.TrimEnd(' ', ',');
                viewGame.Image = game.Image.GameImage;
                viewGame.ImagePath = game.Image.ImagePath;
                viewGame.Location = game.Location.GameLocation;
                viewGame.Publisher = game.Publisher.GamePublisher;
                viewGame.SteamId = game.SteamId.ToString();
                viewGame.Title = game.Title.GameTitle;
                viewGame.Year = game.Year.PublicationYear.ToString("yyyy");
                viewGame.Tags = new List<string>();
                foreach (var tag in game.Tags) {
                    viewGame.Tags = viewGame.Tags.Append(tag.GameTag).ToList();

                }

                viewModel.Games.Add(viewGame);
            }
            return viewModel;
        }
    }
}
