using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.PropertyGridInternal;
using Gaming_Library.Library.BL.UseCase.InputPort;
using Gaming_Library.Library.BL.UseCase.Interactor.Commands;
using Gaming_Library.Library.BL.UseCase.OutputPort;

namespace Gaming_Library.Library.BL.UseCase.Interactor
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
            var injector = new OutputPort.ToResponseModel.Injector(_injector.InteractorModel);
            var interactorModelConverter = OutputPort.ToResponseModel.Create(injector);
            var responseModel = interactorModelConverter.CreateResponseModel();
            _injector.Presenter.Update(responseModel);
        }

    }
}
