using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public sealed class SearchForGame : IRequest
    {
        public readonly string _searchTerm;

        public SearchForGame(string searchTerm)
        {
            _searchTerm = searchTerm;
        }
    }
}
