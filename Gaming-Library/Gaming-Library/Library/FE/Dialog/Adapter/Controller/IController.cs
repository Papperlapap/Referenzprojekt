using System.Windows.Forms;

using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Controller
{
    public interface IController
    {
        public void StartGame(int index);
        public void LoadData();
        public void DeleteGame(int index);
        public void AddGame(View.Model.GameData game);
        public void ModifyGame(int index, View.Model.GameData game);
        public void SearchForTitle(string title);
        public void EditGenres(int index, View.Model.GameData game);

    }
}