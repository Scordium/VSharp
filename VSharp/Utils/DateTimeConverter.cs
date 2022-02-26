using System;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace VSharpPlus.Utils
{
    public class DateTimeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds((long)reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}