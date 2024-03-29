﻿using System;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An element which lets users easily select a date from a calendar style UI.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#datepicker">https://api.slack.com/reference/block-kit/block-elements#datepicker</a>
    /// </summary>
    public class DatePicker : TypedObject, ISectionElement, IActionsElement, IInputElement
    {
        /// <summary>
        /// Initilizes a new instance of the <see cref="DatePicker"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the datepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialDate">The initial date that is selected when the element is loaded. This should be in the format YYYY-MM-DD.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a date is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public DatePicker(
            string actionId,
            PlainText? placeholder = null,
            DateTime? initialDate = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base("datepicker")
        {
            ActionId = actionId;
            Placeholder = placeholder;
            InitialDate = initialDate;
            ConfirmDialog = confirmDialog;
            FocusOnLoad = focusOnLoad;
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
        /// A <see cref="PlainText"/> object that defines the placeholder text shown on the datepicker. Maximum length for the text in this field is 150 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("placeholder")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
#endif
        public PlainText? Placeholder { get; }

        /// <summary>
        /// The initial date that is selected when the element is loaded. This should be in the format YYYY-MM-DD.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("initial_date")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("initial_date")]
#endif
        public DateTime? InitialDate { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a date is selected.
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