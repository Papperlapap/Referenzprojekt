using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.OutputPort;
using Gaming_Library.Library.FE.Dialog.Adapter.View;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Presenter
{
    public class Presenter : IPresenter
    {
        private Injector _injector;

        public sealed class Injector
        {
            public View.Model ViewModel;
            public List<View.IView> Views;

            public Injector(Model viewModel, List<IView> views)
            {
                ViewModel = viewModel;
                Views = views;
            }
        }

        public static IPresenter Create(Injector injector)
        {
            return new Presenter(injector);
        }
        private Presenter(Injector injector)
        {
            _injector = injector;
        }

        public void Update(IResponseModel responseModel)
        {
            var injector = new ToViewModel.Injector(responseModel);
            var responseModelConverter = ToViewModel.Create(injector);
            _injector.ViewModel.Clone(responseModelConverter.CreateViewModel());
            foreach (var view in _injector.Views) {
                view.UpdateView();
            }
        }
    }
}
