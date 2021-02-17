using System;

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
