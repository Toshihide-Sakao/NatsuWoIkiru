using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Flash : StoryboardObjectGenerator
    {
        [Configurable]
        public string FlashPath = "";

        [Configurable]
        public int FlashTime = 0;

        [Configurable]
        public float offset = 50;

        [Configurable]
        public double Opacity = 0.8;

        [Configurable]
        public float red = 255;

        [Configurable]
        public float green = 255;

        [Configurable]
        public float blue = 255;

        public override void Generate()
        {
            float StartTime = FlashTime - offset;
            float EndTime = FlashTime + offset;

            var bitmap = GetMapsetBitmap(FlashPath);
            var flash = GetLayer("").CreateSprite(FlashPath, OsbOrigin.Centre);
            flash.Scale(StartTime, 870.0f / bitmap.Width);
            flash.Color(StartTime, red /255f, green /255f, blue /255f);
            flash.Fade(StartTime, FlashTime, 0, Opacity);
            flash.Fade(FlashTime, EndTime, Opacity, 0);
        }
    }
}
