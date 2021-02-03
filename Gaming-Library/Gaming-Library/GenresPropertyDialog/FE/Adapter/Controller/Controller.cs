﻿using System;

using Gaming_Library.GenresPropertyDialog.BL.UseCase.InputPort;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.Controller
{
    public class Controller : IController
    {
        private Injector _injector;

        public sealed class Injector
        {
            public View.Model ViewModel;
            public IInteractor Interactor;

            public Injector(View.Model viewModel, IInteractor interactor)
            {
                ViewModel = viewModel;
                Interactor = interactor;
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

        public void SaveGenres(View.Model model)
        {
            var toSaveRequest = ToSaveRequest.Create(model);
            var saveRequest = toSaveRequest.CreateSaveRequest();
            SendRequest(saveRequest);
        }

        private void SendRequest(BL.UseCase.InputPort.Requests.IRequest request)
        {
            var requestModel = new RequestModel();
            requestModel.Requests.Add(request);
            _injector.Interactor.Update(requestModel);
        }
    }
}
