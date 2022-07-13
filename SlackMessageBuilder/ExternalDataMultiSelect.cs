using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This menu will load its options from an external data source, allowing for a dynamic list of options.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#external_multi_select">https://api.slack.com/reference/block-kit/block-elements#external_multi_select</a>
    /// </summary>
    public class ExternalDataMultiSelect : ExternalDataSelectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDataMultiSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public ExternalDataMultiSelect(
            PlainText placeholder,
            string actionId,
            int? minQueryLength = null,
            IEnumerable<Option>? initialOptions = null,
            int? maxSelectedItems = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(true, placeholder, actionId, minQueryLength, confirmDialog, focusOnLoad)
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