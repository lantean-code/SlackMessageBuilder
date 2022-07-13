namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An object containing some text, formatted either as plain_text.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#text">https://api.slack.com/reference/block-kit/composition-objects#text</a>
    /// </summary>
    public class PlainText : TextObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlainText"/> class.
        /// </summary>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="emoji">Indicates whether emojis in a text field should be escaped into the colon emoji format.</param>
        public PlainText(string text, bool? emoji = null) : base("plain_text", text)
        {
            Emoji = emoji;
        }

        /// <summary>
        /// Indicates whether emojis in a text field should be escaped into the colon emoji format.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("emoji")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("emoji")]
#endif
        public bool? Emoji { get; }
    }
}