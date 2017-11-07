using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Represents an area in 2-dimensional space.
    /// </summary>
    [JsonObject]
    public struct Size
    {
        [JsonProperty("w")]
        public int Width { get; set; }
        [JsonProperty("h")]
        public int Height { get; set; }
    }
}