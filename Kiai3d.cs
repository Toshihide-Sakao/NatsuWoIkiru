using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Storyboarding3d;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Kiai3d : StoryboardObjectGenerator
    {
        public override void Generate()
        {

            PerspectiveCamera camera = new PerspectiveCamera();

            camera.NearClip.Add(0, 0.1f);
            camera.FarClip.Add(0, 22500);
            camera.NearFade.Add(0, 0);

        }
    }
}
