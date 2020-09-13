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
    public class BackgroundFromBlur : StoryboardObjectGenerator
    {
        [Configurable]
        public string blurPath = "sb/GirlHatBlur1.png";

        [Configurable]
        public string bgPath = "sb/GirlHat.png";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int StartNormalTime = 0;

        [Configurable]
        public int EndNormalTime = 85983;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        public override void Generate()
        {

            var bitmap = GetMapsetBitmap(bgPath);

            var blurBg = GetLayer("").CreateSprite(blurPath, OsbOrigin.Centre);
            blurBg.Scale(StartTime, 854.0f / bitmap.Width);
            blurBg.Fade(StartTime, StartTime + 100, 0, Opacity);
            blurBg.Fade(StartTime + 200, StartNormalTime, Opacity, 0);

            var bg = GetLayer("").CreateSprite(bgPath, OsbOrigin.Centre);
            bg.Scale(StartTime, 854.0f / bitmap.Width);
            bg.Fade(StartTime, StartTime + 200, 0, Opacity);
            bg.Fade(EndNormalTime, EndTime, Opacity, 0);
            
            

            
        }
    }
}
