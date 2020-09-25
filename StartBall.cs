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
using StorybrewCommon.Curves;
using StorybrewCommon;

namespace StorybrewScripts
{
    public class StartBall : StoryboardObjectGenerator
    {
        public startTime = 0;
        public endtime = 11826;
        public sqPath = "sb/white.jpg";

        public override void Generate()
        {
            List<Vector2> curvePositions = new List<Vector2>();
            curvePositions.Add(new Vector2(0, 240));
            curvePositions.Add(new Vector2(50, 280));
            curvePositions.Add(new Vector2(100, 240));
            curvePositions.Add(new Vector2(150, 200));

		    //StorybrewCommon.Curves.BezierCurve(curvePositions, 0);
            
        }
    }
}
