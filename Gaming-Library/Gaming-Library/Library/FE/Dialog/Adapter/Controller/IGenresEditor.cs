using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Library.Library.FE.Dialog.Adapter.Controller
{
    public interface IGenresEditor
    {
        public GenresPropertyDialog.FE.Dialog.Adapter.View.Model UpdateGenres(int index);
    }
}
