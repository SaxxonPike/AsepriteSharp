using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Represents a positioned area in 2-dimensional space.
    /// </summary>
    [JsonObject]
    public struct Rect
    {
        [JsonProperty("x")]
        public int Left { get; set; }
        [JsonProperty("y")]
        public int Top { get; set; }
        [JsonProperty("w")]
        public int Width { get; set; }
        [JsonProperty("h")]
        public int Height { get; set; }
    }
}