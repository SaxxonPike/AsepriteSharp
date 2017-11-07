using AsepriteSharp.ModelConverters;
using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains information about a cel.
    /// </summary>
    [JsonObject]
    public class Cel
    {
        [JsonProperty("frame")]
        public int FrameNumber { get; set; }
        [JsonProperty("color")]
        [JsonConverter(typeof(RgbaJsonConverter))]
        public Rgba Color { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}