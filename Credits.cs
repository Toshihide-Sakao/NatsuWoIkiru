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
    public class Credits : StoryboardObjectGenerator
    {
        [Configurable]
        public string ballPath = "sb/ball.png";

        [Configurable]
        public string fontName = "Verdana";

        [Configurable]
        public float opacity = 1f;

        [Configurable]
        public int fontScale = 30;

        [Configurable]
        public float spriteScale = 1f;

        [Configurable]
        public float fadeStartDelay = 1000;

        [Configurable]
        public float fadeEndDelay = 1000;

        [Configurable]
        public FontStyle fontStyle = FontStyle.Regular;

        [Configurable]
        public bool enableColor = false;

        [Configurable]
        public Color4 textColor = Color4.IndianRed;

        [Configurable]
        public bool enableGlow = false;

        [Configurable]
        public int glowRadius = 30;

        [Configurable]
        public Color4 glowColor = Color4.White;

        [Configurable]
        public int outlineThickness = 0;

        [Configurable]
        public Color4 outlineColor = Color4.Black;

        [Configurable]
        public int shadowThickness = 0;

        [Configurable]
        public Color4 shadowColor = Color4.Black;

        private FontGenerator font;

        public override void Generate()
        {
            font = FontGenerator("sb/credits");
            var layer = GetLayer("");

            var mapsetBall = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(90, 120));
            var mappersBall = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(120, 350));
            var mappersBall2 = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(520, 300));
            var mappersBall3 = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(340, 350));
            var storyboarderBall = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(500, 100));
            var HSBall = layer.CreateSprite(ballPath, OsbOrigin.Centre, new Vector2(300, 140));


            BallCreator(mapsetBall, colorRGB(96, 156, 219), 1040, 12584, 1.5f, 1f, "Haruto", colorRGB(245, 202, 103), "Mapset", colorRGB(247, 234, 195), 0.7f);

            // BallCreator(HSBall, colorRGB(247, 119, 119), 6433, 12584, 1.1f, 0.7f, "Haruto & kudosu", colorRGB(109, 213, 227), "HS", colorRGB(231, 235, 136), 0.8f);
            // BallCreator(mappersBall, colorRGB(95, 168, 217), 3736, 12584, 1.3f, 0.9f, "Haruto", colorRGB(166, 65, 65), "Map", colorRGB(245, 135, 71), 1f);
            // BallCreator(mappersBall2, colorRGB(207, 95, 95), 4747, 12584, 1.3f, 0.9f, "Kibbleru", colorRGB(54, 201, 167), "Map", colorRGB(97, 181, 250), 1f);
            // BallCreator(storyboarderBall, colorRGB(92, 94, 214), 7781, 12584, 0.9f, 0.6f, "MRL", colorRGB(204, 175, 90), "SB", colorRGB(255, 255, 255), 0.8f);

            BallCreator(mappersBall, colorRGB(95, 168, 217), 3736, 12584, 1.1f, 0.9f, "Irohas", colorRGB(166, 65, 65), "Map", colorRGB(245, 135, 71), 0.8f);
            BallCreator(mappersBall2, colorRGB(207, 95, 95), 4747, 12584, 1.1f, 0.9f, "kudosu", colorRGB(54, 201, 167), "Map", colorRGB(97, 181, 250), 0.8f);
            BallCreator(mappersBall3, colorRGB(239, 247, 119), 6433, 12584, 1.1f, 0.9f, "Haruto", colorRGB(44, 113, 191), "Map", colorRGB(181, 111, 45), 0.8f);
            BallCreator(storyboarderBall, colorRGB(92, 94, 214), 9129, 12584, 0.9f, 0.6f, "MRL", colorRGB(204, 175, 90), "SB", colorRGB(255, 255, 255), 0.8f);
            BallCreator(HSBall, colorRGB(247, 119, 119), 7781, 12584, 1.1f, 0.7f, "Haruto & kudosu", colorRGB(109, 213, 227), "HS", colorRGB(231, 235, 136), 0.8f);

        }

        void BallCreator(OsbSprite ball, Color4 ballcolor, int startTime, int endTime, float ballScale, float textScale, string bruh, Color4 textcolor, string bruh2, Color4 insidetextcolor, float bruh2scale)
        {
            ball.Scale(startTime - 150, startTime, 0, ballScale);
            ball.Fade(startTime - 150, endTime, 1, 1);
            ball.Color(startTime - 150, ballcolor);

            var texture = font.GetTexture(bruh2);

            var GenreText = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, ball.PositionAt(startTime));
            GenreText.Fade(startTime, startTime + 100, 0, 1);
            GenreText.Color(startTime, endTime, insidetextcolor, insidetextcolor);
            GenreText.Scale(startTime, bruh2scale);

            TextCreator(startTime, endTime, ball, bruh, textcolor, textScale);
        }

        void TextCreator(int startTime, int endTime, OsbSprite ball, string bruh, Color4 textcolor, float textScale)
        {
            //testing 
            // var testball = GetLayer("").CreateSprite(ballPath, OsbOrigin.Centre);

            // testball.Fade(startTime, endTime, 1, 1);
            // testball.Scale(startTime, 0.2f);
            // testball.Color(startTime, Color4.Black);
            int timeChange = 200;
            // int t1 = startTime;

            // List<Vector2> CirclePoints = GetCirclePoints(ball, startTime);
            // for (int j = 0; j < 2; j++)
            // {
            //     for (int i = 0; i < CirclePoints.Count - 1; i++)
            //     {
            //         int t2 = t1 + timeChange;
            //         testball.Move(t1, t2, CirclePoints[i], CirclePoints[i + 1]);

            //         t1 = t2;
            //     }
            // }

            char[] textChars = bruh.ToCharArray(0, bruh.Length);

            for (int j = 0; j < textChars.Length; j++)
            {
                int t1 = startTime + j * 300;

                List<Vector2> points = GetCirclePoints(ball, startTime);

                var texture = font.GetTexture(textChars[j].ToString());
                OsbSprite sprite;
                if (texture.Path == null)
                {
                    sprite = GetLayer("").CreateSprite("sb/white.jpg", OsbOrigin.Centre, points[j]);
                }
                else
                {
                    sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, points[j]);
                }
                sprite.Scale(t1, textScale);

                for (int e = 0; e < 2; e++)
                {
                    sprite.Rotate(t1, t1 + timeChange * (points.Count - 1), MathHelper.DegreesToRadians(-90), MathHelper.DegreesToRadians(270));
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        int t2 = t1 + timeChange;
                        sprite.Move(t1, t2, points[i], points[i + 1]);
                        sprite.Color(t1, textcolor);

                        t1 = t2;
                    }
                }
            }
        }

        List<Vector2> GetCirclePoints(OsbSprite centreBall, int startTime)
        {
            var bitmap = GetMapsetBitmap(ballPath);
            float radius = (bitmap.Width * centreBall.ScaleAt(startTime).X / 2) + 10;

            List<Vector2> points = new List<Vector2>();

            double degreesOnce = 360f / 30f;
            for (int i = 0; i < 31; i++)
            {
                float x = centreBall.PositionAt(startTime).X + (radius * (float)Math.Cos(MathHelper.DegreesToRadians(degreesOnce) * i));
                float y = centreBall.PositionAt(startTime).Y + (radius * (float)Math.Sin(MathHelper.DegreesToRadians(degreesOnce) * i));

                Log(new Vector2(x, y));

                points.Add(new Vector2(x, y));
            }

            return points;
        }

        FontGenerator FontGenerator(string output)
        {
            var font = LoadFont(output, new FontDescription()
            {
                FontPath = fontName,
                FontSize = fontScale,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = fontStyle,
                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false,
            },
            new FontGlow()
            {
                Radius = !enableGlow ? 0 : glowRadius,
                Color = glowColor,
            },
            new FontOutline()
            {
                Thickness = outlineThickness,
                Color = outlineColor,
            },
            new FontShadow()
            {
                Thickness = shadowThickness,
                Color = shadowColor,
            });

            return font;
        }

        public Color4 colorRGB(float r, float g, float b)
        {
            return new Color4(r / 255, g / 255, b / 255, 1);
        }
    }
}
