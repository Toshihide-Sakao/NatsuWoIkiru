using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;
using System.Drawing;
using OpenTK.Graphics;
using OpenTK;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        [Configurable]
        public Color4 color = Color4.White;

        [Configurable]
        public bool wiggle = false;

        public override void Generate()
        {
            if (BackgroundPath == "") BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            
            bg.Fade(StartTime - 500, StartTime, 0, Opacity);
            bg.Fade(EndTime, EndTime + 500, Opacity, 0);
            bg.Color(StartTime - 500, color);

            if (wiggle)
            {
                // bg.Scale(StartTime, 854.0f / bitmap.Width);
                bg.Scale(StartTime, 865.0f / bitmap.Width);
                WiggleScreen(bg, StartTime, EndTime, 4f);
            }
            else
            {
                bg.ScaleVec(StartTime, 854.0f / bitmap.Width, 480.0f / bitmap.Height);
            }

        }

        private void WiggleScreen(OsbSprite sprite, int startTime, int endTime, float beats, int offsetX = 5, int offsetY = 5, int originalXCord = 320, int originalYCord = 240, float originalRot = 0.0f, bool goBack = false)
        {
            var previousCord = new Vector2(originalXCord, originalYCord); // Initial position of the sprite, you can make this variable global if u want

            double previousRotation = originalRot;

            double beatDuration = Beatmap.GetTimingPointAt((int)startTime).BeatDuration;
            double rate = (endTime - startTime) / (beatDuration * beats);
            var loopTime = (endTime - startTime) / rate;

            for (int i = 0; i < rate; i++)
            { // for moving the sprite
                if (goBack && i >= (rate - 1))
                {
                    sprite.Move(OsbEasing.InOutSine, startTime + (loopTime * i), startTime + (loopTime * (i + 1)), previousCord, new Vector2(Random(313, 330), Random(233, 250)));
                }
                else
                {
                    var xCord = Random(originalXCord - offsetX, originalXCord + offsetX);
                    var yCord = Random(originalYCord - offsetY, originalYCord + offsetY);

                    var tempCord = new Vector2(xCord, yCord);

                    sprite.Move(OsbEasing.InOutSine, startTime + (loopTime * i), startTime + (loopTime * (i + 1)), previousCord, tempCord);
                    //Log($"{startTime+(loopTime*i)} until {startTime+(loopTime*(i+1))}");

                    previousCord = tempCord;
                }

            }

            for (int i = 0; i < rate / 2; i++)
            { //for rotating the sprite
                double[] rotate = new double[]{
                    0.01, 0.02, -0.01, -0.02
                };

                var rotInd = Random(0, rotate.Length);
                var tempRot = rotate[rotInd];

                sprite.Rotate(OsbEasing.InOutSine, startTime + ((2 * loopTime) * i), startTime + ((2 * loopTime) * (i + 1)), previousRotation, tempRot);

                previousRotation = tempRot;
            }
        }
    }
}
