using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A checkbox group that allows a user to choose multiple items from a list of possible options.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#checkboxes">https://api.slack.com/reference/block-kit/block-elements#checkboxes</a>
    /// </summary>
    public class Checkboxes : TypedObject, ISectionElement, IActionsElement, IInputElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkboxes"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public Checkboxes(
            string actionId,
            IEnumerable<Option> options,
            IEnumerable<Option>? initialOptions = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base("checkboxes")
        {
            ActionId = actionId;
            Options = options;
            InitialOptions = initialOptions;
            ConfirmDialog = confirmDialog;
            FocusOnLoad = focusOnLoad;
        }

        /// <summary>
        /// An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
        [JsonPropertyName("action_id")]
        public string ActionId { get; }

        /// <summary>
        /// An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<Option> Options { get; }

        /// <summary>
        /// An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.
        /// </summary>
        [JsonPropertyName("initial_options")]
        public IEnumerable<Option>? InitialOptions { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.
        /// </summary>
        [JsonPropertyName("confirm")]
        public Confirm? ConfirmDialog { get; }

        /// <summary>
        /// Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.
        /// </summary>
        [JsonPropertyName("focus_on_load")]
        public bool? FocusOnLoad { get; }
    }
}