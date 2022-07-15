#if SYSTEMTEXTJSON || DEBUG
using Slack.MessageBuilder.Converters.SystemTextJson;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Options for System.Text.Json serialization.
    /// </summary>
    public static class SlackJsonSerializerOptions
    {
        /// <summary>
        /// These options ensure the JSON output matches the specification for the Slack API.
        /// </summary>
        public static JsonSerializerOptions Options { get; } = new JsonSerializerOptions();

        static SlackJsonSerializerOptions()
        {
            Options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
            Options.Converters.Add(new DateTimeDateJsonConverter());
            Options.Converters.Add(new JsonStringToLowerEnumConverter());
            Options.Converters.Add(new TimeSpanTimeJsonConverter());
            Options.Converters.Add(new RuntimeTypeJsonConverter());
            Options.Converters.Add(new MetadataUrlEncodedJsonConverter());
        }
    }
}
#endif