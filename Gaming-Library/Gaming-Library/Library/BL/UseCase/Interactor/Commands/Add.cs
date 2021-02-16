using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.Entity.Types;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    public class Add : ICommand
    {
        private Model _model;
        private DA.Repository.ISaveGamesRepository _repository;

        public static ICommand Create(Model model, DA.Repository.ISaveGamesRepository repository)
        {
            return new Add(model, repository);
        }
        private Add(Model model, DA.Repository.ISaveGamesRepository repository)
        {
            _model = model;
            _repository = repository;
        }
        public void Do(IRequest request)
        {
            var addRequest = (InputPort.Requests.Add)request;

            _model.Games.Add(new Entity.GameData()
            {
                SteamId = new SteamId(Convert.ToInt32(addRequest.Game.SteamId)),
                Title = new Title(addRequest.Game.Title),
                Publisher = new Publisher(addRequest.Game.Publisher),
                Location = new Location(addRequest.Game.Location),
                Image = new Image(addRequest.Game.ImagePath),
                Tags = new List<Tag>(),
                Year = new YearOfPublication(new DateTime(Convert.ToInt32(addRequest.Game.Year), 1, 1)),
                Genres = new List<Genre>(),
                Attributes = addRequest.Game.Attributes,
            });
            foreach (var tag in addRequest.Game.Genres.Split(',')) {
                var index = _model.Games.Count - 1;
                _model.Games[index].Genres.Add(new Genre(tag.Trim()));

            }
            foreach (var tag in addRequest.Game.Tags) {
                var index = _model.Games.Count - 1;
                _model.Games[index].Tags.Add(new Tag(tag));

            }
            _repository.SaveToFile(_model.Games, "games.json");
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
