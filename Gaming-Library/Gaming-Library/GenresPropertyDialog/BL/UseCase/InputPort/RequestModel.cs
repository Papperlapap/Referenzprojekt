using System;
using System.Collections.Generic;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.InputPort
{
    public sealed class RequestModel
    {
        public List<Requests.IRequest> Requests { get; set; }

        public RequestModel()
        {
            Requests = new List<Requests.IRequest>();
        }
    }
}
