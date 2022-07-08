using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
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
        /// <param name="placeholder"></param>
        /// <param name="actionId"></param>
        /// <param name="options"></param>
        /// <param name="optionGroups"></param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="confirm"></param>
        /// <param name="maxSelectedItems"></param>
        /// <param name="focusOnLoad"></param>
        public StaticMultiSelect(
            PlainText placeholder,
            string actionId,
            IEnumerable<Option>? options = null,
            IEnumerable<OptionsGroup>? optionGroups = null,
            IEnumerable<Option>? initialOptions = null,
            int? maxSelectedItems = null,
            Confirm? confirm = null,
            bool? focusOnLoad = null) : base(true, placeholder, actionId, options, optionGroups, confirm, focusOnLoad)
        {
            InitialOptions = initialOptions;
            MaxSelectedItems = maxSelectedItems;
        }

        /// <summary>
        /// An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.
        /// </summary>
        [JsonPropertyName("initial_options")]
        public IEnumerable<Option>? InitialOptions { get; }

        /// <summary>
        /// Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.
        /// </summary>
        [JsonPropertyName("max_selected_items")]
        public int? MaxSelectedItems { get; }
    }
}