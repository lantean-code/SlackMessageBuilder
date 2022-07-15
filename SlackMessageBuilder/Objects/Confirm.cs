namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An object that defines a dialog that provides a confirmation step to any interactive element. This dialog will ask the user to confirm their action by offering a confirm and deny buttons.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#confirm">https://api.slack.com/reference/block-kit/composition-objects#confirm</a>
    /// </summary>
    public class Confirm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Confirm"/> class.
        /// </summary>
        /// <param name="title">A <see cref="PlainText"/> object that defines the dialog's title. Maximum length for this field is 100 characters.</param>
        /// <param name="text">A <see cref="TextObject"/> object that defines the explanatory text that appears in the confirm dialog. Maximum length for the text in this field is 300 characters.</param>
        /// <param name="confirmButtonText">A <see cref="PlainText"/> object object to define the text of the button that confirms the action. Maximum length for the text in this field is 30 characters.</param>
        /// <param name="denyButtonText">A <see cref="PlainText"/> object to define the text of the button that cancels the action. Maximum length for the text in this field is 30 characters.</param>
        /// <param name="style">Defines the color scheme applied to the confirm button. A value of danger will display the button with a red background on desktop, or red text on mobile. A value of primary will display the button with a green background on desktop, or blue text on mobile. If this field is not provided, the default value will be primary.</param>
        public Confirm(
            PlainText title,
            TextObject text,
            PlainText confirmButtonText,
            PlainText denyButtonText,
            ButtonStyle? style = null)
        {
            Title = title;
            Text = text;
            ConfirmButtonText = confirmButtonText;
            DenyButtonText = denyButtonText;
            Style = style;
        }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines the dialog's title. Maximum length for this field is 100 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("title")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("title")]
#endif
        public PlainText Title { get; }

        /// <summary>
        /// A <see cref="TextObject"/> object that defines the explanatory text that appears in the confirm dialog. Maximum length for the text in this field is 300 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public TextObject Text { get; }

        /// <summary>
        /// A <see cref="PlainText"/> object object to define the text of the button that confirms the action. Maximum length for the text in this field is 30 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("confirm")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("confirm")]
#endif
        public PlainText ConfirmButtonText { get; }

        /// <summary>
        /// A <see cref="PlainText"/> object to define the text of the button that cancels the action. Maximum length for the text in this field is 30 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("deny")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("deny")]
#endif
        public PlainText DenyButtonText { get; }

        /// <summary>
        /// Defines the color scheme applied to the confirm button. A value of danger will display the button with a red background on desktop, or red text on mobile. A value of primary will display the button with a green background on desktop, or blue text on mobile. If this field is not provided, the default value will be primary.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("style")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("style")]
#endif
        public ButtonStyle? Style { get; }
    }
}