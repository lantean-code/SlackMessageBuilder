using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Slack.MessageBuilder.Objects;
using System;
using System.Net;

namespace Slack.MessageBuilder.Converters.NewtonsoftJson
{
    internal class MetadataUrlEncodedJsonConverter : JsonConverter<Metadata>
    {
        public override Metadata? ReadJson(JsonReader reader, Type objectType, Metadata? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.ReadAsString();
            if (value is null)
            {
                return null;
            }

            var decodedValue = WebUtility.UrlDecode(value);

            var jObject = JObject.Parse(decodedValue);
            var eventTypeProperty = jObject.Property("event_type");
            var eventPayloadProperty = jObject.Property("event_payload");

            var eventType = eventTypeProperty?.Value<string>();
            var eventPayload = eventPayloadProperty?.Value<string>();
            if (eventType is null || eventPayload is null)
            {
                throw new JsonSerializationException();
            }

            return new Metadata(eventType, eventPayload);
        }

        public override void WriteJson(JsonWriter writer, Metadata? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                return;
            }
            var jObject = new JObject();
            jObject.Add("event_type", value.EventType);
            jObject.Add("event_payload", value.EventPayload);

            var json = jObject.ToString(Formatting.None);

            writer.WriteValue(WebUtility.UrlEncode(json));
        }
    }
}