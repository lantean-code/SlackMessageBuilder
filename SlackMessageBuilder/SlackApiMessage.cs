using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    public class SlackApiMessage : SlackMessage
    {
        public SlackApiMessage(
            string channel,
            string text,
            bool? isMarkdown = null,
            IEnumerable<IBlockElement>? blocks = null,
            IEnumerable<Attachment>? attachments = null,
            string? threadId = null,
            bool? asUser = null,
            string? iconEmoji = null,
            string? iconUrl = null,
            bool? linkNames = null,
            string? metadata = null,
            string? parse = null,
            bool? replyBroadcast = null,
            bool? unfurlLinks = null,
            bool? unfurlMedia = null,
            string? username = null) : base(text, isMarkdown, blocks, attachments, threadId)
        {
            Channel = channel;
            AsUser = asUser;
            IconEmoji = iconEmoji;
            IconUrl = iconUrl;
            LinkNames = linkNames;
            Metadata = metadata;
            Parse = parse;
            ReplyBroadcast = replyBroadcast;
            UnfurlLinks = unfurlLinks;
            UnfurlMedia = unfurlMedia;
            Username = username;
        }

        /// <summary>
        /// Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name.
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; }

        [JsonPropertyName("as_user")]
        public bool? AsUser { get; }

        [JsonPropertyName("icon_emoji")]
        public string? IconEmoji { get; }

        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; }

        [JsonPropertyName("link_names")]
        public bool? LinkNames { get; }

        [JsonPropertyName("metadata")]
        public string? Metadata { get; }

        [JsonPropertyName("parse")]
        public string? Parse { get; }

        [JsonPropertyName("reply_broadcast")]
        public bool? ReplyBroadcast { get; }

        /// <summary>
        /// Pass true to enable unfurling of primarily text-based content.
        /// </summary>
        [JsonPropertyName("unfurl_links")]
        public bool? UnfurlLinks { get; internal set; }

        /// <summary>
        /// Pass false to disable unfurling of media content.
        /// </summary>
        [JsonPropertyName("unfurl_media")]
        public bool? UnfurlMedia { get; internal set; }

        [JsonPropertyName("username")]
        public string? Username { get; }
    }
}