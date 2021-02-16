using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.Library.BL.UseCase.InputPort.Requests
{
    public class OpenProperties : IRequest
    {
        public readonly int GameIndex;

        public OpenProperties(int GameIndex)
        {
            this.GameIndex = GameIndex;
        }
    }
}
