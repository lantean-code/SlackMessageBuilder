using System;
using System.Collections.Generic;

namespace SlackMessageBuilder.Builders
{
    /// <summary>
    /// Fluent builder for <see cref="SlackMessage"/>s.
    /// </summary>
    public class MessageBuilder
    {
        private List<Attachment>? _attachments;
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

        internal MessageBuilder(string text, bool? isMarkdown = null)
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

        internal void AddAttachment(Attachment attachment)
        {
            _attachments ??= new List<Attachment>();
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
        public SlackMessage Build()
        {
            SlackMessage slackMessage;
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