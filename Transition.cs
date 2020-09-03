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
    public class Transition : StoryboardObjectGenerator
    {
        [Configurable]
        public string path = "sb/white.jpg";

        [Configurable]
        public string bgPath = "EcPC_6lVcAEs80D.jpg";

        [Configurable]
        public float startTime = 0;

        [Configurable]
        public float endTime = 0;

        [Configurable]
        public float endTransTime = 0;

        [Configurable]
        public Color4 rectColor;

        public override void Generate()
        {
		    //transition(0, 170, 230, -20, - 100);

            
            
        }

        public void transition(int fromWhere, int imageWidth, int imageHeight, int heightOffset = 0, int widthOffset = 0) 
        {
            var layer = GetLayer("");

            if (fromWhere == 0)
            {
                //var Block = layer.CreateSprite(path, OsbOrigin.Centre)

                var image = layer.CreateSprite(bgPath, OsbOrigin.Centre, new Vector2(- 300, 240));
                image.MoveX(OsbEasing.OutQuart, startTime, endTransTime, - 600, 500);
                image.Scale(startTime, 0.7f);

                int rectTopBottomHeight = (480 - imageWidth) / 2;
                int rectTopHeight = rectTopBottomHeight + heightOffset;
                int rectBottomHeight = rectTopBottomHeight - heightOffset;

                int rectSideWidth = (854 - imageHeight) / 2;
                int rectLeftSideWidth = rectSideWidth + widthOffset;
                int rectRightSideWidth = rectSideWidth - widthOffset;

                var rectBottom = layer.CreateSprite(path, OsbOrigin.TopLeft, new Vector2(-107, 480 - rectBottomHeight));
                rectBottom.MoveX(OsbEasing.None, startTime, endTransTime, - 747, -107);
                rectBottom.Color(startTime, rectColor);
                rectBottom.ScaleVec(startTime, endTime, 854, rectBottomHeight, 854 , rectBottomHeight);

                var rectTop = layer.CreateSprite(path, OsbOrigin.BottomLeft, new Vector2(-107, rectTopHeight));
                rectTop.MoveX(OsbEasing.None, startTime, endTransTime, - 747, -107);
                rectTop.Color(startTime, rectColor);
                rectTop.ScaleVec(startTime, endTime, 854, rectTopHeight, 854 , rectTopHeight);

                var rectLeft = layer.CreateSprite(path, OsbOrigin.CentreLeft, new Vector2(- 300, 240));
                rectLeft.MoveX(OsbEasing.None, startTime, endTransTime, - 747, - 107);
                rectLeft.Color(startTime, rectColor);

                //rectLeft.ScaleVec(startTime, endTransTime, 800, 480, rectLeftSideWidth, 480);
                rectLeft.ScaleVec(startTime, endTime, rectLeftSideWidth, 480, rectLeftSideWidth, 480);

                var rectRight = layer.CreateSprite(path, OsbOrigin.CentreRight, new Vector2(-300, 240));
                rectRight.MoveX(OsbEasing.None, startTime, endTransTime, - 107, 747);
                rectRight.Color(startTime, rectColor);

                rectLeft.ScaleVec(startTime, endTransTime, 800, 480, rectRightSideWidth, 480);
                rectRight.ScaleVec(endTransTime, endTime, rectRightSideWidth, 480, rectRightSideWidth, 480);
                
            }
            
        }
    }
}
