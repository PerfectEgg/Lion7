using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class special
    {
        static void Main(string[] args) {
            int ResolutionWidth = 3840;
            int ResolutionLength = 2160;
            int ResolutionHz = 60;
            string FullScreen = "ON";
            string V_SYNC = "OFF";
            string ParticleEffects = "NORMAL";
            string BlurQuality = "MEDIUM";
            string FrameRateCap = "ON";

            Console.WriteLine("               VIDEO");

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"RESOLUTION:        {ResolutionWidth} X {ResolutionLength} @ {ResolutionHz}Hz");
            Console.WriteLine($"FULL SCREEN:                      {FullScreen}");
            Console.WriteLine($"V-SYNC:                           {V_SYNC}");
            Console.WriteLine($"PARTICLE EFFECTS:              {ParticleEffects}");
            Console.WriteLine($"BLUR QUALITY:                  {BlurQuality}");
            Console.WriteLine($"FRAME RATE CAP:                   {FrameRateCap}");
            Console.WriteLine("           SCREEN SCALE");
            Console.WriteLine("            BRIGHTNESS");
            Console.WriteLine("          RESET DEFAULTS");
            Console.WriteLine("               BACK");
        }
    }
}
