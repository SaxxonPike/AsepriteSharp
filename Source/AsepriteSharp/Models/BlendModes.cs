using System.Collections.Generic;
using JetBrains.Annotations;

namespace AsepriteSharp.Models
{
    [UsedImplicitly(ImplicitUseTargetFlags.Members)]
    public static class BlendModes
    {
        public static readonly string Normal = "normal";
        public static readonly string Multiply = "multiply";
        public static readonly string Screen = "screen";
        public static readonly string Overlay = "overlay";
        public static readonly string Darken = "darken";
        public static readonly string Lighten = "lighten";
        public static readonly string ColorDodge = "color_dodge";
        public static readonly string ColorBurn = "color_burn";
        public static readonly string HardLight = "hard_light";
        public static readonly string SoftLight = "soft_light";
        public static readonly string Difference = "difference";
        public static readonly string Exclusion = "exclusion";
        public static readonly string HslHue = "hsl_hue";
        public static readonly string HslSaturation = "hsl_saturation";
        public static readonly string HslColor = "hsl_color";
        public static readonly string HslLuminosity = "hsl_luminosity";
        public static readonly string Addition = "addition";
        public static readonly string Subtract = "subtract";
        public static readonly string Divide = "divide";
        public static readonly string Unknown = "unknown";

        public static IEnumerable<string> All
        {
            get
            {
                yield return Normal;
                yield return Multiply;
                yield return Screen;
                yield return Overlay;
                yield return Darken;
                yield return Lighten;
                yield return ColorDodge;
                yield return ColorBurn;
                yield return HardLight;
                yield return SoftLight;
                yield return Difference;
                yield return Exclusion;
                yield return HslHue;
                yield return HslSaturation;
                yield return HslColor;
                yield return HslLuminosity;
                yield return Addition;
                yield return Subtract;
                yield return Divide;
                // Exclude Unknown.
            }
        }
    }
}