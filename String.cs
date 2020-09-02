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
    public class String : StoryboardObjectGenerator
    {
        [Configurable]
        public string path = "sb/white.jpg";

        [Configurable]
        public float startTime = 0;

        [Configurable]
        public float reachHalftime;

        [Configurable]
        public float endTime;

        [Configurable]
        public float headScale = 30;

        [Configurable]
        public float headStartScale = 0.075f;

        [Configurable]
        public float tailScale = 20;

        [Configurable]
        public float tailStartScale = 0.05f;

        [Configurable]
        public Color4 headColor;

        [Configurable]
        public Color4 tailColor;

        [Configurable]
        public Vector2 startPos = new Vector2(-115, 240);

        public override void Generate()
        {
		    var layer = GetLayer("");
            var head = layer.CreateSprite(path, OsbOrigin.Centre, startPos);
        
            //head.Move(startTime, reachHalftime, startPos, new Vector2(320, 240));
            head.Color(startTime, headColor);
            head.Scale(OsbEasing.InOutQuad, startTime, startTime + 300, 0.05f, headScale);

            float anglesToUse = 360 / 3;
            float anglesEach = anglesToUse / 7;

            Vector2 origin = new Vector2(50, 240);

            List<Vector2> wigglePoints = new List<Vector2>();

            makeArc(origin, anglesEach, head, startTime, startTime + 800);
            

            float e = -(FindPos(new Vector2(0,0), 60, 0, anglesEach).X) * 2;
            Log(e.ToString());

            origin = new Vector2(origin.X + e, origin.Y);
            continuationArc(origin, anglesEach, head, startTime + 700, startTime + 1500);
        }

        public Vector2 start = new Vector2(0,0);


        public void makeArc(Vector2 origin, float anglesEach, OsbSprite head, float startArc, float endArc) 
        {
            for (int i = 0; i < 9; i++)
            {
                Vector2 endPos = FindPos(origin, 60, i, anglesEach);

                float duration = endArc - startArc;
                float moveSpeed = duration / 8;

                Log(moveSpeed.ToString());

                float startLoop = startArc + (moveSpeed*i);
                float endLoop = startLoop + moveSpeed;
                
                if (i != 0)
                {
                    head.Move(startLoop, endLoop, start, endPos);
                }
                
                start = endPos;
            }
        }

        public void continuationArc(Vector2 origin, float anglesEach, OsbSprite head, float startArc, float endArc) 
        {
            for (int i = 0; i < 9; i++)
            {
                Vector2 endPos = FindReversePos(origin, 60, i, anglesEach);

                float duration = endArc - startArc;
                float moveSpeed = duration / 8;

                Log(moveSpeed.ToString());

                float startLoop = startArc + (moveSpeed*i);
                float endLoop = startLoop + moveSpeed;
                
                if (i != 0)
                {
                    head.Move(startLoop, endLoop, start, endPos);
                }
                
                start = endPos;
            }
        }

        public Vector2 FindPos(Vector2 originPos, float radius, int point, float anglesEach) 
        {


            float angles = 180 - (anglesEach + (point * anglesEach));

            float x = radius * (float)(Math.Cos(MathHelper.DegreesToRadians(angles)));
            float y = radius * (float)(Math.Sin(MathHelper.DegreesToRadians(angles)));

            x = x + originPos.X;
            y = y + originPos.Y;

            return new Vector2(x, y);
        }

        public Vector2 FindReversePos(Vector2 originPos, float radius, int point, float anglesEach) 
        {


            float angles = 180 - (anglesEach + (point * anglesEach));

            float x = radius * (float)(Math.Cos(MathHelper.DegreesToRadians(angles)));
            float y = radius * (float)(Math.Sin(MathHelper.DegreesToRadians(angles)));

            x = x + originPos.X;
            y = originPos.Y -y;

            return new Vector2(x, y);
        }

        public Vector2 ReversePosHorizontally(Vector2 pos) 
        {
            return new Vector2(320 - (pos.X - 320) , pos.Y);
        }

        public void FindXPos(Vector2 originPos, float radius, int point, double anglesEach) 
        {
            double angleToUseDouble = anglesEach + (point * anglesEach);
            
        }
    }
}
