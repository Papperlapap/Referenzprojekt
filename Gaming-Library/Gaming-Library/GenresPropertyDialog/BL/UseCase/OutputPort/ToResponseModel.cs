﻿using System;

using Gaming_Library.GenresPropertyDialog.BL.UseCase.Interactor;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.OutputPort
{
    public class ToResponseModel : IToResponseModel
    {
        public struct Injector
        {
            public Interactor.Model InteractorModel;

            public Injector(Model interactorModel)
            {
                InteractorModel = interactorModel;
            }
        };

        private readonly Injector _injector;

        public static ToResponseModel Create(Injector injector)
        {
            return new ToResponseModel(injector);
        }
        private ToResponseModel(Injector injector)
        {
            _injector = injector;
        }


        public ResponseModel CreateResponseModel()
        {
            var responseModel = new ResponseModel();
            responseModel.IsModified = _injector.InteractorModel.IsModified;
            responseModel.Genres = _injector.InteractorModel.Genres;
            return responseModel;
        }
    }
}
