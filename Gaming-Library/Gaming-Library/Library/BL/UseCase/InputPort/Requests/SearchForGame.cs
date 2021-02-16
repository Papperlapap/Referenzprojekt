using System;

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
