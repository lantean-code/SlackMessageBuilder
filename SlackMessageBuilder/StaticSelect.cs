using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// This is the simplest form of select menu, with a static list of options passed in when defining the element.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#static_select">https://api.slack.com/reference/block-kit/block-elements#static_select</a>
    /// </summary>
    public class StaticSelect : StaticSelectBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="actionId"></param>
        /// <param name="options"></param>
        /// <param name="optionGroups"></param>
        /// <param name="initalOption"></param>
        /// <param name="confirmDialog"></param>
        /// <param name="focusOnLoad"></param>
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