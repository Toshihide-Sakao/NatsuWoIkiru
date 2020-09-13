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
    public class WithLyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public string borderPath;

        [Configurable]
        public string image1path;

        [Configurable]
        public string image2path;

        [Configurable]
        public string image3path;


        public override void Generate()
        {
		    var layer = GetLayer("");
            
            Vector2 image1pos = new Vector2(300, 240);
            var image1 = layer.CreateSprite(image1path, OsbOrigin.Centre, image1pos);
            var border = layer.CreateSprite(borderPath, OsbOrigin.Centre, image1pos);

            imageMover(11826, 13511, image1, border, image1pos, 3);
            image1.Scale(11826, 0.1f);
            border.Scale(11826, 1);
            
        }
        
        public void imageMover(float start, float end, OsbSprite image, OsbSprite border, Vector2 endPos, int fromWhere) 
        {
            switch (fromWhere)
            {
                case 0:
                    moveFromTop(image, border, start, end, endPos.Y, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    break;
                case 1:
                    moveFromRight(image, border, start, end, endPos.X, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    break;
                case 2:
                    moveFromBot(image, border, start, end, endPos.Y, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    break;
                case 3:
                    moveFromLeft(image, border, start, end, endPos.X, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    break;
            }
        }

        public void moveFromLeft(OsbSprite image, OsbSprite border, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            image.MoveX(inEasing, startTime, startTime + fadeTime, -250, startX);
            image.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX + 4);
            image.MoveX(outEasing, endTime, endTime + fadeTime, startX + 4, 900);

            border.MoveX(inEasing, startTime, startTime + fadeTime, -250, startX);
            border.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX + 4);
            border.MoveX(outEasing, endTime, endTime + fadeTime, startX + 4, 900);
        }

        public void moveFromRight(OsbSprite image, OsbSprite border, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            image.MoveX(inEasing, startTime, startTime + fadeTime, 900, startX);
            image.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX - 4);
            image.MoveX(outEasing, endTime, endTime + fadeTime, startX - 4, -250);

            border.MoveX(inEasing, startTime, startTime + fadeTime, 900, startX);
            border.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX - 4);
            border.MoveX(outEasing, endTime, endTime + fadeTime, startX - 4, -250);
        }

        public void moveFromTop(OsbSprite image, OsbSprite border, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            image.MoveY(inEasing, startTime, startTime + fadeTime, 600, Ypos);
            image.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos - 4);
            image.MoveY(outEasing, endTime, endTime + fadeTime, Ypos - 4, -100);

            border.MoveY(inEasing, startTime, startTime + fadeTime, 600, Ypos);
            border.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos - 4);
            border.MoveY(outEasing, endTime, endTime + fadeTime, Ypos - 4, -100);
        }

        public void moveFromBot(OsbSprite image, OsbSprite border, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            image.MoveY(inEasing, startTime, startTime + fadeTime, -100, Ypos);
            image.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos + 4);
            image.MoveY(outEasing, endTime, endTime + fadeTime, Ypos + 4, 600);

            border.MoveY(inEasing, startTime, startTime + fadeTime, -100, Ypos);
            border.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos + 4);
            border.MoveY(outEasing, endTime, endTime + fadeTime, Ypos + 4, 600);
        }
    }
}
