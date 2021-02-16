using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.Entity;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    class Load : ICommand
    {
        private UseCase.Interactor.Model _interactorModel;
        private DA.Repository.ILoadGamesRepository _repository;

        public static ICommand Create(Model interactorModel, DA.Repository.ILoadGamesRepository repository)
        {
            return new Load(interactorModel, repository);

        }

        private Load(Model interactorModel, DA.Repository.ILoadGamesRepository repository)
        {
            _interactorModel = interactorModel;
            _repository = repository;
        }


        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }

        public void Do(IRequest request)
        {
            //createTestObjects();
            _interactorModel.Games = _repository.LoadAllFromFile("games.json");
        }

        private void createTestObjects()
        {
            _interactorModel.Games.Add(new GameData()
            {
                Genres = new Entity.Types.Genre[1] { new Entity.Types.Genre("Action") },
                Title = new Entity.Types.Title("Among Us"),
                Year = new Entity.Types.YearOfPublication(new DateTime(2018, 1, 1)),
                Image = new BL.UseCase.Entity.Types.Image("C:\\Users\\haziraj\\Documents\\Referenzprojekt\\Gaming-Library\\Gaming-Library\\Icons\\amongus.png"),
                Location = new Entity.Types.Location("C:\\"),
                Publisher = new Entity.Types.Publisher("SomeCoorp"),
                SteamId = new Entity.Types.SteamId(945360),
                Tags = new List<Entity.Types.Tag>(),
                Attributes = new Entity.Types.GameAttributes(),
            });

            _interactorModel.Games.Add(new GameData()
            {
                Genres = new Entity.Types.Genre[1] { new Entity.Types.Genre("Action") },
                Title = new Entity.Types.Title("Counter Strike"),
                Year = new Entity.Types.YearOfPublication(new DateTime(2012, 1, 1)),
                Image = new BL.UseCase.Entity.Types.Image("C:\\Users\\haziraj\\Documents\\Referenzprojekt\\Gaming-Library\\Gaming-Library\\Icons\\csgo.png"),
                Location = new Entity.Types.Location("C:\\"),
                Publisher = new Entity.Types.Publisher("Valve"),
                SteamId = new Entity.Types.SteamId(730),
                Tags = new List<Entity.Types.Tag>(),
                Attributes = new Entity.Types.GameAttributes(),
            });
        }
    }
}
