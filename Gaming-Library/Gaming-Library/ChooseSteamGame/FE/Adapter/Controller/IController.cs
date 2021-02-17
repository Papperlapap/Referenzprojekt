using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter.Controller
{
    public interface IController
    {
        public void SaveChosenGame(View.Model model);
        public void searchForGames(BL.UseCase.Entity.SteamGameData steamGameData);
    }
}