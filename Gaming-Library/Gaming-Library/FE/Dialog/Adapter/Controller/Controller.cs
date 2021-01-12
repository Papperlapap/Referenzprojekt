﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity;
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

        public void ModifyGame(int index, View.Model viewModel)
        {
            var toModifyRequest = ToModifyRequest.Create(index, viewModel);
            var request = toModifyRequest.CreateModifyRequest();
            SendRequest(request);
        }

        private void SendRequest(IRequest request)
        {
            var requestModel = new RequestModel();
            requestModel.Requests.Add(request);
            _injector.Interactor.Update(requestModel);
        }

    }
}