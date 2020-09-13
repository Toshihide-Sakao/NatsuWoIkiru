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
    public class Girl : StoryboardObjectGenerator
    {
        [Configurable]
        public string girlPath = "sb/YukataGirlCut.png";

        [Configurable]
        public string pixelPath = "sb/white.jpg";

        [Configurable]
        public float startTime = 33062;

        [Configurable]
        public float endTime = 43848;

        [Configurable]
        public Color4 backColor;

        [Configurable]
        public float startGirlScale = 0.5f;

        [Configurable]
        public float endGirlScale = 0.8f;


        public override void Generate()
        {
            var layer = GetLayer("");

            var background = layer.CreateSprite(pixelPath, OsbOrigin.Centre);

            background.ScaleVec(startTime + 300, 854, 480);
            background.Color(startTime + 300, endTime + 500, backColor, backColor);

		    var flash = layer.CreateSprite(pixelPath, OsbOrigin.Centre);

            flash.ScaleVec(startTime, 854, 480);
            flash.Fade(OsbEasing.None, startTime, startTime + 300, 0, 0.3f);
            flash.Fade(OsbEasing.None, startTime + 300, startTime + 600, 0.3f, 0 );

            Vector2 girlStartPos = new Vector2(320, 290);
            var girl = layer.CreateSprite(girlPath, OsbOrigin.Centre, girlStartPos);

            girl.Scale(OsbEasing.OutQuint, startTime + 300, endTime, startGirlScale, endGirlScale);
            girl.Fade(startTime + 300, startTime + 600, 0.4f, 1);
            
        }
    }
}
