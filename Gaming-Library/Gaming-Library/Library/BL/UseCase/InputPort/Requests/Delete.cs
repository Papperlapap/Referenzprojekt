using System;

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
