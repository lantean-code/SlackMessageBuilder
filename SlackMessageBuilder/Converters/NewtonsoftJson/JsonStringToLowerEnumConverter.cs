#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using System;

namespace SlackMessageBuilder.Converters.NewtonsoftJson
{
    internal class JsonStringToLowerEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.ValueType != typeof(string))
            {
                return null;
            }
            var value = (string?)reader.Value;
            if (value is null)
            {
                return null;
            }

            return Enum.Parse(objectType, value);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                return;
            }
            writer.WriteValue(value.ToString().ToLowerInvariant());
        }
    }
}
#endif