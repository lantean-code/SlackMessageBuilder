using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class StaticSelectBase : SelectMenu, ISectionElement, IActionsElement, IInputElement
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="isMultiSelect"></param>
        /// <param name="placeholder"></param>
        /// <param name="actionId"></param>
        /// <param name="options"></param>
        /// <param name="optionGroups"></param>
        /// <param name="confirm"></param>
        /// <param name="focusOnLoad"></param>
        /// <exception cref="ArgumentException"></exception>
        protected StaticSelectBase(
            bool isMultiSelect,
            PlainText placeholder,
            string actionId,
            IEnumerable<Option>? options = null,
            IEnumerable<OptionsGroup>? optionGroups = null,
            Confirm? confirm = null,
            bool? focusOnLoad = null) : base($"{(isMultiSelect ? "multi_" : "")}static", placeholder, actionId, confirm, focusOnLoad)
        {
            if (options is null && optionGroups is null)
            {
                throw new ArgumentException($"At least one of {nameof(options)} or {nameof(optionGroups)} must be provided.");
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
        /// An array of <see cref="OptionGroups"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.
        /// </summary>
        [JsonPropertyName("option_groups")]
        public IEnumerable<OptionsGroup>? OptionGroups { get; }
    }
}