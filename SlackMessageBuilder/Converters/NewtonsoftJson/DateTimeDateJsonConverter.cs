#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Slack.MessageBuilder.Converters.NewtonsoftJson
{
    internal class DateTimeDateJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.ReadAsString();
            return DateTime.ParseExact(value, "yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
        }

        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString("yyyy-MM-dd"));
        }
    }
}
#endif