using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A section is one of the most flexible blocks available - it can be used as a simple text block, in combination with text fields, or side-by-side with any of the available block elements.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#section"></a>
    /// </summary>
    public class TextFieldsSectionBlock : SectionBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextFieldsSectionBlock"/> class.
        /// </summary>
        /// <param name="fields">An array of text objects. Any text objects included with fields will be rendered in a compact format that allows for 2 columns of side-by-side text. Maximum number of items is 10. Maximum length for the text in each item is 2000 characters.</param>
        /// <param name="accessory">One of the available element objects.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public TextFieldsSectionBlock(
            IEnumerable<PlainText> fields,
            ISectionElement? accessory = null,
            string? blockId = null) : base(accessory, blockId)
        {
            Fields = fields;
        }

        /// <summary>
        /// An array of text objects. Any text objects included with fields will be rendered in a compact format that allows for 2 columns of side-by-side text. Maximum number of items is 10. Maximum length for the text in each item is 2000 characters.
        /// </summary>
        [JsonPropertyName("fields")]
        public IEnumerable<PlainText> Fields { get; }
    }
}