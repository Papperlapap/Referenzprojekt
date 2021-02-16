using System;
using Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands
{
    class SearchGames : ICommand
    {
        private Model _model;

        public static ICommand Create(Model model)
        {
            return new SearchGames(model);
        }

        private SearchGames(Model model)
        {
            _model = model;
        }

        public void Do(IRequest request)
        {
            _model.steamGameData.searchResultList.applist.apps = _model.steamGameData.allSteamGames.applist.apps.FindAll(
                item => (item.name.ToLower()).Contains(_model.steamGameData.searchTerm.GameSearchTerm.ToLower())
                );
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
