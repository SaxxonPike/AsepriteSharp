using System.Collections.Generic;
using AsepriteSharp.Converters;
using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    [JsonObject]
    public class Slice
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("keys")]
        public List<SliceKey> Keys { get; set; } = new List<SliceKey>();
        [JsonProperty("color")]
        [JsonConverter(typeof(RgbaJsonConverter))]
        public Rgba Color { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}