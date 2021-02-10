using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.View;
using System.Windows.Forms;

namespace Gaming_Library.GenresPropertyDialog.FE.Adapter.Controller
{
    public class GenresEditor : Gaming_Library.FE.Dialog.Adapter.Controller.IGenresEditor
    {
        private Gaming_Library.FE.Dialog.Adapter.View.Model _viewModel;
        public GenresEditor(Gaming_Library.FE.Dialog.Adapter.View.Model viewModel)
        {
            _viewModel = viewModel;
        }

        public Model UpdateGenres(int index)
        {
            var interactorModel = new BL.UseCase.Interactor.Model();
            var viewModel = new Model();

            foreach (var genre in _viewModel.Games.ElementAt(index).Genres.Split(',')) {
                viewModel.Genres.Genres.Add(genre);
            }

            var commands = BL.UseCase.Interactor.Commands.Commands.Create();
            commands.Add(BL.UseCase.Interactor.Commands.Save.Create(interactorModel));

            var views = new List<IView>();

            var presenterInjector = new Dialog.Adapter.Presenter.Presenter.Injector(viewModel, views);
            var presenter = Dialog.Adapter.Presenter.Presenter.Create(presenterInjector);

            var interactorInjector = new BL.UseCase.Interactor.Interactor.Injector(interactorModel, presenter, commands);
            var interactor = BL.UseCase.Interactor.Interactor.Create(interactorInjector);

            var controllerInjector = new Dialog.Adapter.Controller.Controller.Injector(viewModel, interactor);
            var controller = Dialog.Adapter.Controller.Controller.Create(controllerInjector);


            var genresPropertyDialog = new Dialog.Framework.UserInterface.ListOfGenres(controller, viewModel);

            if (genresPropertyDialog.ShowDialog() == DialogResult.OK) {
                return viewModel;
            }
            return null;
        }
    }
}
