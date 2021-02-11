using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Adapter.Controller
{
    public class ToSaveRequest
    {

        private View.Model _genres;
        public static ToSaveRequest Create(View.Model genres)
        {
            return new ToSaveRequest(genres);
        }

        private ToSaveRequest(View.Model genres)
        {
            _genres = genres;
        }

        public BL.UseCase.InputPort.Requests.Save CreateSaveRequest()
        {
            var genres = new BL.UseCase.Entity.GenreData();

            foreach (var genre in _genres.Genres.Genres) {
                genres.Genres = genres.Genres.Append(new Library.BL.UseCase.Entity.Types.Genre(genre)).ToArray();
            }

            var saveRequest = new BL.UseCase.InputPort.Requests.Save(genres);
            return saveRequest;
        }
    }
}
