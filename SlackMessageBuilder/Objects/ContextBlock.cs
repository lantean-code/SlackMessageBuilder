using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Displays message context, which can include both images and text.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#context">https://api.slack.com/reference/block-kit/blocks#context</a>
    /// </summary>
    public class ContextBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextBlock"/> class.
        /// </summary>
        /// <param name="elements">An array of image elements and text objects. Maximum number of items is 10.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public ContextBlock(
            IEnumerable<IContextElement> elements,
            string? blockId = null) : base("context", blockId)
        {
            Elements = elements;
        }

        /// <summary>
        /// An array of image elements and text objects. Maximum number of items is 10.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("elements")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("elements")]
#endif
        public IEnumerable<IContextElement> Elements { get; }
    }
}