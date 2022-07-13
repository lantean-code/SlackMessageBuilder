
namespace SlackMessageBuilder
{
    /// <summary>
    /// An object that represents a single selectable item in a select menu, multi-select menu, checkbox group, radio button group, or overflow menu.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#option">https://api.slack.com/reference/block-kit/composition-objects#option</a>
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Option"/> class.
        /// </summary>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <param name="url">A URL to load in the user's browser when the option is clicked. The url attribute is only available in overflow menus. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.</param>
        public Option(
            TextObject text,
            string value,
            PlainText? description = null,
            string? url = null)
        {
            Text = text;
            Description = description;
            Url = url;
            Value = value;
        }

        /// <summary>
        /// A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public TextObject Text { get; }

        /// <summary>
        /// A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string Value { get; }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("description")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("description")]
#endif
        public PlainText? Description { get; }

        /// <summary>
        /// A URL to load in the user's browser when the option is clicked. The url attribute is only available in overflow menus. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("url")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("url")]
#endif
        public string? Url { get; }
    }
}