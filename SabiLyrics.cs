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
    public class SabiLyrics : StoryboardObjectGenerator
    {
        public string fontName = "游明朝";
        public string sqPath = "sb/white.jpg";
        public int fontScale = 30;
        public FontStyle fontStyle = FontStyle.Regular;
        public Color4 fontColor = Color.Black;
        public int outlineThickness = 0;
        public Color4 outlineColor = Color.Black;
        private FontGenerator font;


        public override void Generate()
        {
		    font = fontGenerator("sb/lyrics");
            
        }

        public void CreateBigText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, Color4 fontColor)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("text");
            var backLayer = GetLayer("textBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Xpos = startX + offset *i;

                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(Xpos, startY));
            }
        }

        public Color4 colorRGB(float r, float g, float b) 
        {
            return new Color4(r / 255, g / 255, b / 255, 1);
        }

        FontGenerator fontGenerator(string output)
        {
            var font = LoadFont(output, new FontDescription()
            {
                FontPath = fontName,
                FontSize = fontScale,
                Color = fontColor,
                Padding = Vector2.Zero,
                FontStyle = fontStyle,

                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false,
            },
            new FontOutline()
            {
                Thickness = outlineThickness,
                Color = outlineColor,
            });

            return font;
        }
    }
}
