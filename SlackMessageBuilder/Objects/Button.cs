namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An interactive component that inserts a button. The button can be a trigger for anything from opening a simple link to starting a complex workflow.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#button">https://api.slack.com/reference/block-kit/block-elements#button</a>
    /// </summary>
    public class Button : TypedObject, ISectionElement, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button"/> class.
        /// </summary>
        /// <param name="text">A text object that defines the button's text. Can only be of type: plain_text. text may truncate with ~30 characters. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="url">A URL to load in the user's browser when the button is clicked. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.</param>
        /// <param name="value">The value to send along with the interaction payload. Maximum length for this field is 2000 characters.</param>
        /// <param name="style">Decorates buttons with alternative visual color schemes. Use this option with restraint.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog after the button is clicked.</param>
        /// <param name="accessibilityLabel">A label for longer descriptive text about a button element. This label will be read out by screen readers instead of the button text object. Maximum length for this field is 75 characters.</param>
        public Button(
            PlainText text,
            string actionId,
            string? url = null,
            string? value = null,
            ButtonStyle? style = null,
            Confirm? confirmDialog = null,
            string? accessibilityLabel = null) : base("button")
        {
            Text = text;
            ActionId = actionId;
            Url = url;
            Value = value;
            Style = style;
            ConfirmDialog = confirmDialog;
            AccessibilityLabel = accessibilityLabel;
        }

        /// <summary>
        /// A text object that defines the button's text. Can only be of type: plain_text. text may truncate with ~30 characters. Maximum length for the text in this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public PlainText Text { get; }

        /// <summary>
        /// An identifier for the action triggered when the button is clicked. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("action_id")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("action_id")]
#endif
        public string ActionId { get; }

        /// <summary>
        /// A URL to load in the user's browser when the button is clicked. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("url")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("url")]
#endif
        public string? Url { get; }

        /// <summary>
        /// The value to send along with the interaction payload. Maximum length for this field is 2000 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("value")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("value")]
#endif
        public string? Value { get; }

        /// <summary>
        /// Decorates buttons with alternative visual color schemes. Use this option with restraint.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("style")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("style")]
#endif
        public ButtonStyle? Style { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog after the button is clicked.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("confirm")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("confirm")]
#endif
        public Confirm? ConfirmDialog { get; }

        /// <summary>
        /// A label for longer descriptive text about a button element. This label will be read out by screen readers instead of the button text object. Maximum length for this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("accessibility_label")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("accessibility_label")]
#endif
        public string? AccessibilityLabel { get; }
    }
}