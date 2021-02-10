using System;
using System.Windows.Forms;
using Gaming_Library.BL.UseCase.InputPort;
using Gaming_Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.FE.Dialog.Adapter.Controller
{
    public class Controller : IController
    {
        private Injector _injector;

        public sealed class Injector
        {
            public View.Model ViewModel;
            public IInteractor Interactor;
            public IGenresEditor GenresEditor;

            public Injector(View.Model viewModel, IInteractor interactor, IGenresEditor genresEditor)
            {
                ViewModel = viewModel;
                Interactor = interactor;
                GenresEditor = genresEditor;
            }
        }

        public static IController Create(Injector injector)
        {
            return new Controller(injector);
        }
        private Controller(Injector injector)
        {
            _injector = injector;
        }

        public void StartGame(int index)
        {
            SendRequest(new BL.UseCase.InputPort.Requests.Start(index));
        }
        public void AddGame(View.Model.GameData game)
        {
            var toAddRequest = ToAddRequest.Create(game);
            var request = toAddRequest.CreateAddRequest();
            SendRequest(request);
        }
        public void DeleteGame(int index)
        {
            SendRequest(new BL.UseCase.InputPort.Requests.Delete(index));
        }
        public void OpenProperties(int index)
        {
            SendRequest(new BL.UseCase.InputPort.Requests.OpenProperties(index));
        }

        public void LoadData()
        {
            SendRequest(new BL.UseCase.InputPort.Requests.Load());
        }

        public void Save()
        {
            SendRequest(new BL.UseCase.InputPort.Requests.Save());
        }

        public void ModifyGame(int index, View.Model.GameData game)
        {
            var toModifyRequest = ToModifyRequest.Create(index, game);
            var request = toModifyRequest.CreateModifyRequest();
            SendRequest(request);
        }

        public void SearchForTitle(string title)
        {
            SendRequest(new BL.UseCase.InputPort.Requests.SearchForGame(title));
        }

        public void EditGenres(int index, View.Model.GameData game)
        {
            var genres = _injector.GenresEditor.UpdateGenres(index);
            game.Genres = string.Join(",", genres.Genres.Genres);
        }


        private void SendRequest(IRequest request)
        {
            var requestModel = new RequestModel();
            requestModel.Requests.Add(request);
            _injector.Interactor.Update(requestModel);
        }
    }
}
