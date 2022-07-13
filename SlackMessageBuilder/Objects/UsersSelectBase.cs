namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    ///
    /// </summary>
    public abstract class UsersSelectBase : SelectMenu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSelectBase"/> class.
        /// </summary>
        /// <param name="isMultiSelect">Indicates whether the element will be a multi select.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        protected UsersSelectBase(
            bool isMultiSelect,
            PlainText placeholder,
            string actionId,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base($"{(isMultiSelect ? "multi_" : "")}users", placeholder, actionId, confirmDialog, focusOnLoad)
        {
        }
    }
}