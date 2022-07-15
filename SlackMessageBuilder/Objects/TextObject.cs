namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An object containing some text, formatted either as plain_text or using mrkdwn, our proprietary contribution to the much beloved Markdown standard.
    /// </summary>
    public abstract class TextObject : TypedObject, IContextElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="global::Slack.MessageBuilder.Objects.TextObject"/> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        protected TextObject(string type, string text) : base(type)
        {
            Text = text;
        }

        /// <summary>
        /// The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public string Text { get; }
    }
}