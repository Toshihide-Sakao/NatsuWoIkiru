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
    public class SinWave : StoryboardObjectGenerator
    {
        [Configurable]
        public string path = "sb/white.jpg";

        [Configurable]
        public float startTime;

        [Configurable]
        public float endTime;

        [Configurable]
        public float scale = 20;

        public override void Generate()
        {
		    var layer = GetLayer("");

            var sq = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(- 150, 240);
            
        }
    }
}
