using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This multi-select menu will populate its options with a list of Slack users visible to the current user in the active workspace.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#users_multi_select">https://api.slack.com/reference/block-kit/block-elements#users_multi_select</a>
    /// </summary>
    public class UsersMultiSelect : UsersSelectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersMultiSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUsers">An array of user IDs of any valid users to be pre-selected when the menu loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public UsersMultiSelect(
            PlainText placeholder,
            string actionId,
            IEnumerable<string>? initialUsers = null,
            int? maxSelectedItems = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(true, placeholder, actionId, confirmDialog, focusOnLoad)
        {
            InitialUsers = initialUsers;
            MaxSelectedItems = maxSelectedItems;
        }

        /// <summary>
        /// An array of user IDs of any valid users to be pre-selected when the menu loads.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_user")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_user")]
#endif
        public IEnumerable<string>? InitialUsers { get; }

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