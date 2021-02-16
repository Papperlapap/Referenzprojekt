using System;
using Gaming_Library.ChooseSteamGame.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.ChooseSteamGame.BL.UseCase.Interactor.Commands
{
    public class Save : ICommand
    {
        private Model _model;

        public static ICommand Create(Model model)
        {
            return new Save(model);
        }
        private Save(Model model)
        {
            _model = model;
        }
        public void Do(IRequest request)
        {
            var saveRequest = (InputPort.Requests.Save)request;
            _model.steamGameData = saveRequest.steamGameData;
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
