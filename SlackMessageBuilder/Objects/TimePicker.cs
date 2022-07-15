using System;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An element which allows selection of a time of day.
    ///
    /// On desktop clients, this time picker will take the form of a dropdown list with free-text entry for precise choices. On mobile clients, the time picker will use native time picker UIs.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#timepicker">https://api.slack.com/reference/block-kit/block-elements#timepicker</a>
    /// </summary>
    public class TimePicker : TypedObject, ISectionElement, IActionsElement, IInputElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimePicker"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the timepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialTime">The initial time that is selected when the element is loaded. This should be in the format HH:mm, where HH is the 24-hour format of an hour (00 to 23) and mm is minutes with leading zeros (00 to 59), for example 22:25 for 10:25pm.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public TimePicker(
            string actionId,
            PlainText? placeholder = null,
            TimeSpan? initialTime = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base("timepicker")
        {
            Placeholder = placeholder;
            InitialTime = initialTime;
            ConfirmDialog = confirmDialog;
            FocusOnLoad = focusOnLoad;
            ActionId = actionId;
        }

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("action_id")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("action_id")]
#endif
        public string ActionId { get; }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines the placeholder text shown on the timepicker. Maximum length for the text in this field is 150 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("placeholder")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
#endif
        public PlainText? Placeholder { get; }

        /// <summary>
        /// The initial time that is selected when the element is loaded. This should be in the format HH:mm, where HH is the 24-hour format of an hour (00 to 23) and mm is minutes with leading zeros (00 to 59), for example 22:25 for 10:25pm.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_time")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_time")]
#endif
        public TimeSpan? InitialTime { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("confirm")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("confirm")]
#endif
        public Confirm? ConfirmDialog { get; }

        /// <summary>
        /// Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("focus_on_load")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("focus_on_load")]
#endif
        public bool? FocusOnLoad { get; }
    }
}