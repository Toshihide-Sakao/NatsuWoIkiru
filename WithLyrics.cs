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
                    moveFromTop(image, start, end, endPos.Y, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    moveFromTop(border, start, end, endPos.Y, OsbEasing.OutQuart, OsbEasing.InQuint, 1000);
                    break;
                case 1:
                    moveFromRight(image, start, end, endPos.X, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    moveFromRight(border, start, end, endPos.X, OsbEasing.OutQuart, OsbEasing.InQuint, 1000);
                    break;
                case 2:
                    moveFromBot(image, start, end, endPos.Y, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    moveFromBot(border, start, end, endPos.Y, OsbEasing.OutQuart, OsbEasing.InQuint, 1000);
                    break;
                case 3:
                    moveFromLeft(image, start, end, endPos.X, OsbEasing.OutCubic, OsbEasing.InExpo, 1000);
                    moveFromLeft(border, start, end, endPos.X, OsbEasing.OutQuart, OsbEasing.InQuint, 1000);
                    break;
            }
        }

        public void moveFromLeft(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeTime, -400, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX + 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeTime, startX + 4, 1000);
        }

        public void moveFromRight(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeTime, 1000, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeTime, endTime, startX, startX - 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeTime, startX - 4, -400);
        }

        public void moveFromTop(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeTime, 700, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos - 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeTime, Ypos - 4, -300);
        }

        public void moveFromBot(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float fadeTime) 
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeTime, -300, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeTime, endTime, Ypos, Ypos + 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeTime, Ypos + 4, 700);
        }
    }
}
