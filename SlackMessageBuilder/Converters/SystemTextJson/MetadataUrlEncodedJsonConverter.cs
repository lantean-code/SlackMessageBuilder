#if SYSTEMTEXTJSON || DEBUG
using Slack.MessageBuilder.Objects;
using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Slack.MessageBuilder.Converters.SystemTextJson
{
    internal class MetadataUrlEncodedJsonConverter : JsonConverter<Metadata>
    {
        public override Metadata? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value is null)
            {
                return null;
            }

            var decodedValue = WebUtility.UrlDecode(value);

            var jsonDocument = JsonDocument.Parse(decodedValue);

            if (!jsonDocument.RootElement.TryGetProperty("event_type", out var eventTypeProperty))
            {
                throw new JsonException();
            }

            if (!jsonDocument.RootElement.TryGetProperty("event_payload", out var eventPayloadProperty))
            {
                throw new JsonException();
            }

            var eventType = eventTypeProperty.GetString();
            var eventPayload = eventPayloadProperty.GetString();
            if (eventType is null || eventPayload is null)
            {
                throw new JsonException();
            }

            return new Metadata(eventType, eventPayload);
        }

        public override void Write(Utf8JsonWriter writer, Metadata value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                return;
            }

            var jsonObject = new JsonObject
            {
                { "event_type", value.EventType },
                { "event_payload", value.EventPayload }
            };

            var json = jsonObject.ToString();

            writer.WriteStringValue(WebUtility.UrlEncode(json));
        }
    }
}
#endif