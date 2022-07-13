using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// <a href="https://api.slack.com/reference/messaging/attachments">https://api.slack.com/reference/messaging/attachments</a>
    /// </summary>
    public class Attachment : AttachmentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="blocks">An array of layout blocks in the same format as described in the building blocks guide.</param>
        /// <param name="color">Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)</param>
        public Attachment(
            IEnumerable<IBlockElement> blocks,
            string? color = null) : base(color)
        {
            Blocks = blocks;
        }

        /// <summary>
        /// An array of layout blocks in the same format as described in the building blocks guide.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("blocks")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("blocks")]
#endif
        public IEnumerable<IBlockElement>? Blocks { get; }
    }
}