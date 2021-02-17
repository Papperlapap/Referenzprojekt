using System;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Gaming_Library.Library.BL.UseCase.OutputPort;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Game_Library.UseCase.OutputPort
{
    [TestClass]
    public class ToResponseModel_Test
    {

        [TestCategory("Unit Test")]

        [TestMethod]
        public void CreateToResponseModelTest()
        {
            var interactorModel = new Gaming_Library.Library.BL.UseCase.Interactor.Model();
            var injector = new ToResponseModel.Injector(interactorModel);
            var responseModelConverter = ToResponseModel.Create(injector);

            Assert.IsNotNull(responseModelConverter);
        }


        [TestMethod]
        public void ToResponseModelTest()
        {
            var interactorModel = new Gaming_Library.Library.BL.UseCase.Interactor.Model();
            interactorModel.Games.Add(new GameData()
            {
                SteamId = new Gaming_Library.Library.BL.UseCase.Entity.Types.SteamId(1),
                Title = new Gaming_Library.Library.BL.UseCase.Entity.Types.Title("Testgame"),
                Publisher = new Gaming_Library.Library.BL.UseCase.Entity.Types.Publisher("Memyself"),
                Year = new Gaming_Library.Library.BL.UseCase.Entity.Types.YearOfPublication(new DateTime(2021, 1, 1)),
                Genres = new List<Gaming_Library.Library.BL.UseCase.Entity.Types.Genre> { new Gaming_Library.Library.BL.UseCase.Entity.Types.Genre("Unittest") },
                Attributes = new Gaming_Library.Library.BL.UseCase.Entity.Types.GameAttributes(),
                Image = new Gaming_Library.Library.BL.UseCase.Entity.Types.Image("C:\\"),
                Location = new Gaming_Library.Library.BL.UseCase.Entity.Types.Location("here"),
                Tags = new List<Gaming_Library.Library.BL.UseCase.Entity.Types.Tag> { new Gaming_Library.Library.BL.UseCase.Entity.Types.Tag("tag1"), new Gaming_Library.Library.BL.UseCase.Entity.Types.Tag("tag2") },
            });
            var injector = new ToResponseModel.Injector(interactorModel);
            var responseModelConverter = ToResponseModel.Create(injector);
            var responseModel = responseModelConverter.CreateResponseModel();

            Assert.IsTrue(responseModel.Games.Count == 1);
            Assert.IsTrue(responseModel.Games[0].SteamId == interactorModel.Games[0].SteamId);
            Assert.IsTrue(responseModel.Games[0].Title == interactorModel.Games[0].Title);
            Assert.IsTrue(responseModel.Games[0].Year == interactorModel.Games[0].Year);
            Assert.IsTrue(responseModel.Games[0].Genres == interactorModel.Games[0].Genres);
            Assert.IsTrue(responseModel.Games[0].Attributes == interactorModel.Games[0].Attributes);
            Assert.IsTrue(responseModel.Games[0].Image == interactorModel.Games[0].Image);
            Assert.IsTrue(responseModel.Games[0].Location == interactorModel.Games[0].Location);
            Assert.IsTrue(responseModel.Games[0].Tags == interactorModel.Games[0].Tags);
        }



    }
}
