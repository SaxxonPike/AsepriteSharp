using System.Collections.Generic;
using AsepriteSharp.Converters;
using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains information about all data contained within a sprite sheet.
    /// </summary>
    [JsonObject]
    public class Sheet
    {
        [JsonProperty("frames")]
        [JsonConverter(typeof(FramesJsonConverter))]
        public List<Frame> Frames { get; set; }
        
        [JsonProperty("meta")]
        public Meta Metadata { get; set; }
    }
}