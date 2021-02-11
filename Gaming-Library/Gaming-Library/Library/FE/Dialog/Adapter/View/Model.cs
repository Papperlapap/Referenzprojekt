﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.Entity.Types;
using System.Drawing;

namespace Gaming_Library.FE.Dialog.Adapter.View
{
    public sealed class Model
    {
        public sealed class GameData
        {
            public string SteamId;
            public string Title;
            public string Publisher;
            public string Location;
            public string Year;
            public Bitmap Image;
            public string ImagePath;
            public string[] Tags;
            public string Genres;
            public GameAttributes Attributes = new GameAttributes();

            public GameData()
            {
            }

            public GameData(string steamId,
                string title,
                string publisher,
                string location,
                string year,
                Bitmap image,
                string imagePath,
                string[] tags,
                string genres,
                GameAttributes attributes)
            {
                SteamId = steamId;
                Title = title;
                Publisher = publisher;
                Location = location;
                Year = year;
                Image = image;
                ImagePath = imagePath;
                Tags = tags;
                Genres = genres;
                Attributes = attributes;
            }

            public GameData DeepCopy(GameData other)
            {
                return new GameData(other.SteamId,
                    other.Title,
                    other.Publisher,
                    other.Location,
                    other.Year,
                    other.Image,
                    other.ImagePath,
                    other.Tags,
                    other.Genres,
                    other.Attributes);
            }
        }

        public bool IsInvalidGame;
        public bool IsModified;
        public List<GameData> Games { get; set; }

        public Model()
        {
            Games = new List<GameData>();
        }

        public void Clone(Model model)
        {
            Games = model.Games;
        }
    }
}
