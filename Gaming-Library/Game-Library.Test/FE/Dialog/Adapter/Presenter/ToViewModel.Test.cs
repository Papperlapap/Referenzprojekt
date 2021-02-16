using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.FE.Dialog.Adapter.Presenter;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Game_Library.Library.Test.FE.Dialog.Adapter.Presenter
{

    [TestClass]
    class ToViewModel_Test
    {
        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateToViewModelTest()
        {
            var responseModel = new Gaming_Library.Library.BL.UseCase.OutputPort.ResponseModel();
            var injector = new ToViewModel.Injector(responseModel);
            var viewModelConverter = ToViewModel.Create(injector);

            Assert.IsNotNull(viewModelConverter);
        }

        public void ToViewModelTest()
        {
            var responseModel = new Gaming_Library.Library.BL.UseCase.OutputPort.ResponseModel();
            responseModel.Games.Add(new Gaming_Library.Library.BL.UseCase.OutputPort.ResponseModel.GameData()
            {
                SteamId = new Gaming_Library.Library.BL.UseCase.Entity.Types.SteamId(1),
                Title = new Gaming_Library.Library.BL.UseCase.Entity.Types.Title("Testgame"),
                Publisher = new Gaming_Library.Library.BL.UseCase.Entity.Types.Publisher("Memyself"),
                Year = new Gaming_Library.Library.BL.UseCase.Entity.Types.YearOfPublication(new DateTime(2021, 1, 1)),
                Genres = new Gaming_Library.Library.BL.UseCase.Entity.Types.Genre[1] { new Gaming_Library.Library.BL.UseCase.Entity.Types.Genre("Unittest") },
                Attributes = new Gaming_Library.Library.BL.UseCase.Entity.Types.GameAttributes(),
                Image = new Gaming_Library.Library.BL.UseCase.Entity.Types.Image(null),
                Location = new Gaming_Library.Library.BL.UseCase.Entity.Types.Location("here"),
                Tags = new Gaming_Library.Library.BL.UseCase.Entity.Types.Tag[2] { new Gaming_Library.Library.BL.UseCase.Entity.Types.Tag("tag1"), new Gaming_Library.Library.BL.UseCase.Entity.Types.Tag("tag2") },
            });


            var injector = new ToViewModel.Injector(responseModel);
            var viewModelConverter = ToViewModel.Create(injector);
            var viewModel = viewModelConverter.CreateViewModel();

            Assert.IsTrue(viewModel.Games.Count == 1);
            Assert.IsTrue(viewModel.Games[0].SteamId == responseModel.Games[0].SteamId.ToString());
            Assert.IsTrue(viewModel.Games[0].Title == responseModel.Games[0].Title.ToString());
            Assert.IsTrue(viewModel.Games[0].Year == responseModel.Games[0].Year.ToString());
            //TODO: fix this
            Assert.IsTrue(viewModel.Games[0].Genres == responseModel.Games[0].Genres[0].ToString());
            //
            Assert.IsTrue(viewModel.Games[0].Attributes == responseModel.Games[0].Attributes);
            Assert.IsTrue(viewModel.Games[0].Image == responseModel.Games[0].Image.GameImage);
            Assert.IsTrue(viewModel.Games[0].Location == responseModel.Games[0].Location.ToString());
            //TODO: fix this
            Assert.IsTrue(viewModel.Games[0].Tags.Length == responseModel.Games[0].Tags.Length);

        }
    }
}
