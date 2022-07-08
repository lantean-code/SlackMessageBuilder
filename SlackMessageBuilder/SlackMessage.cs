using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public class SlackMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackMessage"/> class.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <param name="blocks">An array of layout blocks in the same format as described in the building blocks guide.</param>
        /// <param name="attachments">An array of legacy secondary attachments. We recommend you use blocks instead.</param>
        /// <param name="threadId">The ID of another un-threaded message to reply to.</param>
        public SlackMessage(
            string text,
            bool? isMarkdown = null,
            IEnumerable<IBlockElement>? blocks = null,
            IEnumerable<Attachment>? attachments = null,
            string? threadId = null)
        {
            Text = text;
            IsMarkdown = isMarkdown;
            Blocks = blocks;
            Attachments = attachments;
            ThreadId = threadId;
        }

        /// <summary>
        /// The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; }

        /// <summary>
        /// Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.
        /// </summary>
        [JsonPropertyName("mrkdwn")]
        public bool? IsMarkdown { get; }

        /// <summary>
        /// An array of layout blocks in the same format as described in the building blocks guide.
        /// </summary>
        [JsonPropertyName("blocks")]
        public IEnumerable<IBlockElement>? Blocks { get; }

        /// <summary>
        /// An array of legacy secondary attachments. We recommend you use blocks instead.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IEnumerable<Attachment>? Attachments { get; }

        /// <summary>
        /// The ID of another un-threaded message to reply to.
        /// </summary>
        [JsonPropertyName("thread_ts")]
        public string? ThreadId { get; }
    }
}