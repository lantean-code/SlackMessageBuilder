using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This is the simplest form of select menu, with a static list of options passed in when defining the element.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#static_select">https://api.slack.com/reference/block-kit/block-elements#static_select</a>
    /// </summary>
    public class StaticSelect : StaticSelectBase, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance fo the <see cref="StaticSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.</param>
        /// <param name="initalOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public StaticSelect(
            PlainText placeholder,
            string actionId,
            IEnumerable<Option>? options = null,
            IEnumerable<OptionsGroup>? optionGroups = null,
            Option? initalOption = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(false, placeholder, actionId, options, optionGroups, confirmDialog, focusOnLoad)
        {
            InitalOption = initalOption;
        }

        /// <summary>
        /// A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.
        /// </summary>
        [JsonPropertyName("initial_option")]
        public Option? InitalOption { get; }
    }
}