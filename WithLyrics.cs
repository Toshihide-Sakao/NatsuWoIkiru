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

        // [Configurable]
        // public string image1path;

        // [Configurable]
        // public string image2path;

        // [Configurable]
        // public string image3path;

        // [Configurable]
        // public float image1Scale;

        // [Configurable]
        // public Vector2 border1Scale;

        // [Configurable]
        // public float image2Scale;

        // [Configurable]
        // public Vector2 border2Scale;

        // [Configurable]
        // public float image3Scale;

        // [Configurable]
        // public Vector2 border3Scale;


        public override void Generate()
        {
		    var layer = GetLayer("");
            
            allshit(11826, 13511, "sb/Ramune.png", 250, 240, 0.4f, 1.4f, 1.7f, 3);
            allshit(14186, 16377, "sb/HatOver.png", 300, 240, 0.35f, 1.8f, 1.8f, 0);
            allshit(17219, 20253, "sb/HatRight.png", 320, 240, 0.28f, 1.9f, 1.9f, 1);
            allshit(26657, 31377, "sb/doroCut.png", 290, 240, 1.1f, 1.4f, 1.8f, 3);

        }

        public void allshit(float startTime, float endTime, string imagePath, float imageXPos, float imageYPos, float imageScale, float borderXScale, float bordeYScale, int FromWhere) 
        {
            var image = GetLayer("").CreateSprite(imagePath, OsbOrigin.Centre, new Vector2(imageXPos, imageYPos));
            var border = GetLayer("").CreateSprite(borderPath, OsbOrigin.Centre, new Vector2(imageXPos, imageYPos));

            imageMover(startTime, endTime, image, border, new Vector2(imageXPos, imageYPos), FromWhere);
            image.Scale(startTime, imageScale);
            border.ScaleVec(startTime, borderXScale, bordeYScale);
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
