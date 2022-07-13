#if SYSTEMTEXTJSON || DEBUG
using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Slack.MessageBuilder.Converters.SystemTextJson
{
    internal class TimeSpanTimeJsonConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return TimeSpan.ParseExact(value, "hh\\:mm", DateTimeFormatInfo.InvariantInfo);
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("hh\\:mm"));
        }
    }
}
#endif