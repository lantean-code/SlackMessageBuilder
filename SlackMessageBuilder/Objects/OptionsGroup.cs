﻿using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Provides a way to group options in a select menu or multi-select menu.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#option_group">https://api.slack.com/reference/block-kit/composition-objects#option_group</a>
    /// </summary>
    public class OptionsGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsGroup"/> class.
        /// </summary>
        /// <param name="label">A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects that belong to this specific group. Maximum of 100 items.</param>
        public OptionsGroup(PlainText label, IEnumerable<Option> options)
        {
            Label = label;
            Options = options;
        }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("label")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("label")]
#endif
        public PlainText Label { get; }

        /// <summary>
        /// An array of <see cref="Option"/> objects that belong to this specific group. Maximum of 100 items.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("options")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("options")]
#endif
        public IEnumerable<Option> Options { get; }
    }
}