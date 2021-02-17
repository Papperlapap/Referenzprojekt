using System;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class Tag
    {
        public Tag(string gameTag)
        {
            GameTag = gameTag;
        }

        public string GameTag { get; }
        public static bool operator ==(Tag left, Tag right) => Operator.Weave(left, right);
        public static bool operator !=(Tag left, Tag right) => Operator.Weave(left, right);
    }
}
