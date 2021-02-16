using System;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    public sealed class SearchForGame : ICommand
    {
        private UseCase.Interactor.Model _interactorModel;
        private DA.Repository.ISteamGameFinder _gameFinder;

        public static ICommand Create()
        {
            return new SearchForGame();
        }
        private SearchForGame()
        {

        }

        public void Do(IRequest request)
        {
            var searchRequest = (InputPort.Requests.SearchForGame)request;
            //_interactorModel.Games = _gameFinder.FindGame(searchRequest._searchTerm, "games.json");

        }

        public int GetId()
        {
            throw new NotImplementedException();
        }
    }
}
