using System.IO;
using System.Text.Json;
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
            return JsonSerializer.Serialize(message, SlackJsonSerializerOptions.Options);
        }

        /// <summary>
        /// Converts the message into a JSON formatted for the Slack API.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <param name="utf8Json">The UTF-8 stream to write to.</param>
        /// <returns></returns>
        public static void ToJson(this SlackMessageBase message, Stream utf8Json)
        {
            JsonSerializer.Serialize(utf8Json, message, SlackJsonSerializerOptions.Options);
        }

        /// <summary>
        /// Converts the message into a JSON formatted for the Slack API.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <param name="utf8Json">The UTF-8 stream to write to.</param>
        /// <param name="cancellationToken">A token that may be used to cancel the write operation.</param>
        /// <returns></returns>
        public static Task ToJsonAsync(this SlackMessageBase message, Stream utf8Json, CancellationToken cancellationToken = default)
        {
            return JsonSerializer.SerializeAsync(utf8Json, message, SlackJsonSerializerOptions.Options, cancellationToken);
        }
    }
}