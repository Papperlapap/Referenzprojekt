using System;
using System.Diagnostics;
using System.Linq;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;
using Gaming_Library.Library.BL.UseCase.Interactor.PathComposer;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    public class Start : ICommand
    {
        private Model Model;

        public static ICommand Create(Model model)
        {
            return new Start(model);
        }
        private Start(Model model)
        {
            Model = model;
        }
        public void Do(IRequest request)
        {
            var startRequest = (InputPort.Requests.Start)request;
            var pathtype = Model.Games.ElementAt(startRequest.GameIndex).SteamId != null ? PathTypes.STEAM : PathTypes.NON_STEAM;
            var pathComposer = GamePathComposerFactory.CreatePathComposer(pathtype);
            var execPath = pathComposer.ComposeExecutablePath(Model.Games.ElementAt(startRequest.GameIndex));
            Process.Start(execPath);
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
