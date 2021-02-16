using System;

using Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort;
using Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands;
using Gaming_Library.ChooseSteamGame.BL.UseCase.OutputPort;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor
{
    public class Interactor : IInteractor
    {
        private Injector _injector;

        public sealed class Injector
        {

            public Model InteractorModel;
            public OutputPort.IPresenter Presenter;
            public Commands.ICommands Commands;

            public Injector(Model interactorModel, IPresenter presenter, ICommands commands)
            {
                InteractorModel = interactorModel;
                Presenter = presenter;
                Commands = commands;
            }
        }

        public static IInteractor Create(Injector injector)
        {
            return new Interactor(injector);
        }

        private Interactor(Injector injector)
        {
            _injector = injector;
        }

        public void Update(RequestModel requestmodel)
        {
            var injector = new InputPort.Requests.Processor.Injector(requestmodel, _injector.Commands);
            var processor = InputPort.Requests.Processor.Create(injector);
            processor.Execute();
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            var injector = new ToResponseModel.Injector(_injector.InteractorModel);
            var interactorModelConverter = ToResponseModel.Create(injector);
            var responseModel = interactorModelConverter.CreateResponseModel();
            _injector.Presenter.Update(responseModel);
        }

    }
}
