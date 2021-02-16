using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.InputPort.Requests;

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
