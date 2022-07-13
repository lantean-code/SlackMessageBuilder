using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This is like a cross between a button and a select menu - when a user clicks on this overflow button, they will be presented with a list of options to choose from. Unlike the select menu, there is no typeahead field, and the button always appears with an ellipsis ("…") rather than customisable text.
    ///
    /// As such, it is usually used if you want a more compact layout than a select menu, or to supply a list of less visually important actions after a row of buttons.You can also specify simple URL links as overflow menu options, instead of actions.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#overflow">https://api.slack.com/reference/block-kit/block-elements#overflow</a>
    /// </summary>
    public class Overflow : TypedObject, ISectionElement, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Overflow"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of up to five option objects to display in the menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        public Overflow(
            string actionId,
            IEnumerable<Option> options,
            Confirm? confirmDialog = null) : base("overflow")
        {
            ActionId = actionId;
            Options = options;
            ConfirmDialog = confirmDialog;
        }

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("action_id")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("action_id")]
#endif
        public string ActionId { get; }

        /// <summary>
        /// An array of up to five option objects to display in the menu.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("options")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("options")]
#endif
        public IEnumerable<Option> Options { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("confirm")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("confirm")]
#endif
        public Confirm? ConfirmDialog { get; }
    }
}