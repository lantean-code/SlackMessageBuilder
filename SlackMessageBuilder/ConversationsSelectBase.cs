using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class ConversationsSelectBase : SelectMenu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsSelectBase"/> class.
        /// </summary>
        /// <param name="isMultiSelect">Indicates whether the element will be a multi select.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        protected ConversationsSelectBase(
            bool isMultiSelect,
            PlainText placeholder,
            string actionId,
            ConversationFilter? filter = null,
            bool defaultToCurrentConversation = false,
            bool responseUrlEnabled = false,
            Confirm? confirmDialog = null,
            bool focusOnLoad = false) : base($"{(isMultiSelect ? "multi_" : "")}conversations", placeholder, actionId, confirmDialog, focusOnLoad)
        {
            DefaultToCurrentConversation = defaultToCurrentConversation;
            ResponseUrlEnabled = responseUrlEnabled;
            Filter = filter;
        }

        /// <summary>
        /// Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.
        /// </summary>
        [JsonPropertyName("default_to_current_conversation")]
        public bool DefaultToCurrentConversation { get; }

        /// <summary>
        /// When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.
        /// </summary>
        /// <remarks>
        /// This field only works with menus in input blocks in modals.
        /// </remarks>
        [JsonPropertyName("response_url_enabled")]
        public bool ResponseUrlEnabled { get; }

        /// <summary>
        /// A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.
        /// </summary>
        [JsonPropertyName("filter")]
        public ConversationFilter? Filter { get; }
    }
}