using System;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class Title
    {
        public Title(string gameTitle)
        {
            GameTitle = gameTitle;
        }

        public string GameTitle { get; }
        public static bool operator ==(Title left, Title right) => Operator.Weave(left, right);
        public static bool operator !=(Title left, Title right) => Operator.Weave(left, right);
    }
}
