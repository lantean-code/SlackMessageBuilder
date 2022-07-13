using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public class SlackApiMessage : SlackMessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackApiMessage"/> class.
        /// </summary>
        /// <param name="channel">Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name.</param>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <param name="blocks">An array of layout blocks in the same format as described in the building blocks guide.</param>
        /// <param name="attachments">An array of legacy secondary attachments. We recommend you use blocks instead.</param>
        /// <param name="threadId">The ID of another un-threaded message to reply to.</param>
        /// <param name="asUser">Set to true to post the message as the authed user, instead of as a bot. Defaults to false. Cannot be used by new Slack apps. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.</param>
        /// <param name="iconEmoji">Emoji to use as the icon for this message. Overrides icon_url. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.</param>
        /// <param name="iconUrl">URL to an image to use as the icon for this message. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.</param>
        /// <param name="linkNames">Find and link user groups. No longer supports linking individual users; use syntax shown in <a href="https://api.slack.com/reference/surfaces/formatting#mentioning-users">Mentioning Users</a> instead.</param>
        /// <param name="metadata">JSON object with event_type and event_payload fields, presented as a URL-encoded string. Metadata you post to Slack is accessible to any app or user who is a member of that workspace.</param>
        /// <param name="parse">Change how messages are treated. See <a href="https://api.slack.com/methods/chat.postMessage#formatting">https://api.slack.com/methods/chat.postMessage#formatting</a>.</param>
        /// <param name="replyBroadcast">Used in conjunction with thread_ts and indicates whether reply should be made visible to everyone in the channel or conversation. Defaults to false.</param>
        /// <param name="unfurlLinks">Pass true to enable unfurling of primarily text-based content.</param>
        /// <param name="unfurlMedia">Pass false to disable unfurling of media content.</param>
        /// <param name="username">Set your bot's user name. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.</param>
        public SlackApiMessage(
            string channel,
            string text,
            bool? isMarkdown = null,
            IEnumerable<IBlockElement>? blocks = null,
            IEnumerable<AttachmentBase>? attachments = null,
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

        /// <summary>
        /// Set to true to post the message as the authed user, instead of as a bot. Defaults to false. Cannot be used by new Slack apps. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.
        /// </summary>
        [JsonPropertyName("as_user")]
        public bool? AsUser { get; }

        /// <summary>
        /// Emoji to use as the icon for this message. Overrides icon_url. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.
        /// </summary>
        [JsonPropertyName("icon_emoji")]
        public string? IconEmoji { get; }

        /// <summary>
        /// URL to an image to use as the icon for this message. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; }

        /// <summary>
        /// Find and link user groups. No longer supports linking individual users; use syntax shown in <a href="https://api.slack.com/reference/surfaces/formatting#mentioning-users">Mentioning Users</a> instead.
        /// </summary>
        [JsonPropertyName("link_names")]
        public bool? LinkNames { get; }

        /// <summary>
        /// JSON object with event_type and event_payload fields, presented as a URL-encoded string. Metadata you post to Slack is accessible to any app or user who is a member of that workspace.
        /// </summary>
        [JsonPropertyName("metadata")]
        public string? Metadata { get; }

        /// <summary>
        /// Change how messages are treated. See <a href="https://api.slack.com/methods/chat.postMessage#formatting">https://api.slack.com/methods/chat.postMessage#formatting</a>.
        /// </summary>
        [JsonPropertyName("parse")]
        public string? Parse { get; }

        /// <summary>
        /// Used in conjunction with thread_ts and indicates whether reply should be made visible to everyone in the channel or conversation. Defaults to false.
        /// </summary>
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

        /// <summary>
        /// Set your bot's user name. Must be used in conjunction with as_user set to false, otherwise ignored. See <a href="https://api.slack.com/methods/chat.postMessage#authorship">authorship</a> below.
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; }
    }
}