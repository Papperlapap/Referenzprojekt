using System;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class SteamId
    {
        public SteamId(int? id)
        {
            Id = id;
        }

        public int? Id { get; }
        public static bool operator ==(SteamId left, SteamId right) => Operator.Weave(left, right);
        public static bool operator !=(SteamId left, SteamId right) => Operator.Weave(left, right);
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
