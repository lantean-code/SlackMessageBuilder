using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public abstract class SectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionBlock"/> class.
        /// </summary>
        /// <param name="accessory">One of the available element objects.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        protected SectionBlock(
            ISectionElement? accessory,
            string? blockId) : base("section", blockId)
        {
            Accessory = accessory;
        }

        /// <summary>
        /// One of the available element objects.
        /// </summary>
        [JsonPropertyName("accessory")]
        public ISectionElement? Accessory { get; }
    }
}