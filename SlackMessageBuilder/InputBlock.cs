using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A block that collects information from users - it can hold a plain-text input element, a checkbox element, a radio button element, a select menu element, a multi-select menu element, or a datepicker.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#input">https://api.slack.com/reference/block-kit/blocks#input</a>
    /// </summary>
    public class InputBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputBlock"/> class.
        /// </summary>
        /// <param name="label">A label that appears above an input element in the form of a text object that must have type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="element">A <see cref="PlainTextInput"/> element, a <see cref="Checkboxes"/> element, a <see cref="RadioButtons"/> element, a <see cref="SelectMenu"/> element, a <see cref="DatePicker"/> or a <see cref="TimePicker"/>.</param>
        /// <param name="dispatchAction">A boolean that indicates whether or not the use of elements in this block should dispatch a block_actions payload. Defaults to false.</param>
        /// <param name="hint">An optional hint that appears below an input element in a lighter grey. It must be a text object with a type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="optional">A boolean that indicates whether the input element may be empty when a user submits the modal. Defaults to false.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public InputBlock(
            PlainText label,
            IInputElement element,
            bool? dispatchAction = null,
            PlainText? hint = null,
            bool? optional = null,
            string? blockId = null) : base("input", blockId)
        {
            Label = label;
            Element = element;
            DispatchAction = dispatchAction;
            Hint = hint;
            Optional = optional;
        }

        /// <summary>
        /// A label that appears above an input element in the form of a text object that must have type of plain_text. Maximum length for the text in this field is 2000 characters.
        /// </summary>
        [JsonPropertyName("label")]
        public PlainText Label { get; }

        /// <summary>
        /// A <see cref="PlainTextInput"/> element, a <see cref="Checkboxes"/> element, a <see cref="RadioButtons"/> element, a <see cref="SelectMenu"/> element, a <see cref="DatePicker"/> or a <see cref="TimePicker"/>.
        /// </summary>
        [JsonPropertyName("element")]
        public IInputElement Element { get; }

        /// <summary>
        /// A boolean that indicates whether or not the use of elements in this block should dispatch a block_actions payload. Defaults to false.
        /// </summary>
        [JsonPropertyName("dispatch_action")]
        public bool? DispatchAction { get; }

        /// <summary>
        /// An optional hint that appears below an input element in a lighter grey. It must be a text object with a type of plain_text. Maximum length for the text in this field is 2000 characters.
        /// </summary>
        [JsonPropertyName("hint")]
        public PlainText? Hint { get; }

        /// <summary>
        /// A boolean that indicates whether the input element may be empty when a user submits the modal. Defaults to false.
        /// </summary>
        [JsonPropertyName("optional")]
        public bool? Optional { get; }
    }
}