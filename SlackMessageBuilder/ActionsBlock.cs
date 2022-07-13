using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A block that is used to hold interactive elements.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#actions">https://api.slack.com/reference/block-kit/blocks#actions</a>
    /// </summary>
    public class ActionsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBlock"/> class.
        /// </summary>
        /// <param name="elements">An array of interactive element objects - buttons, select menus, overflow menus, or date pickers. There is a maximum of 25 elements in each action block.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public ActionsBlock(
            IEnumerable<IActionsElement> elements,
            string? blockId = null) : base("actions", blockId)
        {
            Elements = elements;
        }

        /// <summary>
        /// An array of interactive element objects - buttons, select menus, overflow menus, or date pickers. There is a maximum of 25 elements in each action block.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("elements")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("elements")]
#endif
        public IEnumerable<IActionsElement> Elements { get; }
    }
}