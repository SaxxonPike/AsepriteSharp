using System.Collections.Generic;
using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains supplemental information about a sprite sheet.
    /// </summary>
    [JsonObject]
    public class Meta
    {
        [JsonProperty("app")]
        public string App { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("size")]
        public Size Size { get; set; }
        [JsonProperty("scale")]
        public int Scale { get; set; }
        [JsonProperty("frameTags")]
        public List<FrameTag> FrameTags { get; set; } = new List<FrameTag>();
        [JsonProperty("layers")]
        public List<Layer> Layers { get; set; } = new List<Layer>();
        [JsonProperty("slices")]
        public List<Slice> Slices { get; set; } = new List<Slice>();
    }
}