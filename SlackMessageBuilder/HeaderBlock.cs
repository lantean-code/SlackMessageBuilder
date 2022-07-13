
namespace SlackMessageBuilder
{
    /// <summary>
    /// A header is a plain-text block that displays in a larger, bold font. Use it to delineate between different groups of content in your app's surfaces.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#header">https://api.slack.com/reference/block-kit/blocks#header</a>
    /// </summary>
    public class HeaderBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderBlock"/> class.
        /// </summary>
        /// <param name="headerText">The text for the block, in the form of a plain_text text object. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public HeaderBlock(
            PlainText headerText,
            string? blockId = null) : base("header", blockId)
        {
            Text = headerText;
        }

        /// <summary>
        /// The text for the block, in the form of a plain_text text object. Maximum length for the text in this field is 150 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public PlainText Text { get; set; }
    }
}