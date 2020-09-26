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

            var sq = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(- 150, 240));

            float amount = 40;
            float duration = (endTime - startTime) / amount;
            float lengthX = (760 + 120) /amount;

            sq.Scale(startTime, 50);
            sq.Color(startTime, Color4.Black);
            sq.MoveX(startTime, endTime, - 150, 780);
            
            for (int i = 0; i < amount; i++)
            {
                double startY = Math.Sin(i / 2f) * 11;
                double endY = Math.Sin((i + 1) / 2f) * 11;
                startY += 240;
                endY += 240;

                //Log(i.ToString() + ", " + y.ToString());

                float start = startTime + (duration * i);
                float end = start + duration;
                
                sq.MoveY(start, end, startY, endY);
            }
        }
    }
}
