using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// <a href="https://api.slack.com/reference/messaging/attachments">https://api.slack.com/reference/messaging/attachments</a>
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="blocks">An array of layout blocks in the same format as described in the building blocks guide.</param>
        /// <param name="color">Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)</param>
#pragma warning disable S4136 // Method overloads should be grouped together

        public Attachment(
#pragma warning restore S4136 // Method overloads should be grouped together
            IEnumerable<IBlockElement> blocks,
            string? color = null)
        {
            Color = color;
            Blocks = blocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="color"></param>
        protected Attachment(string? color)
        {
            Color = color;
        }

        /// <summary>
        /// An array of layout blocks in the same format as described in the building blocks guide.
        /// </summary>
        [JsonPropertyName("blocks")]
        public IEnumerable<IBlockElement>? Blocks { get; }

        /// <summary>
        /// Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; }
    }
}