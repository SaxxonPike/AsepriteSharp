using System.Collections.Generic;

namespace AsepriteSharp.Models
{
    public static class Directions
    {
        public static readonly string Forward = "forward";
        public static readonly string Reverse = "reverse";
        public static readonly string PingPong = "pingpong";
        public static readonly string Unknown = string.Empty;

        public static IEnumerable<string> All
        {
            get
            {
                yield return Forward;
                yield return Reverse;
                yield return PingPong;
                // Exclude unknown.
            }
        }
    }
}