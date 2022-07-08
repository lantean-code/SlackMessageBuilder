using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This select menu will populate its options with a list of public channels visible to the current user in the active workspace.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#channel_select">https://api.slack.com/reference/block-kit/block-elements#channel_select</a>
    /// </summary>
    public class PublicChannelsSelect : PublicChannelsSelectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicChannelsSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialChannel">The ID of any valid public channel to be pre-selected when the menu loads.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target channel for the message will be determined by the value of this select menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public PublicChannelsSelect(
            PlainText placeholder,
            string actionId,
            string? initialChannel = null,
            bool? responseUrlEnabled = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(false, placeholder, actionId, confirmDialog, focusOnLoad)
        {
            InitialChannel = initialChannel;
            ResponseUrlEnabled = responseUrlEnabled;
        }

        /// <summary>
        /// The ID of any valid public channel to be pre-selected when the menu loads.
        /// </summary>
        [JsonPropertyName("initial_channel")]
        public string? InitialChannel { get; }

        /// <summary>
        /// When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target channel for the message will be determined by the value of this select menu.
        /// </summary>
        /// <remarks>
        /// This field only works with menus in input blocks in modals.
        /// </remarks>
        [JsonPropertyName("response_url_enabled")]
        public bool? ResponseUrlEnabled { get; }
    }
}