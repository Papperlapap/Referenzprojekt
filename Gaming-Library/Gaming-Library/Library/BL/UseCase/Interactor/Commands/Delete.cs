using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    class Delete : ICommand
    {
        private UseCase.Interactor.Model _interactorModel;
        DA.Repository.ISaveGamesRepository _repository;

        public static ICommand Create(UseCase.Interactor.Model interactorModel, DA.Repository.ISaveGamesRepository repository)
        {
            return new Delete(interactorModel, repository);
        }

        private Delete(UseCase.Interactor.Model interactorModel, DA.Repository.ISaveGamesRepository repository)
        {
            _interactorModel = interactorModel;
            _repository = repository;
        }


        public void Do(IRequest request)
        {
            var deleteRequest = (InputPort.Requests.Delete)request;
            _interactorModel.Games.RemoveAt(deleteRequest.GameIndex);
            _repository.SaveToFile(_interactorModel.Games, "games.json");
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }


    }
}

