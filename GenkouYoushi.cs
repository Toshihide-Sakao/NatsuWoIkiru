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
    public class GenkouYoushi : StoryboardObjectGenerator
    {
        [Configurable]
        public string GenkouYoushiPath = "sb/yabuitagenkou.png";

        [Configurable]
        public Vector2 pos = new Vector2(400, 240);

        [Configurable]
        public float Scale = 1;

        [Configurable]
        public int startTime = 151377;

        [Configurable]
        public int endTime = 173624;

        public override void Generate()
        {
            var genkou = GetLayer("").CreateSprite(GenkouYoushiPath, OsbOrigin.Centre, pos);

            genkou.Scale(startTime, endTime, Scale, Scale);
            genkou.Fade(startTime, startTime + 100, 0, 0.9f);
            genkou.Fade(endTime - 100, endTime, 0.9f, 0);
        }
    }
}
