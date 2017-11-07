using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Represents a point in 2-dimensional space.
    /// </summary>
    [JsonObject]
    public struct Point
    {
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}