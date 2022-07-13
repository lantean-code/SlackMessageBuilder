using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class SelectMenu : TypedObject, ISectionElement, IInputElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectMenu"/> class.
        /// </summary>
        /// <param name="type">The type of element.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        protected SelectMenu(
            string type,
            PlainText placeholder,
            string actionId,
            Confirm? confirmDialog,
            bool? focusOnLoad) : base($"{type}_select")
        {
            Placeholder = placeholder;
            ActionId = actionId;
            ConfirmDialog = confirmDialog;
            FocusOnLoad = focusOnLoad;
        }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.
        /// </summary>
        [JsonPropertyName("placeholder")]
        public PlainText Placeholder { get; }

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
        [JsonPropertyName("action_id")]
        public string ActionId { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.
        /// </summary>
        [JsonPropertyName("confirm")]
        public Confirm? ConfirmDialog { get; }

        /// <summary>
        /// Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.
        /// </summary>
        [JsonPropertyName("focus_on_load")]
        public bool? FocusOnLoad { get; }
    }
}