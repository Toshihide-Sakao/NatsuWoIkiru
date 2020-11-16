using System.Numerics;
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
        public string flarePath = "sb/lensflare.png";

        [Configurable]
        public string backbackPath = "sb/girlback1.png";

        [Configurable]
        public float startTime = 33062;

        [Configurable]
        public float endTime = 43848;

        [Configurable]
        public Color4 backColor;

        [Configurable]
        public Color4 backColorUnder;

        [Configurable]
        public float startGirlScale = 0.5f;

        [Configurable]
        public float endGirlScale = 0.8f;


        public override void Generate()
        {
            var layer = GetLayer("");

            var backbackImage = layer.CreateSprite(backbackPath, OsbOrigin.Centre, new Vector2(280, 150));

            backbackImage.Scale(startTime + 300, endTime + 500, 0.5f, 0.5f);
            backbackImage.MoveX(startTime + 300, endTime + 500, 280, 340);
            backbackImage.Fade(startTime + 300, startTime + 600, 0.7f, 1f);

            var background = layer.CreateSprite(pixelPath, OsbOrigin.Centre);

            background.ScaleVec(startTime + 300, 854, 480);
            background.Color(startTime + 300, endTime + 500, backColor, backColor);
            background.Fade(startTime + 300, 0.6f);

            var backgroundUnder = layer.CreateSprite(pixelPath, OsbOrigin.TopCentre, new Vector2(320, 320));

            backgroundUnder.ScaleVec(startTime + 300, 854, 160);
            backgroundUnder.Color(startTime + 300, endTime + 500, backColorUnder, backColorUnder);
            backgroundUnder.Fade(startTime + 300, 1);

		    var flash = layer.CreateSprite(pixelPath, OsbOrigin.Centre);

            flash.ScaleVec(startTime, 854, 480);
            flash.Fade(OsbEasing.None, startTime, startTime + 300, 0, 0.3f);
            flash.Fade(OsbEasing.None, startTime + 300, startTime + 600, 0.3f, 0 );

            Vector2 girlStartPos = new Vector2(320, 310);
            var girl = layer.CreateSprite(girlPath, OsbOrigin.Centre, girlStartPos);

            girl.Scale(OsbEasing.OutQuint, startTime + 300, endTime, startGirlScale, endGirlScale);
            girl.Fade(startTime + 300, startTime + 600, 0.4f, 1);

            var flare = layer.CreateSprite(flarePath, OsbOrigin.TopLeft, new Vector2(- 107, 0));

            flare.Fade(startTime + 300, startTime + 500, 0, 1f);
            flare.Scale(startTime + 300, 0.4f);
            flare.Rotate(startTime + 300, endTime, MathHelper.DegreesToRadians(0), MathHelper.DegreesToRadians(10));
            
        }
    }
}
