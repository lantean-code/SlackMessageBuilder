namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// This select menu will load its options from an external data source, allowing for a dynamic list of options.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#external_select">https://api.slack.com/reference/block-kit/block-elements#external_select</a>
    /// </summary>
    public class ExternalDataSelect : ExternalDataSelectBase, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDataSelect"/> class.
        /// </summary>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within the options or option_groups loaded from the external data source. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public ExternalDataSelect(
            PlainText placeholder,
            string actionId,
            int? minQueryLength = null,
            Option? initialOption = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base(true, placeholder, actionId, minQueryLength, confirmDialog, focusOnLoad)
        {
            InitialOption = initialOption;
        }

        /// <summary>
        /// A single option that exactly matches one of the options within the options or option_groups loaded from the external data source. This option will be selected when the menu initially loads.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_option")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_option")]
#endif
        public Option? InitialOption { get; }
    }
}