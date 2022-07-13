#if SYSTEMTEXTJSON || DEBUG
using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder.Converters.SystemTextJson
{
    internal class DateTimeDateJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateTime.ParseExact(value, "yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }
}
#endif