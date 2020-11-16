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
        public string path = "sb/ball.png";

        [Configurable]
        public float startTime;

        [Configurable]
        public float endTime;

        [Configurable]
        public float scale = 20;

        [Configurable]
        public Color4 coloryes;

        [Configurable]
        public float firstY = 240;

        public override void Generate()
        {
            var layer = GetLayer("");

            var sq = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(-150, firstY));

            float amount = 40;
            float duration = (endTime - startTime) / amount;
            float lengthX = (760 + 120) / amount;

            sq.Scale(startTime, 0.1f);
            sq.Color(startTime, coloryes);
            sq.MoveX(startTime, endTime, -150, 780);

            List<OsbSprite> trails = new List<OsbSprite>();
            
            for (int i = 0; i < 100; i++)
            {
                var trail = layer.CreateSprite(path, OsbOrigin.Centre, new Vector2(-150, firstY));

                trail.Scale(startTime, 0.1f);
                trail.Color(startTime, coloryes);
                trail.MoveX(startTime + 10 * i, endTime + 10 * i, -150, 780);

                trails.Add(trail);
            }



            for (int i = 0; i < amount; i++)
            {
                double startY = Math.Sin(i / 1.7f) * 11;
                double endY = Math.Sin((i + 1) / 1.7f) * 11;
                startY += firstY;
                endY += firstY;

                //Log(i.ToString() + ", " + y.ToString());

                float start = startTime + (duration * i);
                float end = start + duration;

                sq.MoveY(start, end, startY, endY);
                for (int f = 0; f < trails.Count; f++)
                {
                    trails[f].MoveY(start + 10 * f, end + 10 * f, startY, endY);
                }
                
            }
        }

        public Color4 colorRGB(float r, float g, float b)
        {
            return new Color4(r / 255, g / 255, b / 255, 1);
        }
    }
}
