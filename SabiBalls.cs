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
using System.Drawing;

namespace StorybrewScripts
{
    public class SabiBalls : StoryboardObjectGenerator
    {
        [Configurable]
        public string path = "sb/Ball.png";

        [Configurable]
        public int startTime;

        [Configurable]
        public int endTime;

        public override void Generate()
        {
            fromLeft(150, 50253, 50253 + 8000, 2.6f, colorRGB(153, 255, 255));
            fromLeft(290, 51353, 51353 + 7000, 2.3f, colorRGB(153, 199, 255));
            fromLeft(270, 53653, 53653 + 8600, 2.4f, colorRGB(156, 207, 230));
            fromLeft(120, 54253, 54253 + 8500, 2.9f, colorRGB(71, 139, 255));
            fromLeft(280, 52953, 52953 + 6500, 1.7f, colorRGB(113, 226, 235));
            fromLeft(380, 57332, 57332 + 10000, 4, colorRGB(67, 145, 143));

            for (int i = 0; i < 256; i++)
            {
                float yyy = Random(50253, 89691);
                fromLeft(Random(0, 480), yyy, yyy + (float)Random(7000, 11000), (float)Random(0.1f, 1.7f), colorRGB(Random(60, 240), Random(60, 240), Random(60, 240)));
            }
            
        }

        public Color4 colorRGB(float r, float g, float b) 
        {
            return new Color4(r / 255, g / 255, b / 255, 1);
        }

        public void fromLeft(float y, float start, float end, float scale, Color4 color)
        {
            var layer = GetLayer("");
            
            var sprite = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(- 270, y));

            sprite.MoveX(start, end, - 270, 850);
            sprite.Scale(start, scale);
            sprite.Color(start, color);
            sprite.Fade(start, 0.75f);

        }
    }
}
