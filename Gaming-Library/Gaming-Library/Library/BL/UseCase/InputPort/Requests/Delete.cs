using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public sealed class Delete : IRequest
    {
        public readonly int GameIndex;

        public Delete(int GameIndex)
        {
            this.GameIndex = GameIndex;
        }
    }
}
