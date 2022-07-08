using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class ExternalDataSelectBase : SelectMenu, ISectionElement, IInputElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDataSelectBase"/> class.
        /// </summary>
        /// <param name="isMultiSelect">Indicates whether the element will be a multi select.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        protected ExternalDataSelectBase(
            bool isMultiSelect,
            PlainText placeholder,
            string actionId,
            int? minQueryLength = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base($"{(isMultiSelect ? "multi_" : "")}external", placeholder, actionId, confirmDialog, focusOnLoad)
        {
            MinQueryLength = minQueryLength;
        }

        /// <summary>
        /// When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.
        /// </summary>
        [JsonPropertyName("min_query_length")]
        public int? MinQueryLength { get; }
    }
}