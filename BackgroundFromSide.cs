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
    public class BackgroundFromSide : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "sb/white.jpg";

        [Configurable]
        public Color4 BackgroundColor;

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 1;

        [Configurable]
        public int fromWhere = 3;

        [Configurable]
        public float fadeStartDelay = 1000;

        [Configurable]
        public float fadeEndDelay = 10000;

        [Configurable]
        public OsbEasing inEasing = OsbEasing.OutQuart;

        [Configurable]
        public OsbEasing outEasing = OsbEasing.InExpo;

        public override void Generate()
        {

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.ScaleVec(StartTime, 1000.0f / bitmap.Width, 600.0f / bitmap.Height);
            bg.Color(StartTime, EndTime + fadeEndDelay, BackgroundColor, BackgroundColor);
            bg.Fade(StartTime, Opacity);
            
            switch (fromWhere)
            {
                case 0:
                    bg.MoveY(inEasing, StartTime, StartTime + fadeStartDelay, ( 600 / 2) + 480 , 240);
                    //bg.MoveY(outEasing, EndTime, EndTime + fadeEndDelay, 240, -( 600 / 2));
                    break;
                case 1:
                    bg.MoveX(inEasing, StartTime, StartTime + fadeStartDelay, ( 1000 / 2) + 747, 320);
                    //bg.MoveX(outEasing, EndTime, EndTime + fadeEndDelay, 320, -( 1000 / 2) - 107 );
                    break;
                case 2:
                    bg.MoveY(inEasing, StartTime, StartTime + fadeStartDelay, -( 600 / 2) , 240);
                    //bg.MoveY(outEasing, EndTime, EndTime + fadeEndDelay, 240, ( 600 / 2) + 480);
                    break;
                case 3:
                    bg.MoveX(inEasing, StartTime, StartTime + fadeStartDelay, -( 1000 / 2) - 107, 320);
                    //bg.MoveX(outEasing, EndTime, EndTime + fadeEndDelay, 320, ( 1000 / 2) + 747);
                    break;
            }
        }
    }
}
