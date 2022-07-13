using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="SlackMessage"/>s.
    /// </summary>
    public sealed class SlackMessageBuilder
    {
        private List<AttachmentBase>? _attachments;
        private List<IBlockElement>? _blocks;

        private string _text;
        private string? _channel = null;
        private bool? _isMarkdown;
        private string? _threadId = null;
        private bool _isApiMessage = false;
        private bool? _asUser = null;
        private string? _iconEmoji = null;
        private string? _iconUrl = null;
        private bool? _linkNames = null;
        private string? _metadata = null;
        private string? _parse = null;
        private bool? _replyBroadcast = null;
        private bool? _unfurlLinks = null;
        private bool? _unfurlMesage = null;
        private string? _username = null;

        /// <summary>
        /// Creates a new instance of the fluent message builder.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <returns></returns>
        public static SlackMessageBuilder Create(string text, bool? isMarkdown = null)
        {
            return new SlackMessageBuilder(text, isMarkdown);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackMessageBuilder"/> class.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        public SlackMessageBuilder(string text, bool? isMarkdown = null)
        {
            _text = text;
            _isMarkdown = isMarkdown;
        }

        internal void SetText(string text, bool? isMarkdown = null)
        {
            _text = text;
            _isMarkdown = isMarkdown;
        }

        internal void SetChannel(string channel)
        {
            _isApiMessage = true;
            _channel = channel;
        }

        internal void SetThread(string threadId)
        {
            _threadId = threadId;
        }

        internal void SetAsUser(bool asUser)
        {
            _asUser = asUser;
        }

        internal void SetIconEmoji(string iconEmoji)
        {
            _iconEmoji = iconEmoji;
        }

        internal void SetIconUrl(string iconUrl)
        {
            _iconUrl = iconUrl;
        }

        internal void SetMetadata(string metadata)
        {
            _metadata = metadata;
        }

        internal void SetLinknames(bool linkNames)
        {
            _linkNames = linkNames;
        }

        internal void SetParse(string parse)
        {
            _parse = parse;
        }

        internal void SetReplyBroadcast(bool replyBroadcast)
        {
            _replyBroadcast = replyBroadcast;
        }

        internal void SetUnfurlLinks(bool unfurlLinks)
        {
            _unfurlLinks = unfurlLinks;
        }

        internal void SetUnfurlMesage(bool unfurlMesage)
        {
            _unfurlMesage = unfurlMesage;
        }

        internal void SetUsername(string username)
        {
            _username = username;
        }

        internal void AddAttachment(AttachmentBase attachment)
        {
            _attachments ??= new List<AttachmentBase>();
            _attachments.Add(attachment);
        }

        internal void AddBlocks(IEnumerable<IBlockElement> slackBlocks)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.AddRange(slackBlocks);
        }

        internal void AddBlock(IBlockElement slackBlock)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.Add(slackBlock);
        }

        /// <summary>
        /// Builds a new Slack Message from the builder.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public SlackMessageBase Build()
        {
            SlackMessageBase slackMessage;
            if (_isApiMessage)
            {
                if (_channel is null)
                {
                    throw new InvalidOperationException("Channel is required to build a SlackMessage.");
                }
                slackMessage = new SlackApiMessage(
                    _channel,
                    _text,
                    _isMarkdown,
                    _blocks,
                    _attachments,
                    _threadId,
                    _asUser,
                    _iconEmoji,
                    _iconUrl,
                    _linkNames,
                    _metadata,
                    _parse,
                    _replyBroadcast,
                    _unfurlLinks,
                    _unfurlMesage,
                    _username);
            }
            else
            {
                slackMessage = new SlackMessage(
                    _text,
                    _isMarkdown,
                    _blocks,
                    _attachments,
                    _threadId);
            }

            return slackMessage;
        }
    }
}