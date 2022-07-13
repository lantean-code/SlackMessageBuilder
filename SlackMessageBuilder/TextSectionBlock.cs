
namespace SlackMessageBuilder
{
    /// <summary>
    /// A section is one of the most flexible blocks available - it can be used as a simple text block, in combination with text fields, or side-by-side with any of the available block elements.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#section"></a>
    /// </summary>
    public class TextSectionBlock : SectionBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextSectionBlock"/> class.
        /// </summary>
        /// <param name="text">The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.</param>
        /// <param name="accessory">One of the available element objects.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public TextSectionBlock(
            TextObject text,
            ISectionElement? accessory = null,
            string? blockId = null) : base(accessory, blockId)
        {
            Text = text;
        }

        /// <summary>
        /// The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public TextObject Text { get; }
    }
}