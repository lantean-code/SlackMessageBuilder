#if SYSTEMTEXTJSON || DEBUG
using Slack.MessageBuilder.Converters.SystemTextJson;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Slack.MessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public static class SlackJsonSerializerOptions
    {
        /// <summary>
        ///
        /// </summary>
        public static JsonSerializerOptions Options { get; } = new JsonSerializerOptions(JsonSerializerDefaults.Web);

        static SlackJsonSerializerOptions()
        {
            Options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
            Options.Converters.Add(new DateTimeDateJsonConverter());
            Options.Converters.Add(new JsonStringToLowerEnumConverter());
            Options.Converters.Add(new TimeSpanTimeJsonConverter());
            Options.Converters.Add(new RuntimeTypeJsonConverter());
        }
    }
}
#endif