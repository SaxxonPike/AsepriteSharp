using Newtonsoft.Json;

namespace AsepriteSharp.Models
{
    /// <summary>
    /// Contains information about sprite dimensions within a sprite sheet.
    /// </summary>
    [JsonObject]
    public class Frame
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }
        [JsonProperty("frame")]
        public Rect Rect { get; set; }
        [JsonProperty("rotated")]
        public bool IsRotated { get; set; }
        [JsonProperty("trimmed")]
        public bool IsTrimmed { get; set; }
        [JsonProperty("spriteSourceSize")]
        public Rect SpriteSourceSize { get; set; }
        [JsonProperty("sourceSize")]
        public Size SourceSize { get; set; }
        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}