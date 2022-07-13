using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// This multi-select menu will populate its options with a list of public and private channels, DMs, and MPIMs visible to the current user in the active workspace.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#conversation_multi_select">https://api.slack.com/reference/block-kit/block-elements#conversation_multi_select</a>
    /// </summary>
    public class ConversationsMultiSelect : ConversationsSelectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsMultiSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialConversations">An array of one or more IDs of any valid conversations to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversations will be ignored.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public ConversationsMultiSelect(
            PlainText placeholder,
            string actionId,
            IEnumerable<string>? initialConversations = null,
            ConversationFilter? filter = null,
            bool defaultToCurrentConversation = false,
            bool responseUrlEnabled = false,
            int? maxSelectedItems = null,
            Confirm? confirmDialog = null,
            bool focusOnLoad = false) : base(true, placeholder, actionId, filter, defaultToCurrentConversation, responseUrlEnabled, confirmDialog, focusOnLoad)
        {
            InitialConversations = initialConversations;
            MaxSelectedItems = maxSelectedItems;
        }

        /// <summary>
        /// An array of one or more IDs of any valid conversations to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversations will be ignored.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_conversations")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_conversations")]
#endif
        public IEnumerable<string>? InitialConversations { get; }

        /// <summary>
        /// Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("max_selected_items")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("max_selected_items")]
#endif
        public int? MaxSelectedItems { get; }
    }
}