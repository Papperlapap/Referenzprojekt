using System;

namespace Gaming_Library.Library.BL.UseCase.InputPort
{
    public interface IInteractor
    {
        abstract void Update(RequestModel requestmodel);
    }
}
