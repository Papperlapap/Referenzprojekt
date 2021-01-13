﻿using System;

namespace Gaming_Library.BL.UseCase.Entity.Types
{
    public record GameAttributes
    {
        public bool IsMultiPlayer { get; set; }
        public bool IsSinglePlayer { get; set; }
        public bool IsCooperative { get; set; }
        public bool IsVRSupportive { get; set; }
        public bool HasFullControllerSupport { get; set; }
        public bool HasPartialControllerSupport { get; set; }
        public bool HasAchievements { get; set; }
    }
}