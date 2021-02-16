using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;

namespace Gaming_Library.Library.BL.UseCase.Entity.Types
{
    [Equals]
    public sealed class Image
    {
        public Image(string imagePath = "")
        {
            ImagePath = imagePath;
            try {
                GameImage = new Bitmap(imagePath);
            } catch (ArgumentException ex) {
                //TODO: react appropriately
            }
        }

        public override string ToString()
        {
            return ImagePath;
        }

        [Newtonsoft.Json.JsonIgnore]
        public Bitmap GameImage { get; }
        public string ImagePath { get; }
        public static bool operator ==(Image left, Image right) => Operator.Weave(left, right);
        public static bool operator !=(Image left, Image right) => Operator.Weave(left, right);
    }
}
