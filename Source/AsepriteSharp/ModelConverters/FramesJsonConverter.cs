using System;
using System.Collections.Generic;
using AsepriteSharp.Models;
using Newtonsoft.Json;

namespace AsepriteSharp.ModelConverters
{
    /// <inheritdoc />
    /// <summary>
    /// Handles conversion of a JSON frames collection.
    /// </summary>
    public class FramesJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartArray:
                    return serializer.Deserialize<List<Frame>>(reader);
                case JsonToken.StartObject:
                    return FramesConverter.Decode(serializer.Deserialize<Dictionary<string, Frame>>(reader));
            }
            
            throw new JsonSerializationException("'frames' must either be an object or an array.");
        }

        public override bool CanConvert(Type objectType) => true;
    }
}