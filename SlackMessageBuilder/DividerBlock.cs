namespace SlackMessageBuilder
{
    /// <summary>
    /// A content divider, like an &gt;hr&lt;, to split up different blocks inside of a message. The divider block is nice and neat, requiring only a type.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#divider">https://api.slack.com/reference/block-kit/blocks#divider</a>
    /// </summary>
    public class DividerBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DividerBlock"/> class.
        /// </summary>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public DividerBlock(string? blockId = null) : base("divider", blockId)
        {
        }
    }
}