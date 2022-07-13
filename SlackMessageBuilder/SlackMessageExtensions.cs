using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SlackMessageBuilder
{
    /// <summary>
    /// SlackMessage extensions.
    /// </summary>
    public static class SlackMessageExtensions
    {
        /// <summary>
        /// Converts the message into a JSON formatted for the Slack API.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string ToJson(this SlackMessageBase message)
        {
#if SYSTEMTEXTJSON || DEBUG
            return System.Text.Json.JsonSerializer.Serialize(message, SlackJsonSerializerOptions.Options);
#elif NEWTONSOFTJSON
            return Newtonsoft.Json.JsonConvert.SerializeObject(message, SlackJsonSerializerSettings.Settings);
#endif
        }

        /// <summary>
        /// Converts the message into a JSON formatted for the Slack API.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <param name="utf8Json">The UTF-8 stream to write to.</param>
        /// <returns></returns>
        public static void ToJson(this SlackMessageBase message, Stream utf8Json)
        {
#if SYSTEMTEXTJSON || DEBUG
            System.Text.Json.JsonSerializer.Serialize(utf8Json, message, SlackJsonSerializerOptions.Options);
#elif NEWTONSOFTJSON
            var serializer = Newtonsoft.Json.JsonSerializer.Create(SlackJsonSerializerSettings.Settings);
            using (var sw = new StreamWriter(utf8Json))
            using (var writer = new Newtonsoft.Json.JsonTextWriter(sw))
            {
                serializer.Serialize(writer, message);
            }
#endif
        }

#if SYSTEMTEXTJSON || DEBUG
        /// <summary>
        /// Converts the message into a JSON formatted for the Slack API.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <param name="utf8Json">The UTF-8 stream to write to.</param>
        /// <param name="cancellationToken">A token that may be used to cancel the write operation.</param>
        /// <returns></returns>
        public static Task ToJsonAsync(this SlackMessageBase message, Stream utf8Json, CancellationToken cancellationToken = default)
        {
            return System.Text.Json.JsonSerializer.SerializeAsync(utf8Json, message, SlackJsonSerializerOptions.Options, cancellationToken);
        }
#endif
    }
}