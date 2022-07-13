#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace Slack.MessageBuilder.Converters.NewtonsoftJson
{
    internal class TimeSpanTimeJsonConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.ReadAsString();
            return TimeSpan.ParseExact(value, "hh\\:mm", DateTimeFormatInfo.InvariantInfo);
        }

        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString("hh\\:mm"));
        }
    }
}
#endif