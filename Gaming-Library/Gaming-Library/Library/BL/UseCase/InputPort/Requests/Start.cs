using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.Library.BL.UseCase.Entity;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public sealed class Start : IRequest
    {

        public readonly int GameIndex;

        public Start(int GameIndex)
        {
            this.GameIndex = GameIndex;
        }
    }
}
