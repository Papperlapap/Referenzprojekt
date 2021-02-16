using System;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.Interactor.Commands
{
    public class Save : ICommand
    {
        private Model _model;
        private DA.Repository.ISaveGamesRepository _repository;

        public static ICommand Create(Model model, DA.Repository.ISaveGamesRepository repository)
        {
            return new Save(model, repository);
        }
        private Save(Model model, DA.Repository.ISaveGamesRepository repository)
        {
            _model = model;
            _repository = repository;

        }
        public void Do(IRequest request)
        {
            _repository.SaveToFile(_model.Games, "");
        }

        public int GetId()
        {
            return GetType().Name.GetHashCode();
        }
    }
}
