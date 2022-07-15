using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// This is the simplest form of multi select menu, with a static list of options passed in when defining the element.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#static_multi_select">https://api.slack.com/reference/block-kit/block-elements#static_multi_select</a>
    /// </summary>
    public class StaticMultiSelect : StaticSelectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticMultiSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public StaticMultiSelect(
            PlainText placeholder,
            string actionId,
            IEnumerable<Option>? options = null,
            IEnumerable<OptionsGroup>? optionGroups = null,
            IEnumerable<Option>? initialOptions = null,
            int? maxSelectedItems = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(true, placeholder, actionId, options, optionGroups, confirmDialog, focusOnLoad)
        {
            InitialOptions = initialOptions;
            MaxSelectedItems = maxSelectedItems;
        }

        /// <summary>
        /// An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_options")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_options")]
#endif
        public IEnumerable<Option>? InitialOptions { get; }

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