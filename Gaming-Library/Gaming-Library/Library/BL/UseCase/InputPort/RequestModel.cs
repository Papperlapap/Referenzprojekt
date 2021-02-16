using System;
using System.Collections.Generic;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.Library.BL.UseCase.InputPort
{
    public sealed class RequestModel
    {
        public List<IRequest> Requests { get; set; }

        public RequestModel()
        {
            Requests = new List<IRequest>();
        }
    }
}
