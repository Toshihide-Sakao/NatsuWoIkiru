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
    public class BackgroundTwoSides : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "sb/white.jpg";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 1;

        [Configurable]
        public Color4 rightcolor;

        [Configurable]
        public Color4 leftcolor;

        public override void Generate()
        {
            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bgRight = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre, new Vector2(320 - 213.5f, 240 + 480));
            bgRight.ScaleVec(StartTime, 427.0f / bitmap.Width, 480.0f / bitmap.Height);
            bgRight.MoveY(OsbEasing.OutQuint, StartTime, StartTime + 500, 240 + 480, 240);
            bgRight.Color(StartTime, EndTime, rightcolor, rightcolor);

            var bgLeft = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre, new Vector2(320 + 213.5f, 240 - 480));
            bgLeft.ScaleVec(StartTime, 427.0f / bitmap.Width, 480.0f / bitmap.Height);
            bgLeft.MoveY(OsbEasing.OutQuint, StartTime, StartTime + 500, 240 - 480, 240);
            bgLeft.Color(StartTime, EndTime, leftcolor, leftcolor);
        }
    }
}
