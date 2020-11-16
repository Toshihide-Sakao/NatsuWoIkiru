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
        private FontGenerator bigFont;
        private FontGenerator handfont;

        public override void Generate()
        {
            font = FontGenerator("sb/lyrics");
            bigFont = BigFontGenerator("sb/biglyrics");
            handfont = handFontGenerator("sb/handfont");
            // You should write the lyrics in this function

            // The 'CreateText' function's parameters should be in this order (for reference):
            // CreateText(startTime, endTime, position, origin, text)

            /*
            CreateBegText("眩しさで", 3854, 8763,320, 160, 1.5f);
           
            CreateColoredText("君の寝言は呪文だ", 84399, 89309, 240, 250, 0.8f, Color4.White);
            CreateColoredBegText("君の寝言は呪文だ", 90218, 94218, 500, 170, 0.6f, Color4.White);

            CreateText("いつか辿り", 100763, 102581, 390, 200, 0.8f);
            */

            CreateBegText("勢いまかせの", 11826, 13511, 620, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("サイダー", 11826, 13511, 570, 260, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateNorBegText("ベタついたまま", 14186, 16377, 100, 400, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(255, 255, 255), true, colorRGB(0, 0, 0));
            CreateBegText("透明な", 17219, 20253, 550, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 255, 255), true, colorRGB(255, 154, 59));
            CreateBegText("フリをしていた", 17219, 20253, 90, 180, 0.87f, 1, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(255, 255, 255), true, colorRGB(255, 154, 59));

            //本当は
            //CreateNorBegText("本当", 21264, 25309, 130, 240, 12, 4, OsbEasing.OutCubic, OsbEasing.InCubic, false, colorRGB(47, 167, 250), true, colorRGB(171, 224, 255));

            CreateBegText("全部", 22613, 25983, 333, 150, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(255, 148, 54));
            CreateBegText("隠れているから", 22613, 25983, 307, 210, 0.87f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(47, 167, 250));

            CreateBegText("泥にまみれた", 26657, 31377, 580, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(252, 249, 197), true, colorRGB(0, 0, 0));
            CreateBegText("強さを探した", 26657, 31377, 530, 260, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(252, 249, 197), true, colorRGB(0, 0, 0));


            CreateBegText("まっすぐな視線を", 33399, 44523, 650, 100, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255, 255, 255), true);
            CreateBegText("こちらへ飛ばして", 36096, 44523, 580, 100, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255, 255, 255), true);
            CreateBegText("夏の分だけ輝いた", 38792, 44523, 100, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255, 255, 255), true);
            CreateBegText("君に恋した", 41995, 44523, 30, 100, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(255, 255, 255), true);

            // 夏を生きる
            // 閉じ込めたいほど早く過ぎ去ってしまうよ

            CreateNatsuText("夏を生きる", 45534, 46714, 47219, 48062, 48568, 48905, 49242, 49579, 50084, 320, 240, 3);
            CreateNorBegText("閉じ込めたいほど", 50253, 51938, 250, 200, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("閉じ込めたいほど", 50253, 51938, 250, 240, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("閉じ込めたいほど", 50253, 51938, 250, 280, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));

            CreateBigThroughText("早く", 52950, 53371, 150, 220, 1.5f, colorRGB(255, 255, 255), 200);
            CreateNorBegText("過ぎ去ってしまうよ", 53118, 55646, 250, 240, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));
            //CreateBigThroughText("", 54635, 55983, 150, 220, 1.5f, colorRGB(255, 255, 255), 100); //rotate

            // それならば no back sorescale 1.3, narabascale 1 (sore apear first then naraba) from right (position upper left)
            // もっと no back motto
            // 早く same as before
            // 駆け抜けてしまえ no back

            CreateOverBegText("それ", 56320, 59277, 380, 150, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateOverBegText("ならば", 57669, 59277, 320, 200, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateOverBegText("もっと", 58680, 59277, 260, 250, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0), true);

            CreateBigThroughText("早く", 59691, 60134, 150, 220, 1.5f, colorRGB(255, 255, 255), 200);

            CreateBegText("駆け抜けてしまえ", 61040, 65253, 320, 150, 0.9f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(68, 129, 235), true, colorRGB(255, 255, 255));

            // 君は熱く same as nastu
            CreateNatsuText("君は熱く", 67107, 68287, 68792, 69466, 70141, 70478, 70815, 71320, 71657, 320, 240, 2);
            CreateNorBegText("終わらないんだと", 71826, 73511, 250, 200, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("終わらないんだと", 71826, 73511, 250, 240, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("終わらないんだと", 71826, 73511, 250, 280, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            // 終わらないんだと same as toji but tate
            // はっきりと one after one on center
            // 告げるから normal
            CreateBegText("はっきりと", 74523, 77219, 350, 160, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));
            CreateBegText("告げるから", 75871, 77219, 300, 220, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));

            // 君の続き 四角でぜんぶ
            // が見たい　
            // 逞しくあれ one after one
            var shikaku1 = GetLayer("shikaku1");
            CreateShikakuText("君の続き", "が見たい", "逞しくあれ", 77893, 88680, 0.17f, 0.2f, colorRGB(52, 183, 235), shikaku1);

            //

            CreateBegText("今は気が抜けた", 88680, 90365, 550, 180, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateBegText("サイダー", 88680, 90365, 500, 240, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), false, colorRGB(179, 224, 255));
            CreateNorBegText("どうか笑って", 91040, 93399, 100, 350, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(66, 128, 199), false, colorRGB(0,0,0));
            CreateBegText("誰よりも", 94073, 97107, 550, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(105, 218, 224), false, colorRGB(179, 224, 255));
            CreateBegText("近くで見てた", 94073, 97107, 130, 180, 0.87f, 1, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(105, 218, 224), false, colorRGB(179, 224, 255));

            //本当
            CreateBegText("どこにあるのか", 99466, 102837, 333, 150, 0.87f, 0, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(255, 148, 54));
            CreateBegText("と探して", 99466, 102837, 307, 210, 0.87f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, false, colorRGB(47, 167, 250), true, colorRGB(47, 167, 250));

            CreateBegText("汗にまみれた", 103511, 108230, 550, 120, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(242, 168, 90), true, colorRGB(0,0,0));
            CreateBegText("涙を見つけた", 103511, 108230, 500, 200, 0.87f, 3, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(242, 168, 90), true, colorRGB(0,0,0));

            //bruh
            CreateBegText("まっすぐな視線が", 110253, 120702, 650, 100, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("放物線描いて", 112950, 120702, 580, 100, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("何度も青く染まる", 115646, 120702, 100, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("君にくらくらした", 118170, 120702, 30, 100, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);

            // 夏を生きる
            // 見間違うほど
            // 凛とした顔していた


            CreateNatsuText("夏を生きる", 122388, 123568, 124073, 124747, 125422, 125759, 126096, 126601, 127107, 320, 240, 3);
            CreateNorBegText("見間違うほど", 127107, 128792, 250, 200, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("見間違うほど", 127107, 128792, 250, 240, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("見間違うほど", 127107, 128792, 250, 280, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));

            CreateNorBegText("凛とした顔していた", 129804, 132163, 130, 240, 1.6f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, false, colorRGB(0, 0, 0), true, colorRGB(245, 182, 105));

            // 君を
            // 見逃せない
            // 逞しくあれ
            var shikaku2 = GetLayer("shikaku2");
            CreateShikakuText("君を", "見逃せない", "逞しくあれ", 133174, 141348, 0.14f, 0.16f, colorRGB(52, 183, 235), shikaku2);


            // GekouYoushi
            // x(34) 700, 666, 632, 598, 564, 530, 496, 462, 428, 394
            // y(24)

            CreateGenkouText("空は高く", 151882, 173624, 702, 24, 1f);
            CreateGenkouText("どこまでだって行けるような", 154579, 173624, 668, 24, 1f);
            CreateGenkouText("気がする", 159298, 173624, 600, 24, 1f);
            CreateGenkouText("日焼けをしながら", 162669, 173624, 531, 24, 1f);
            CreateGenkouText("祈る手が", 165365, 173624, 496, 24, 1f);
            CreateGenkouText("気にせず汗をかいた", 168062, 173624, 427, 24, 1f);
            // 空は高く
            // "どこまでだって行けるような", 154579
            // 
            // "気がする", 159298
            // "日焼けをしながら", 162669
            // "祈る手が", 165365
            // "気にせず汗をかいた", 168062

            CreateOOkikuuu("大きく", new int[] { 172275, 172950, 173287 }, 173624, new float[] { 340, 500, 620 }, new float[] { 300, 270, 250 }, 1.4f, new float[] { -20, -18, -13 });
            //ookiku yaru
            // "大きく", 172275

            //itumono girl
            CreateBegText("振りかぶって君を", 173624, 184747, 650, 100, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("まっすぐに捉えて", 176320, 184747, 580, 100, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("誰にも負けないエールを", 179017, 184747, 100, 100, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);
            CreateBegText("背中に投げた", 182388, 184747, 30, 100, 0.87f, 0, OsbEasing.OutExpo, OsbEasing.InQuart, true, colorRGB(255, 131, 117), true, colorRGB(0, 0, 0), true);

            // 振りかぶって君を
            // まっすぐに捉えて
            // 誰にも負けないエールを
            // 背中に投げた

            // CreateNatsuText("夏を生きる", 122388, 123568, 124073, 124747, 125422, 125759, 126096, 126601, 127107, 320, 240, 3);
            CreateNatsuText("夏を生きる", 185759, 186770, 187444, 188118, 188792, 189129, 189466, 189972, 190478, 320, 240, 3);
            // 夏を生きる

            CreateNorBegText("閉じ込めたいほど", 190478, 192332, 250, 200, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("閉じ込めたいほど", 190478, 192332, 250, 240, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("閉じ込めたいほど", 190478, 192332, 250, 280, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            // "閉じ込めたいほど"

            CreateBigThroughText("早く", 193174, 193597, 150, 220, 1.5f, colorRGB(255, 255, 255), 200);
            CreateNorBegText("過ぎ去ってしまうよ", 193427, 196208, 250, 240, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));
            // "早く"
            // "過ぎ去ってしまうよ"

            // CreateOverBegText("それ", 196545, 200253, 380, 150, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0,0,0));
            // CreateOverBegText("ならば", 197893, 200253, 320, 200, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0,0,0));
            // CreateOverBegText("もっと", 198905, 200253, 260, 250, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0,0,0));
            CreateOverBegText("それ", 196545, 199832, 380, 150, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateOverBegText("ならば", 197893, 199832, 320, 200, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateOverBegText("もっと", 198905, 199832, 260, 250, 1.1f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0), true);
            
            // "それならばもっと"

            CreateBigThroughText("早く", 200084, 200590, 150, 220, 1.5f, colorRGB(255, 255, 255), 200);
            // "早く"

            CreateBegText("駆け抜けてしまえ", 201264, 205646, 320, 150, 0.9f, 2, OsbEasing.OutQuart, OsbEasing.InExpo, true, colorRGB(68, 129, 235), true, colorRGB(255, 255, 255));

            // "駆け抜けてしまえ"

            CreateNatsuText("夏を生きる", 207332, 208343, 209017, 209691, 210365, 210702, 211039, 211545, 211882, 320, 240, 3);
            CreateNorBegText("見間違うほど", 212051, 213736, 250, 200, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("見間違うほど", 212051, 213736, 250, 240, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("見間違うほど", 212051, 213736, 250, 280, 0.87f, 1, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));

            CreateNorBegText("凛とした顔していた", 214747, 217275, 130, 240, 1.6f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, false, colorRGB(0, 0, 0), true, colorRGB(245, 182, 105));
            // "夏を生きる"
            // "見間違うほど"
            // "凛  とした顔していた"

            CreateBegText("このままじゃ", 218118, 227725, 380, 170, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateBegText("遠くなる", 220478, 227725, 320, 190, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateBegText("追いつかなくちゃ", 222837, 227725, 260, 150, 0.87f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            // このままじゃ
            // 遠くなる, 220478
            // 追いつかなくちゃ, 222837

            CreateNatsuText("君は熱く", 228905, 230084, 230590, 231264, 231938, 232275, 232613, 233287, 233624, 320, 240, 2);
            CreateNorBegText("変わらないんだと", 233624, 235141, 250, 200, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("変わらないんだと", 233624, 235141, 250, 240, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            CreateNorBegText("変わらないんだと", 233624, 235141, 250, 280, 0.87f, 3, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(255, 191, 82), true, colorRGB(0, 0, 0));
            // 君は熱く
            // 変わらないんだと

            CreateBegText("曇りなく", 236320, 238848, 350, 160, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));
            CreateBegText("笑うから", 237669, 238848, 300, 220, 0.9f, 2, OsbEasing.OutExpo, OsbEasing.InExpo, true, colorRGB(179, 53, 48), true, colorRGB(255, 255, 255));
            // 曇りなく
            // 笑うから 

            var shikaku3 = GetLayer("shikaku3");
            CreateShikakuText("君の", "続きが見たい", "逞しくあれ", 239691, 249804, 0.14f, 0.16f, colorRGB(52, 183, 235), shikaku3);
            // 君の
            // 続きが見たい
            // 逞しくあれ

            CreateText(249804, 258402, new Vector2(320, 240), OsbOrigin.Centre, "逞しきあれ");
            // 逞しくあれ

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

        FontGenerator BigFontGenerator(string output)
        {
            var bigFont = LoadFont(output, new FontDescription()
            {
                FontPath = fontName,
                FontSize = 150,
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

            return bigFont;
        }

        FontGenerator handFontGenerator(string output)
        {
            var handfont = LoadFont(output, new FontDescription()
            {
                FontPath = "モギハ・ペン字Font",
                FontSize = 150,
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

            return handfont;
        }

        public Color4 colorRGB(float r, float g, float b)
        {
            return new Color4(r / 255, g / 255, b / 255, 1);
        }

        // lyrics code

        public void CreateNatsuText(string text, int startTime, int nastuEndTime, int nextTime, int uStart, int uuStart, int uuEnd, int uuuuStart, int uuuuEnd, int endTime, float startX, float startY, int MojiSuu)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var nastuLayer = GetLayer("natsu");
            var backNatsuLayer = GetLayer("backNatsu");


            var texture = bigFont.GetTexture(textChars[0].ToString());
            var natsu = nastuLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, 550));
            var nastuBack = backNatsuLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(startX, 650));



            natsu.MoveY(OsbEasing.OutQuint, startTime, nastuEndTime, 550, startY);
            natsu.Scale(startTime, 1);
            nastuBack.MoveY(OsbEasing.OutQuint, startTime, nastuEndTime, 700, startY);
            nastuBack.ScaleVec(OsbEasing.OutExpo, startTime, nastuEndTime, 300, 300, 400, 400);
            nastuBack.Color(startTime, colorRGB(39, 127, 242));
            nastuBack.Rotate(startTime, MathHelper.DegreesToRadians(45));
            nastuBack.Fade(startTime, 0.5f);

            natsu.MoveX(OsbEasing.InOutBack, nastuEndTime, nextTime, startX, startX - 200);
            natsu.Scale(OsbEasing.OutExpo, nastuEndTime, nextTime, 1, 0.5f);
            natsu.Fade(startTime, endTime, 1, 1);
            natsu.MoveY(OsbEasing.InExpo, uuStart, endTime, startY, -200);

            nastuBack.Color(nastuEndTime, endTime, colorRGB(247, 185, 52), colorRGB(247, 185, 52));
            nastuBack.ScaleVec(OsbEasing.InOutQuart, nastuEndTime, nextTime, 400, 400, 854, 480);
            nastuBack.Rotate(OsbEasing.OutBack, nastuEndTime, nextTime, MathHelper.DegreesToRadians(45), MathHelper.DegreesToRadians(0));

            texture = bigFont.GetTexture(textChars[1].ToString());
            var wo = nastuLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX - 110, -100));

            wo.Color(nastuEndTime, colorRGB(39, 127, 242));
            wo.MoveY(OsbEasing.InOutBack, nastuEndTime, nextTime, -100, startY);
            wo.Scale(nastuEndTime, endTime, 0.35f, 0.35f);
            wo.MoveY(OsbEasing.InExpo, uuStart, endTime, startY, -200);

            Vector2 ikriruPos = new Vector2(260, startY - 5);

            for (int i = 2; i < textChars.Length; i++)
            {
                texture = bigFont.GetTexture(textChars[i].ToString());

                var bitmap = GetMapsetBitmap(texture.Path);

                if (MojiSuu == 2)
                {
                    var sprite = nastuLayer.CreateSprite(texture.Path, OsbOrigin.CentreLeft, new Vector2(ikriruPos.X + 100, ikriruPos.Y));
                    var spriteCentre = nastuLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(ikriruPos.X + (bitmap.Width * 0.6f) / 2, ikriruPos.Y));

                    float offset = 0;

                    switch (i)
                    {
                        case 2:
                            offset = 180;
                            break;
                        case 3:
                            offset = 150;
                            break;

                    }
                    float Xpos = 290 + offset * (i - 2);

                    sprite.ScaleVec(OsbEasing.OutExpo, nextTime, uStart, 0, 0.6f, 0.6f, 0.6f);
                    sprite.MoveX(OsbEasing.OutBack, nextTime, uStart, 260, Xpos);
                    sprite.Fade(nextTime, uuStart, 1, 1);


                    spriteCentre.Fade(uuStart, endTime, 1, 1);
                    spriteCentre.MoveX(uuStart, Xpos + (bitmap.Width * 0.6f) / 2);
                    spriteCentre.ScaleVec(OsbEasing.OutCubic, uuStart, uuEnd, 0.6f, 0.6f, 0.65f, 0.65f);
                    spriteCentre.ScaleVec(OsbEasing.OutCubic, uuuuStart, uuuuEnd, 0.65f, 0.65f, 0.7f, 0.7f);
                    spriteCentre.MoveY(OsbEasing.InExpo, uuStart, endTime, startY, -200);
                }
                else if (MojiSuu == 3)
                {
                    var sprite = nastuLayer.CreateSprite(texture.Path, OsbOrigin.CentreLeft, ikriruPos);
                    var spriteCentre = nastuLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(ikriruPos.X + (bitmap.Width * 0.6f) / 2, ikriruPos.Y));
                    float offset = 0;

                    switch (i)
                    {
                        case 2:
                            offset = 120;
                            break;
                        case 3:
                            offset = 120;
                            break;
                        case 4:
                            offset = 105;
                            break;

                    }
                    float Xpos = 260 + offset * (i - 2);

                    sprite.ScaleVec(OsbEasing.OutExpo, nextTime, uStart, 0, 0.6f, 0.6f, 0.6f);
                    sprite.MoveX(OsbEasing.OutBack, nextTime, uStart, 260, Xpos);
                    sprite.Fade(nextTime, uuStart, 1, 1);

                    spriteCentre.Fade(uuStart, endTime, 1, 1);
                    spriteCentre.MoveX(uuStart, Xpos + (bitmap.Width * 0.6f) / 2);
                    spriteCentre.ScaleVec(OsbEasing.OutCubic, uuStart, uuEnd, 0.6f, 0.6f, 0.65f, 0.65f);
                    spriteCentre.ScaleVec(OsbEasing.OutCubic, uuuuStart, uuuuEnd, 0.65f, 0.65f, 0.7f, 0.7f);
                    spriteCentre.MoveY(OsbEasing.InExpo, uuStart, endTime, startY, -200);
                }
            }

            var ikiBack1 = backNatsuLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(ikriruPos.X + 140, ikriruPos.Y));
            var ikiBack2 = backNatsuLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(ikriruPos.X + 140, ikriruPos.Y));

            ikiBack1.ScaleVec(OsbEasing.OutQuint, uuStart, uuEnd, 300, 0, 300, 480);
            ikiBack1.Color(uuStart, colorRGB(176, 81, 245));
            ikiBack1.Fade(uuStart, endTime, 0.5f, 0.5f);
            ikiBack1.ScaleVec(OsbEasing.OutQuint, uuuuStart, uuuuEnd, 300, 480, 1100, 480);
            ikiBack1.Fade(endTime, endTime + 1500, 0.5f, 0);

            ikiBack2.ScaleVec(OsbEasing.OutQuint, uuuuStart, uuuuEnd, 300, 0, 300, 480);
            ikiBack2.Color(uuuuStart, colorRGB(77, 255, 255));
            ikiBack2.Fade(uuuuStart, endTime, 0.5f, 0.5f);
            ikiBack2.Fade(endTime, endTime + 450, 0.5f, 0);

        }

        public void CreateShikakuText(string text1, string text2, string text3, int startTime, int endTime, float startScale, float endScale, Color4 fontColor, StoryboardLayer layer)
        {
            char[] text1Chars = text1.ToCharArray(0, text1.Length);
            char[] text2Chars = text2.ToCharArray(0, text2.Length);
            char[] text3Chars = text3.ToCharArray(0, text3.Length);

            //var layer = GetLayer("ShikakuText");

            for (int i = 0; i < text1Chars.Length; i++)
            {
                float offset = 270 * startScale;

                float Ypos = 170 + offset * i;

                var texture = bigFont.GetTexture(text1Chars[i].ToString());
                var sprite = layer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(420, Ypos));

                sprite.Fade(OsbEasing.OutQuint, startTime, startTime + 1800, 0, 1f);
                sprite.Color(startTime, endTime, fontColor, fontColor);
                sprite.Scale(startTime, startTime + 3000, startScale, endScale);
            }
            for (int i = 0; i < text2Chars.Length; i++)
            {
                float offset = 270 * startScale;

                float Ypos = 170 + offset * i;

                var texture = bigFont.GetTexture(text2Chars[i].ToString());
                var sprite = layer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(320, Ypos));

                sprite.Fade(OsbEasing.OutQuint, startTime, startTime + 1800, 0, 1f);
                sprite.Color(startTime, endTime, fontColor, fontColor);
                sprite.Scale(startTime, startTime + 3000, startScale, endScale);
            }
            for (int i = 0; i < text3Chars.Length; i++)
            {
                float offset = 270 * startScale;

                float Ypos = 170 + offset * i;

                var texture = bigFont.GetTexture(text3Chars[i].ToString());
                var sprite = layer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(220, Ypos));

                sprite.Fade(OsbEasing.OutQuint, startTime, startTime + 1800, 0, 1f);
                sprite.Color(startTime, endTime, fontColor, fontColor);
                sprite.Scale(startTime, startTime + 3000, startScale, endScale);
            }

            var sq1 = layer.CreateSprite(sqPath, OsbOrigin.TopCentre, new Vector2(520, 0));
            var sq2 = layer.CreateSprite(sqPath, OsbOrigin.BottomCentre, new Vector2(120, 480));

            sq1.ScaleVec(OsbEasing.OutExpo, startTime, endTime - 1000, 40, 0, 40, 400);
            sq2.ScaleVec(OsbEasing.OutExpo, startTime, endTime - 1000, 40, 0, 40, 400);
            sq1.Color(startTime, colorRGB(214, 57, 36));
            sq2.Color(startTime, colorRGB(214, 57, 36));
            sq1.Fade(startTime, 0.8f);
            sq2.Fade(startTime, 0.8f);

            var background = layer.CreateSprite(sqPath, OsbOrigin.Centre);
            background.ScaleVec(startTime, endTime, 854, 480, 854, 480);
            background.Fade(OsbEasing.InOutQuart, startTime, endTime + 1000, 0, 1f);


        }

        public void CreateBigThroughText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, Color4 fontColor, float between)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var HayakuTextLayer = GetLayer("HayakuOverText");
            float duration = endTime - startTime;

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = between * spriteScale;

                float Xpos = startX + offset * i;

                var texture = bigFont.GetTexture(textChars[i].ToString());
                var sprite = HayakuTextLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(Xpos, startY + Random(-20, 20)));

                sprite.Color(startTime + (offset * i / 2), fontColor);
                sprite.Scale(startTime + (offset * i / 2), endTime, spriteScale, spriteScale);
                sprite.MoveX(OsbEasing.OutSine, startTime + (offset * i / 10), startTime + (duration / 2), -300 + (offset * i), Xpos);
                sprite.MoveX(OsbEasing.InSine, startTime + (duration / 2), endTime, Xpos, 800);
            }
        }

        public void CreateNorBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, int fromWhatside /*0 top, 1 right, 2 bottom, 3 left*/, OsbEasing inEasing, OsbEasing outEasing
        , bool enableBackColor, Color4 backColor, bool enableColor, Color4 textColor, bool customWidth = false)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("text");
            var backLayer = GetLayer("textBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;
                float Xpos = startX + offset * i;

                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(Xpos, startY));

                sprite.Scale(startTime, 0.5f * spriteScale);
                FromWhereSwitchNor(fromWhatside, sprite, startTime, endTime, Xpos, startY, inEasing, outEasing, offset, i);

                if (enableColor)
                    sprite.Color(startTime, textColor);

                if (enableBackColor)
                {

                    float sqHeight = 40 * spriteScale;
                    float spriteWidth = 30 * spriteScale;
                    //float overlap = sqHeight - rangeBetweenSqs;
                    //float sqWidth = sqHeight * (textChars.Length) - overlap * (textChars.Length -2);

                    var square = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(Xpos, startY));

                    if (!customWidth)
                    {
                        square.ScaleVec(startTime, spriteWidth, sqHeight);
                    }
                    else
                    {
                        square.ScaleVec(startTime, spriteWidth, 5);
                        square.MoveX(startTime, startX + 40 * spriteScale);
                    }

                    square.Color(startTime, backColor);

                    FromWhereSwitchNor(fromWhatside, square, startTime, endTime, Xpos, startY, inEasing, outEasing, offset, i);

                    if (i == 0)
                    {
                        var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(Xpos - (spriteWidth * 0.75f), startY));
                        sqLeftOver.Color(startTime, backColor);
                        sqLeftOver.ScaleVec(startTime, spriteWidth / 2, sqHeight);
                        FromWhereSwitchNor(fromWhatside, sqLeftOver, startTime, endTime, Xpos - (spriteWidth * 0.75f), startY, inEasing, outEasing, offset, i);
                    }
                    else if (i == textChars.Length - 1)
                    {
                        var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(Xpos + (spriteWidth * 0.75f), startY));
                        sqLeftOver.Color(startTime, backColor);
                        sqLeftOver.ScaleVec(startTime, spriteWidth / 2, sqHeight);
                        FromWhereSwitchNor(fromWhatside, sqLeftOver, startTime, endTime, Xpos + (spriteWidth * 0.75f), startY, inEasing, outEasing, offset, i);
                    }
                }
            }
        }

        public void CreateOverBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, int fromWhatside /*0 top, 1 right, 2 bottom, 3 left*/, OsbEasing inEasing, OsbEasing outEasing
        , bool enableBackColor, Color4 backColor, bool enableColor, Color4 textColor, bool bruhdiefast = false, bool customWidth = false, bool customLayer = false)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("overText");
            var backLayer = GetLayer("overTextBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset * i;
                float sqXpos = startX;
                if (customWidth)
                    sqXpos += 8;

                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                if (bruhdiefast)
                {
                    FromWhereSwitchTateDieFast(fromWhatside, sprite, startTime, endTime, startX, Ypos, inEasing, outEasing, offset, i);
                }
                else
                {
                    FromWhereSwitchTate(fromWhatside, sprite, startTime, endTime, startX, Ypos, inEasing, outEasing, offset, i);
                }

                fixWrongChars(textChars[i].ToString(), sprite, startTime);

                if (enableColor)
                    sprite.Color(startTime, textColor);
                /*
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeBegEndDelay, opacity, 0);*/

                if (enableBackColor)
                {
                    float sqWidth = 40 * spriteScale;
                    float spriteHeight = 30 * spriteScale;
                    var square = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos));

                    square.Color(startTime, backColor);
                    if (bruhdiefast)
                    {
                        FromWhereSwitchTateDieFast(fromWhatside, square, startTime, endTime, sqXpos, Ypos, inEasing, outEasing, offset, i);
                    }
                    else
                    {
                        FromWhereSwitchTate(fromWhatside, square, startTime, endTime, sqXpos, Ypos, inEasing, outEasing, offset, i);
                    }

                    float customWidthFloat = 2;

                    if (!customWidth)
                    {
                        square.ScaleVec(startTime, sqWidth, spriteHeight);

                        if (i == 0)
                        {
                            var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos - (spriteHeight * 0.75f)));
                            sqLeftOver.Color(startTime, backColor);
                            if (bruhdiefast)
                            {
                                FromWhereSwitchTateDieFast(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos - (spriteHeight * 0.75f), inEasing, outEasing, offset, i);
                            }
                            else
                            {
                                FromWhereSwitchTate(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos - (spriteHeight * 0.75f), inEasing, outEasing, offset, i);
                            }

                            if (!customWidth)
                                sqLeftOver.ScaleVec(startTime, sqWidth, spriteHeight / 2);
                            else
                                sqLeftOver.ScaleVec(startTime, customWidthFloat, spriteHeight / 2);
                            sqLeftOver.MoveX(startTime, sqXpos);
                        }
                        else if (i == textChars.Length - 1)
                        {
                            var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos + (spriteHeight * 0.75f)));
                            sqLeftOver.Color(startTime, backColor);
                            
                            if (bruhdiefast)
                            {
                                FromWhereSwitchTateDieFast(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos + (spriteHeight * 0.75f), inEasing, outEasing, offset, i);
                            }
                            else
                            {
                                FromWhereSwitchTate(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos + (spriteHeight * 0.75f), inEasing, outEasing, offset, i);
                            }

                            if (!customWidth)
                                sqLeftOver.ScaleVec(startTime, sqWidth, spriteHeight / 2);
                            else
                                sqLeftOver.ScaleVec(startTime, customWidthFloat, spriteHeight / 2);
                            sqLeftOver.MoveX(startTime, sqXpos);
                        }
                    }
                    else
                    {
                        square.ScaleVec(startTime, customWidthFloat, spriteHeight);
                        square.Fade(startTime, 0.8f);
                        square.MoveX(startTime, sqXpos);
                    }
                }
            }
        }


        public void CreateBegText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, int fromWhatside /*0 top, 1 right, 2 bottom, 3 left*/, OsbEasing inEasing, OsbEasing outEasing
        , bool enableBackColor, Color4 backColor, bool enableColor, Color4 textColor, bool customWidth = false)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            var textLayer = GetLayer("text");
            var backLayer = GetLayer("textBack");

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 30 * spriteScale;

                float Ypos = startY + offset * i;
                float sqXpos = startX;
                if (customWidth)
                    sqXpos += 8;

                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = backLayer.CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                FromWhereSwitchTate(fromWhatside, sprite, startTime, endTime, startX, Ypos, inEasing, outEasing, offset, i);

                fixWrongChars(textChars[i].ToString(), sprite, startTime);

                if (enableColor)
                    sprite.Color(startTime, textColor);
                /*
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime, endTime + fadeBegEndDelay, opacity, 0);*/

                if (enableBackColor)
                {
                    float sqWidth = 40 * spriteScale;
                    float spriteHeight = 30 * spriteScale;
                    var square = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos));

                    square.Color(startTime, backColor);
                    FromWhereSwitchTate(fromWhatside, square, startTime, endTime, sqXpos, Ypos, inEasing, outEasing, offset, i);

                    float customWidthFloat = 2;

                    if (!customWidth)
                    {
                        square.ScaleVec(startTime, sqWidth, spriteHeight);

                        if (i == 0)
                        {
                            var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos - (spriteHeight * 0.75f)));
                            sqLeftOver.Color(startTime, backColor);
                            FromWhereSwitchTate(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos - (spriteHeight * 0.75f), inEasing, outEasing, offset, i);

                            if (!customWidth)
                                sqLeftOver.ScaleVec(startTime, sqWidth, spriteHeight / 2);
                            else
                                sqLeftOver.ScaleVec(startTime, customWidthFloat, spriteHeight / 2);
                            sqLeftOver.MoveX(startTime, sqXpos);
                        }
                        else if (i == textChars.Length - 1)
                        {
                            var sqLeftOver = textLayer.CreateSprite(sqPath, OsbOrigin.Centre, new Vector2(sqXpos, Ypos + (spriteHeight * 0.75f)));
                            sqLeftOver.Color(startTime, backColor);
                            FromWhereSwitchTate(fromWhatside, sqLeftOver, startTime, endTime, sqXpos, Ypos + (spriteHeight * 0.75f), inEasing, outEasing, offset, i);

                            if (!customWidth)
                                sqLeftOver.ScaleVec(startTime, sqWidth, spriteHeight / 2);
                            else
                                sqLeftOver.ScaleVec(startTime, customWidthFloat, spriteHeight / 2);
                            sqLeftOver.MoveX(startTime, sqXpos);
                        }
                    }
                    else
                    {
                        square.ScaleVec(startTime, customWidthFloat, spriteHeight);
                        square.Fade(startTime, 0.8f);
                        square.MoveX(startTime, sqXpos);
                    }
                }
            }
        }

        public void FromWhereSwitchNor(int fromWhatside, OsbSprite sprite, float startTime, float endTime, float X, float Y, OsbEasing inEasing, OsbEasing outEasing, float offset, int i)
        {
            switch (fromWhatside)
            {
                case 0:
                    moveFromTop(sprite, startTime, endTime, Y, inEasing, outEasing, 0);
                    break;
                case 1:
                    moveFromRight(sprite, startTime, endTime, X, inEasing, outEasing, offset * i);
                    break;
                case 2:
                    moveFromBot(sprite, startTime, endTime, Y, inEasing, outEasing, 0);
                    break;
                case 3:
                    moveFromLeft(sprite, startTime, endTime, X, inEasing, outEasing, offset * i);
                    break;
            }
        }

        public void FromWhereSwitchTate(int fromWhatside, OsbSprite sprite, float startTime, float endTime, float X, float Y, OsbEasing inEasing, OsbEasing outEasing, float offset, int i)
        {
            switch (fromWhatside)
            {
                case 0:
                    moveFromTop(sprite, startTime, endTime, Y, inEasing, outEasing, offset * i);
                    break;
                case 1:
                    moveFromRight(sprite, startTime, endTime, X, inEasing, outEasing, 0);
                    break;
                case 2:
                    moveFromBot(sprite, startTime, endTime, Y, inEasing, outEasing, offset * i);
                    break;
                case 3:
                    moveFromLeft(sprite, startTime, endTime, X, inEasing, outEasing, 0);
                    break;
            }
        }

        public void FromWhereSwitchTateDieFast(int fromWhatside, OsbSprite sprite, float startTime, float endTime, float X, float Y, OsbEasing inEasing, OsbEasing outEasing, float offset, int i)
        {
            switch (fromWhatside)
            {
                case 0:
                    moveFromTop(sprite, startTime, endTime, Y, inEasing, outEasing, offset * i);
                    break;
                case 1:
                    moveFromRight(sprite, startTime, endTime, X, inEasing, outEasing, 0);
                    break;
                case 2:
                    moveFromBotDieFast(sprite, startTime, endTime, Y, inEasing, outEasing, offset * i);
                    break;
                case 3:
                    moveFromLeft(sprite, startTime, endTime, X, inEasing, outEasing, 0);
                    break;
            }
        }

        public void moveFromLeft(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float startOffset)
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeStartDelay, -250 + startOffset, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeStartDelay, endTime, startX, startX + 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeBegEndDelay, startX + 4, 900 + startOffset);
        }

        public void moveFromRight(OsbSprite sprite, float startTime, float endTime, float startX, OsbEasing inEasing, OsbEasing outEasing, float startOffset)
        {
            sprite.MoveX(inEasing, startTime, startTime + fadeStartDelay, 900 + startOffset, startX);
            sprite.MoveX(OsbEasing.None, startTime + fadeStartDelay, endTime, startX, startX - 4);
            sprite.MoveX(outEasing, endTime, endTime + fadeBegEndDelay, startX - 4, -250 + startOffset);
        }

        public void moveFromTop(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float startOffset)
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeStartDelay, 600 + startOffset, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeStartDelay, endTime, Ypos, Ypos - 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeBegEndDelay, Ypos - 4, -150 + startOffset);
        }

        public void moveFromBot(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float startOffset)
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeStartDelay, -150 + startOffset, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeStartDelay, endTime, Ypos, Ypos + 4);
            sprite.MoveY(outEasing, endTime, endTime + fadeBegEndDelay, Ypos + 4, 600 + startOffset);
        }

        public void moveFromBotDieFast(OsbSprite sprite, float startTime, float endTime, float Ypos, OsbEasing inEasing, OsbEasing outEasing, float startOffset)
        {
            sprite.MoveY(inEasing, startTime, startTime + fadeStartDelay, -150 + startOffset, Ypos);
            sprite.MoveY(OsbEasing.None, startTime + fadeStartDelay, endTime + fadeBegEndDelay, Ypos, Ypos + 4);
        }

        public void fixWrongChars(string chara, OsbSprite sprite, float startTime)
        {
            if (chara == "ー")
            {
                sprite.Rotate(startTime, MathHelper.DegreesToRadians(90));
            }
        }

        public void CreateText(int startTime, int endTime, Vector2 position, OsbOrigin origin, string text)
        {
            var texture = bigFont.GetTexture(text);
            var sprite = GetLayer("last shit").CreateSprite(texture.Path, origin, position);

            sprite.Scale(startTime, 0.5f * 1);
            sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
            sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
            sprite.Color(startTime, colorRGB(36, 161, 214));
        }

        // public void CreateText(string text, int startTime, int endTime, float startX, float startY, float spriteScale)
        // {
        //     char[] textChars = text.ToCharArray(0, text.Length);

        //     for (int i = 0; i < textChars.Length; i++)
        //     {
        //         float offset = 30 * spriteScale;

        //         float Ypos = startY + offset *i;
        //         var texture = font.GetTexture(textChars[i].ToString());
        //         var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
        //         var charBitmap = GetMapsetBitmap(texture.Path);

        //         sprite.Scale(startTime, 0.5f * spriteScale);
        //         sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
        //         sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
        //         sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
        //         sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeEndDelay, Ypos, Ypos + amountToMove);
        //         if (enableColor)
        //         sprite.Color(startTime, textColor);
        //     }
        // }

        public void CreateGenkouText(string text, int startTime, int endTime, float startX, float startY, float spriteScale)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            for (int i = 0; i < textChars.Length; i++)
            {
                float offset = 23 * spriteScale;

                float Ypos = startY + offset * i;
                var texture = font.GetTexture(textChars[i].ToString());
                var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
                var charBitmap = GetMapsetBitmap(texture.Path);

                sprite.Scale(startTime, 0.5f * spriteScale);
                sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
                sprite.Fade(endTime - 100, endTime, opacity, 0);
                sprite.Color(startTime, Color4.Black);
                // sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
                // sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeBegEndDelay, Ypos, Ypos + amountToMove);
            }
        }

        public void CreateOOkikuuu(string text, int[] startTimes, int endTime, float[] x, float[] y, float spriteScale, float[] rotations)
        {
            char[] textChars = text.ToCharArray(0, text.Length);

            for (int i = 0; i < textChars.Length; i++)
            {
                var texture = handfont.GetTexture(textChars[i].ToString());
                var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(x[i], y[i]));

                sprite.Scale(startTimes[i], 0.8f * spriteScale);
                sprite.Rotate(startTimes[i], MathHelper.DegreesToRadians(rotations[i]));
                sprite.Fade(startTimes[i], startTimes[i] + 50, 0, opacity);
                sprite.Fade(endTime - 100, endTime, opacity, 0);
                sprite.Color(startTimes[i], Color4.Black);
            }
        }

        // public void CreateColoredText(string text, int startTime, int endTime, float startX, float startY, float spriteScale, Color4 color)
        // {
        //     char[] textChars = text.ToCharArray(0, text.Length);

        //     for (int i = 0; i < textChars.Length; i++)
        //     {
        //         float offset = 30 * spriteScale;

        //         float Ypos = startY + offset *i;
        //         var texture = font.GetTexture(textChars[i].ToString());
        //         var sprite = GetLayer("").CreateSprite(texture.Path, OsbOrigin.Centre, new Vector2(startX, Ypos));
        //         var charBitmap = GetMapsetBitmap(texture.Path);

        //         sprite.Scale(startTime, 0.5f * spriteScale);
        //         sprite.Fade(startTime, startTime + fadeStartDelay, 0, opacity);
        //         sprite.Fade(endTime, endTime + fadeEndDelay, opacity, 0);
        //         sprite.MoveY(OsbEasing.OutQuint, startTime, startTime + fadeStartDelay, Ypos - amountToMove, Ypos);
        //         sprite.MoveY(OsbEasing.InExpo, endTime, endTime + fadeEndDelay, Ypos, Ypos + amountToMove);
        //         if (enableColor)
        //         sprite.Color(startTime, color);
        //     }
        // }
    }
}
