﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Library.BL.UseCase.OutputPort
{
    public interface IToResponseModel
    {
        public ResponseModel CreateResponseModel();
    }
}