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
    public class LyricsTate : StoryboardObjectGenerator
    {
        public string fontName = "游明朝";
        public string sqPath = "sb/white.jpg";

        [Configurable]
        public float opacity = 1f;
        
        [Configurable]
        public int fontScale = 30;

        [Configurable]
        public float fadeStartDelay = 1000;

        [Configurable]
        public float fadeEndDelay = 1000;

        [Configurable]
        public float fadeBegEndDelay = 1000;

        [Configurable]
        public FontStyle fontStyle = FontStyle.Regular;
        /*

        [Configurable]
        public bool enableColor = false;

        [Configurable]
        public Color4 textColor = Color4.IndianRed;

        [Configurable]
        public bool enableBackColor = false;

        [Configurable]
        public Color4 backColor = Color4.Aqua;
        */

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

        [Configurable]
        public float amountToMove = 40;

        private FontGenerator font;

        public override void Generate()
        {
            font = FontGenerator("sb/lyrics");
            // You should write the lyrics in this function

            // The 'CreateText' function's parameters should be in this order (for reference):
            // CreateText(startTime, endTime, position, origin, text)

            /*
            CreateBegText("眩しさで", 3854, 8763,320, 160, 1.5f);
           
            CreateColoredText("君の寝言は呪文だ", 84399, 89309, 240, 250, 0.8f, Color4.White);
            CreateColoredBegText("君の寝言は呪文だ", 90218, 94218, 500, 170, 0.6f, Color4.White);

            CreateText("いつか辿り", 100763, 102581, 390, 200, 0.8f);
            */
            
            CreateBegText("勢いまかせの", 11826, 13511, 550, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("サイダー", 11826, 13511, 500, 260, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateNorBegText("ベタついたまま", 14186, 16377, 100, 350, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(47, 167, 250), true, colorRGB(0,0,0));
            CreateBegText("透明な", 17219, 20253, 550, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 255, 255), true, colorRGB(255, 154, 59));
            CreateBegText("フリをしていた", 17219, 20253, 130, 180, 0.87f, 1, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(255, 255, 255), true, colorRGB(255, 154, 59));

            //本当は
            //CreateNorBegText("本当", 21264, 25309, 130, 240, 12, 4, OsbEasing.OutCubic, OsbEasing.InCubic, false, colorRGB(47, 167, 250), true, colorRGB(171, 224, 255));

            CreateBegText("全部", 22613, 25983, 333, 150, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(255, 148, 54));
            CreateBegText("隠れているから", 22613, 25983, 307, 210, 0.87f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(47, 167, 250));

            CreateBegText("泥にまみれた", 26657, 31377, 550, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(252, 249, 197), true, colorRGB(0,0,0));
            CreateBegText("強さを探した", 26657, 31377, 500, 260, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(252, 249, 197), true, colorRGB(0,0,0));


            CreateBegText("まっすぐな視線を", 33399, 44523, 650, 100, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255), true);
            CreateBegText("こちらへ飛ばして", 36096, 44523, 580, 100, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255), true);
            CreateBegText("夏の分だけ輝いた", 38792, 44523, 100, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255), true);
            CreateBegText("君に恋した", 41995, 44523, 30, 100, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255), true);

            //

            CreateBegText("今は気が抜けた", 88680, 90702, 550, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("サイダー", 88680, 90702, 500, 260, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("どうか笑って", 91040, 93736, 333, 150, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("誰よりも", 94073, 97444, 333, 150, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("近くで見てた", 94073, 97444, 333, 150, 0.87f, 1, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));

            //本当
            CreateBegText("どこにあるのか", 99466, 103174, 333, 150, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(255, 148, 54));
            CreateBegText("と探して", 99466, 103174, 307, 210, 0.87f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(47, 167, 250));

            CreateBegText("汗にまみれた", 103511, 110084, 333, 150, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("涙を見つけた", 103511, 110084, 333, 150, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));

            //bruh
            CreateBegText("まっすぐな視線が", 110253, 120702, 650, 100, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0,0,0), true);
            CreateBegText("放物線描いて", 112950, 120702, 580, 100, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0,0,0), true);
            CreateBegText("何度も青く染まる", 115646, 120702, 100, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0,0,0), true);
            CreateBegText("君にくらくらした", 118170, 120702, 30, 100, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0,0,0), true);

/*
まっすぐな視線が, 110253, 122051
放物線描いて
何度も青く染まる
君にくらくらした
*/
            
/*
            勢いまかせの
サイダー　

ベタついたまま

透明な
フリをしていた

“本当”は全部
隠れているから

泥にまみれた
強さを探した

/tokubetsu
"まっすぐな視線を", 33399, 43848
"こちらへ飛ばして", 36096, 43848, 580, 320, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255)
"夏の分だけ輝いた", 38792, 43848, 250, 320, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255)
"君に恋した", 41995, 43848, 180, 320, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255,255,255)
/-------


//rotate and zoom out/in
夏を生きる
閉じ込めたいほど早く過ぎ去ってしまうよ
それならばもっと早く駆け抜けてしまえ

君は熱く
終わらないんだとはっきりと告げるから
君の続きが見たい　逞しくあれ


今は気が抜けた, 88680, 90702
サイダー　
"どうか笑って", 91040, 93736

誰よりも, 94073, 97444
近くで見てた

“本当”
はどこにあるのか, 99466, 103174
と探して, 99466, 103174

汗にまみれた, 103511, 110084
涙を見つけた


まっすぐな視線が, 110253, 122051
放物線描いて
何度も青く染まる
君にくらくらした


夏を生きる
見間違うほど凛とした顔していた
君を見逃せない　逞しくあれ

空は高く
どこまでだって行ける
ような
気がする
日焼けを
しながら
祈る手が
気にせず
汗をかいた
大きく
振りかぶって君を
まっすぐに捉えて
誰にも負けないエールを
背中に投げた

夏を生きる
閉じ込めたいほど早く過ぎ去ってしまうよ
それならばもっと早く駆け抜けてしまえ
夏を生きる
見間違うほど凛とした顔していた
このままじゃ遠くなる　追いつかなくちゃ
君は熱く
変わらないんだと曇りなく笑うから
君の続きが見たい
逞しくあれ*/

            // Any language is supported (as long as the fontName used supports the language)
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

        // lyrics code

        public void CreateNorBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, int fromWhatside /*0 top, 1 right, 2 bottom, 3 left*/, OsbEasing inEasing, OsbEasing outEasing
        , bool enableBackColor, Color4 backColor, bool enableColor, Color4 textColor, bool customWidth = false) 
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("text");
            var backLayer = GetLayer("textBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Xpos = startX + offset *i;

                var square = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(Xpos, startY));
                var squareBitmap = GetMapsetBitmap(sqPath);
                
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(Xpos, startY));
                var charBitmap = GetMapsetBitmap(texture.Path);

                if (fromWhatside != 4)
                {
                    sprite.Scale(startTime, 0.5f * spriteScale);
                }
                if (!customWidth) 
                {
                    square.Scale(startTime, 40 * spriteScale);
                }
                else
                {
                    square.ScaleVec(startTime, 5, 40 * spriteScale);
                    square.MoveX(startTime, startX + 40 * spriteScale );
                }
                /*
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeBegEndDelay, opacity, 0);*/
                if (enableBackColor)
                {
                    

                    switch (fromWhatside)
                    {
                        case 0:
                            moveFromTop(sprite, startTime, endTime, startY, inEasing, outEasing);
                            moveFromTop(square, startTime, endTime, startY, inEasing, outEasing);
                            
                            break;
                        case 1:
                            moveFromRight(sprite, startTime, endTime, Xpos, inEasing, outEasing);
                            moveFromRight(square, startTime, endTime, Xpos, inEasing, outEasing);
                            break;
                        case 2:
                            moveFromBot(sprite, startTime, endTime, startY, inEasing, outEasing);
                            moveFromBot(square, startTime, endTime, startY, inEasing, outEasing);
                            break;
                        case 3:
                            moveFromLeft(sprite, startTime, endTime, Xpos, inEasing, outEasing);
                            moveFromLeft(square, startTime, endTime, Xpos, inEasing, outEasing);
                            break;
                    }
                }
                else 
                {
                    switch (fromWhatside)
                    {
                        case 0:
                            moveFromTop(sprite, startTime, endTime, startY, inEasing, outEasing);
                            
                            break;
                        case 1:
                            moveFromRight(sprite, startTime, endTime, Xpos, inEasing, outEasing);
                            break;
                        case 2:
                            moveFromBot(sprite, startTime, endTime, startY, inEasing, outEasing);
                            break;
                        case 3:
                            moveFromLeft(sprite, startTime, endTime, Xpos, inEasing, outEasing);
                            break;
                        case 4:
                            sprite.Scale(inEasing, startTime, startTime + fadeStartDelay, 0, 0.5f * spriteScale);
                            sprite.Fade(outEasing, endTime, endTime + fadeEndDelay, 1, 0);
                            break;
                    }
                }

                if (enableColor)
                sprite.Color(startTime, textColor);
                
            }
        }

        public void CreateBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, int fromWhatside /*0 top, 1 right, 2 bottom, 3 left*/, OsbEasing inEasing, OsbEasing outEasing
        , bool enableBackColor, Color4 backColor, bool enableColor, Color4 textColor, bool customWidth = false )
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("text");
            var backLayer = GetLayer("textBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset *i;
                float sqXpos = startX;
                if (customWidth)
                {
                    sqXpos += 8;
                }

                var square = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var squareBitmap = GetMapsetBitmap(sqPath);
                
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);/*
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeBegEndDelay, opacity, 0);*/

                if (!customWidth) 
                {
                    square.Scale(startTime, 40 * spriteScale);
                }
                else
                {
                    square.ScaleVec(startTime, 2, 40 * spriteScale);
                    square.Fade(startTime, 0.8f);
                    square.MoveX(startTime, sqXpos);
                }

                if (enableBackColor)
                {
                    
                    square.Color(startTime, backColor);

                    switch (fromWhatside)
                    {
                        case 0:
                            moveFromTop(sprite, startTime, endTime, Ypos, inEasing, outEasing);
                            moveFromTop(square, startTime, endTime, Ypos, inEasing, outEasing);
                            
                            break;
                        case 1:
                            moveFromRight(sprite, startTime, endTime, startX, inEasing, outEasing);
                            moveFromRight(square, startTime, endTime, sqXpos, inEasing, outEasing);
                            break;
                        case 2:
                            moveFromBot(sprite, startTime, endTime, Ypos, inEasing, outEasing);
                            moveFromBot(square, startTime, endTime, Ypos, inEasing, outEasing);
                            break;
                        case 3:
                            moveFromLeft(sprite, startTime, endTime, startX, inEasing, outEasing);
                            moveFromLeft(square, startTime, endTime, sqXpos, inEasing, outEasing);
                            break;
                    }
                }
                else 
                {
                    switch (fromWhatside)
                    {
                        case 0:
                            moveFromTop(sprite, startTime, endTime, Ypos, inEasing, outEasing);
                            
                            break;
                        case 1:
                            moveFromRight(sprite, startTime, endTime, startX, inEasing, outEasing);
                            break;
                        case 2:
                            moveFromBot(sprite, startTime, endTime, Ypos, inEasing, outEasing);
                            break;
                        case 3:
                            moveFromLeft(sprite, startTime, endTime, startX, inEasing, outEasing);
                            break;
                        case 4:
                            sprite.Scale(inEasing, startTime, startTime + fadeStartDelay, 0, 0.5f * spriteScale);
                            sprite.Fade(outEasing, endTime, endTime + fadeEndDelay, 1, 0);
                            break;
                    }
                }

                if (enableColor)
                sprite.Color(startTime, textColor);
                
            }
        }

        public void moveFromLeft(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing) 
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeStartDelay, -250, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeStartDelay, endTime, startX, startX + 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeBegEndDelay, startX + 4, 900);
        }

        public void moveFromRight(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing) 
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeStartDelay, 900, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeStartDelay, endTime, startX, startX - 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeBegEndDelay, startX - 4, -250);
        }

        public void moveFromTop(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing) 
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeStartDelay, 600, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeStartDelay, endTime, Ypos, Ypos - 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeBegEndDelay, Ypos - 4, -100);
        }

        public void moveFromBot(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing) 
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeStartDelay, -100, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeStartDelay, endTime, Ypos, Ypos + 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeBegEndDelay, Ypos + 4, 600);
        }
/*
        public void CreateText(string text, int startTime, int endTime, float startX, float startY, float spriteScale)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset *i;
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
                sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
                sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeEndDelay, Ypos, Ypos + amountToMove);
                if (enableColor)
                sprite.Color(startTime, textColor);
            }
        }

        public void CreateColoredBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, Color4 color)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset *i;
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeBegEndDelay, opacity, 0);
                sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
                sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeBegEndDelay, Ypos, Ypos + amountToMove);
                if (enableColor)
                sprite.Color(startTime, color);
            }
        }

        public void CreateColoredText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, Color4 color)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset *i;
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
                sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
                sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeEndDelay, Ypos, Ypos + amountToMove);
                if (enableColor)
                sprite.Color(startTime, color);
            }
        }*/
    }
}
