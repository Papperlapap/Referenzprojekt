using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Library
{
    static class MainApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var interactorModel = new BL.UseCase.Interactor.Model();
            var viewModel = new FE.Dialog.Adapter.View.Model();

            //var inputRepository = DA.Repository.Standard.StandardLoadGamesRepository.Create();
            //var outputRepository = DA.Repository.Standard.StandardSaveGamesRepository.Create();
            var inputRepository = DA.Repository.Newtonsoft.NewtonsoftLoadGamesRepository.Create();
            var outputRepository = DA.Repository.Newtonsoft.NewtonsoftSaveGamesRepository.Create();

            var commands = BL.UseCase.Interactor.Commands.Commands.Create();
            commands.Add(BL.UseCase.Interactor.Commands.Load.Create(interactorModel, inputRepository));
            commands.Add(BL.UseCase.Interactor.Commands.Save.Create(interactorModel, outputRepository));
            commands.Add(BL.UseCase.Interactor.Commands.Start.Create(interactorModel));
            commands.Add(BL.UseCase.Interactor.Commands.Delete.Create(interactorModel, outputRepository));
            commands.Add(BL.UseCase.Interactor.Commands.Add.Create(interactorModel, outputRepository));
            commands.Add(BL.UseCase.Interactor.Commands.Modify.Create(interactorModel));

            var views = new List<FE.Dialog.Adapter.View.IView>();

            var presenterInjector = new FE.Dialog.Adapter.Presenter.Presenter.Injector(viewModel, views);
            var presenter = FE.Dialog.Adapter.Presenter.Presenter.Create(presenterInjector);

            var interactorInjector = new BL.UseCase.Interactor.Interactor.Injector(interactorModel, presenter, commands);
            var interactor = BL.UseCase.Interactor.Interactor.Create(interactorInjector);

            var genresEditor = new GenresPropertyDialog.FE.Adapter.Controller.GenresEditor(viewModel);
            var controllerInjector = new FE.Dialog.Adapter.Controller.Controller.Injector(viewModel, interactor, genresEditor);
            var controller = FE.Dialog.Adapter.Controller.Controller.Create(controllerInjector);

            views.Add(new LibraryDialog(controller, viewModel));

            Application.Run((LibraryDialog)views.ElementAt(0));
        }
    }
}
