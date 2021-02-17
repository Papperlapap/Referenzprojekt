using System;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]

    public sealed class Location
    {
        public Location(string gameLocation)
        {
            GameLocation = gameLocation;
        }

        public string GameLocation { get; }
        public static bool operator ==(Location left, Location right) => Operator.Weave(left, right);
        public static bool operator !=(Location left, Location right) => Operator.Weave(left, right);
    }
}
