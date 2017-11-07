using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    [JsonObject]
    public class SliceKey
    {
        [JsonProperty("frame")]
        public int Frame { get; set; }
        [JsonProperty("bounds")]
        public Rect Bounds { get; set; }
        [JsonProperty("center")]
        public Rect Center { get; set; }
        [JsonProperty("pivot")]
        public Point Pivot { get; set; }
    }
}