﻿using System;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]

    public sealed class Publisher
    {
        public Publisher(string gamePublisher)
        {
            GamePublisher = gamePublisher;
        }

        public string GamePublisher { get; }
        public static bool operator ==(Publisher left, Publisher right) => Operator.Weave(left, right);
        public static bool operator !=(Publisher left, Publisher right) => Operator.Weave(left, right);
    }
}
