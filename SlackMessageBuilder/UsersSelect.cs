
namespace SlackMessageBuilder
{
    /// <summary>
    /// This select menu will populate its options with a list of Slack users visible to the current user in the active workspace.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#users_select">https://api.slack.com/reference/block-kit/block-elements#users_select</a>
    /// </summary>
    public class UsersSelect : UsersSelectBase, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUser">The user ID of any valid user to be pre-selected when the menu loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public UsersSelect(
            PlainText placeholder,
            string actionId,
            string? initialUser = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(false, placeholder, actionId, confirmDialog, focusOnLoad)
        {
            InitialUser = initialUser;
        }

        /// <summary>
        /// The user ID of any valid user to be pre-selected when the menu loads.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_user")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_user")]
#endif
        public string? InitialUser { get; }
    }
}