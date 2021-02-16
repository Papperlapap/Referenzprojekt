using System;
using System.Collections.Generic;

namespace Gaming_Library.GenresPropertyDialog.BL.UseCase.InputPort
{
    public interface IInteractor
    {
        abstract void Update(RequestModel requestmodel);
    }
}
