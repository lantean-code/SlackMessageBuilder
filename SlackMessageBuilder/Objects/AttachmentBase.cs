using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// <a href="https://api.slack.com/reference/messaging/attachments">https://api.slack.com/reference/messaging/attachments</a>
    /// </summary>
    public abstract class AttachmentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentBase"/> class.
        /// </summary>
        /// <param name="color">Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)</param>
        protected AttachmentBase(string? color)
        {
            Color = color;
        }

        /// <summary>
        /// Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("color")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("color")]
#endif
        public string? Color { get; }
    }
}