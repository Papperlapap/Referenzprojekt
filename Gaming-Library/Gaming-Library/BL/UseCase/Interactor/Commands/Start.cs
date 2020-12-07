﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using Gaming_Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.BL.UseCase.Interactor.PathComposer;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    public class Start : ICommand
    {
        private Injector _injector;

        public sealed class Injector
        {
            public Model Model;
        }

        public static ICommand Create(Injector injector)
        {
            return new Start(injector);
        }
        private Start(Injector injector)
        {
            _injector = injector;
        }
        public void Do(IRequest request)
        {
            var startRequest = (InputPort.Requests.Start)request;
            var pathtype = _injector.Model.Games.ElementAt(startRequest.GameIndex).SteamId != null ? PathTypes.STEAM : PathTypes.NON_STEAM;
            var pathComposer = GamePathComposerFactory.CreatePathComposer(pathtype);
            var execPath = pathComposer.ComposeExecutablePath(_injector.Model.Games.ElementAt(startRequest.GameIndex));
            Process.Start(execPath);
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
