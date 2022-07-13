namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An object containing some text, formatted using mrkdwn, our proprietary contribution to the much beloved Markdown standard.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#text">https://api.slack.com/reference/block-kit/composition-objects#text</a>
    /// </summary>
    public class MarkdownText : TextObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownText"/> class.
        /// </summary>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="verbatim">When set to false (as is default) URLs will be auto-converted into links, conversation names will be link-ified, and certain mentions will be <a href="https://api.slack.com/reference/surfaces/formatting#automatic-parsing">automatically parsed</a>. Using a value of true will skip any preprocessing of this nature, although you can still include manual parsing strings.</param>
        public MarkdownText(string text, bool? verbatim = null) : base("mrkdwn", text)
        {
            Verbatim = verbatim;
        }

        /// <summary>
        /// When set to false (as is default) URLs will be auto-converted into links, conversation names will be link-ified, and certain mentions will be <a href="https://api.slack.com/reference/surfaces/formatting#automatic-parsing">automatically parsed</a>. Using a value of true will skip any preprocessing of this nature, although you can still include manual parsing strings.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("verbatim")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("verbatim")]
#endif
        public bool? Verbatim { get; }
    }
}