using System;

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
