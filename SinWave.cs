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

            var sq = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(- 150, 240));

            float duration = (endTime - startTime) / 40;
            float lengthX = (760 + 120) /40;

            sq.Scale(startTime, 50);
            
            for (int i = 0; i < 40; i += 2)
            {
                double startY = Math.Sin(i / 10) * 10;
                double endY = Math.Sin((i + 1) / 10) * 10;
                startY += 240;

                //Log(i.ToString() + ", " + y.ToString());

                float start = startTime + (duration * i);
                float end = start + (duration * i);

                float startX = - 120 + (lengthX * i);
                float endX = startX + (lengthX * i);

                sq.Move(OsbEasing.None, start, end, startX, startY, endX, startY);
            }
            

            
        }

        public float sinYPos(float xPos) 
        {
            double y = Math.Sin((xPos / 30) * 50);

            return (float)y;
        }
    }
}
