#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using Slack.MessageBuilder.Converters.NewtonsoftJson;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Options for Newtonsoft.Json serialization.
    /// </summary>
    public static class SlackJsonSerializerSettings
    {
        /// <summary>
        /// These options ensure the JSON output matches the specification for the Slack API.
        /// </summary>
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings();

        static SlackJsonSerializerSettings()
        {
            Settings.NullValueHandling = NullValueHandling.Ignore;
            Settings.Converters.Add(new DateTimeDateJsonConverter());
            Settings.Converters.Add(new JsonStringToLowerEnumConverter());
            Settings.Converters.Add(new RuntimeTypeJsonConverter());
            Settings.Converters.Add(new TimeSpanTimeJsonConverter());
            Settings.Converters.Add(new MetadataUrlEncodedJsonConverter());
        }
    }
}
#endif