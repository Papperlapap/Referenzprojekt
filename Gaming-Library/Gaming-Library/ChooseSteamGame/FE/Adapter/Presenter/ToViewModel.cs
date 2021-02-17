using System;
using System.Linq;
using Gaming_Library.ChooseSteamGame.BL.UseCase.OutputPort;
using Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter.View;

namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter.Presenter
{
    public sealed class ToViewModel : IToViewModel
    {
        private readonly Injector _injector;

        public struct Injector
        {
            public Injector(ResponseModel responseModel)
            {
                ResponseModel = responseModel;
            }

            public ResponseModel ResponseModel { get; }
        }


        public static IToViewModel Create(Injector injector)
        {
            return new ToViewModel(injector);
        }
        private ToViewModel(Injector injector)
        {
            _injector = injector;
        }

        public Model CreateViewModel()
        {
            var viewModel = new View.Model();
            viewModel.IsModified = _injector.ResponseModel.IsModified;

            viewModel.steamGameData = _injector.ResponseModel.steamGameData;

            return viewModel;
        }
    }
}
