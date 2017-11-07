using System;
using AsepriteSharp.Models;
using Newtonsoft.Json;

namespace AsepriteSharp.Converters
{
    /// <inheritdoc />
    /// <summary>
    /// Handles conversion of JSON RGB(A) strings.
    /// </summary>
    public class RgbaJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            
            if (value.GetType() != typeof(Rgba))
                throw new JsonSerializationException($"Color must be of type {nameof(Rgba)}.");

            serializer.Serialize(writer, RgbaConverter.Encode((Rgba) value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                throw new JsonSerializationException("Color must be a string.");

            var data = serializer.Deserialize<string>(reader);
            return RgbaConverter.Decode(data);
        }

        public override bool CanConvert(Type objectType) => true;
    }
}