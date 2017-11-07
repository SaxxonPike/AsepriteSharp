using System.Collections.Generic;
using AsepriteSharp.Converters;
using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains information about a layer.
    /// </summary>
    [JsonObject]
    public class Layer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("opacity")]
        public int Opacity { get; set; }
        [JsonProperty("blendMode")]
        public string BlendMode { get; set; }
        [JsonProperty("cels")]
        public List<Cel> Cels { get; set; }
        [JsonProperty("color")]
        [JsonConverter(typeof(RgbaJsonConverter))]
        public Rgba Color { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}