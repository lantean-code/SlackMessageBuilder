using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class StaticSelectBase : SelectMenu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticSelectBase"/> class.
        /// </summary>
        /// <param name="isMultiSelect">Indicates whether the element will be a multi select.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <exception cref="ArgumentException"></exception>
        protected StaticSelectBase(
            bool isMultiSelect,
            PlainText placeholder,
            string actionId,
            IEnumerable<Option>? options = null,
            IEnumerable<OptionsGroup>? optionGroups = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base($"{(isMultiSelect ? "multi_" : "")}static", placeholder, actionId, confirmDialog, focusOnLoad)
        {
            if (options is null && optionGroups is null)
            {
                throw new ArgumentException($"At least one of {nameof(options)} or {nameof(optionGroups)} must be provided.");
            }
            if (options is not null && optionGroups is not null)
            {
                throw new ArgumentException($"Only one of {nameof(options)} or {nameof(optionGroups)} should be provided.");
            }
            Options = options;
            OptionGroups = optionGroups;
        }

        /// <summary>
        /// An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<Option>? Options { get; }

        /// <summary>
        /// An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.
        /// </summary>
        [JsonPropertyName("option_groups")]
        public IEnumerable<OptionsGroup>? OptionGroups { get; }
    }
}