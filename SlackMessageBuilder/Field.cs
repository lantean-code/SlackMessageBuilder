
namespace SlackMessageBuilder
{
    /// <summary>
    /// <a href="https://api.slack.com/reference/messaging/attachments">https://api.slack.com/reference/messaging/attachments</a>
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        /// <param name="name">Shown as a bold heading displayed in the field object. It cannot contain markup and will be escaped for you.</param>
        /// <param name="value">The text value displayed in the field object. It can be formatted as plain text, or with mrkdwn by using the mrkdwn_in option above.</param>
        /// <param name="short">Indicates whether the field object is short enough to be displayed side-by-side with other field objects. Defaults to false.</param>
        public Field(string? name = null, string? value = null, bool? @short = null)
        {
            Name = name;
            Value = value;
            Short = @short;
        }

        /// <summary>
        /// Shown as a bold heading displayed in the field object. It cannot contain markup and will be escaped for you.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("name")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("name")]
#endif
        public string? Name { get; }

        /// <summary>
        /// The text value displayed in the field object. It can be formatted as plain text, or with mrkdwn by using the mrkdwn_in option above.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string? Value { get; }

        /// <summary>
        /// Indicates whether the field object is short enough to be displayed side-by-side with other field objects. Defaults to false.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("short")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("short")]
#endif
        public bool? Short { get; }
    }
}