using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains supplemental information about a range of frames.
    /// </summary>
    [JsonObject]
    public class FrameTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("from")]
        public int FirstFrameNumber { get; set; }
        [JsonProperty("to")]
        public int LastFrameNumber { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
    }
}