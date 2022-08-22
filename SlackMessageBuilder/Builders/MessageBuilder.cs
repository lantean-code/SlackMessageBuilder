using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessageBuilder<T> where T : SlackMessageBase
    {
        private bool? _asUser;
        private List<AttachmentBase>? _attachments;
        private List<IBlockElement>? _blocks;
        private string? _channel;
        private string? _iconEmoji;
        private string? _iconUrl;
        private string? _username;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackMessageBuilder"/> class.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        internal MessageBuilder(string text, bool? isMarkdown = null)
        {
            Text = text;
            IsMarkdown = isMarkdown;
        }

        internal bool? AsUser
        {
            get { return _asUser; }
            set
            {
                if (value ?? false)
                {
                    _username = null;
                }
                _asUser = value;
            }
        }

        internal string? Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                if (value == "")
                {
                    value = null;
                }
                _channel = value;
            }
        }

        internal string? IconEmoji
        {
            get { return _iconEmoji; }
            set
            {
                _asUser = false;
                _iconUrl = null;
                _iconEmoji = value;
            }
        }

        internal string? IconUrl
        {
            get { return _iconUrl; }
            set
            {
                _asUser = false;
                _iconEmoji = null;
                _iconUrl = value;
            }
        }

        internal bool? IsMarkdown { get; set; }

        internal bool? LinkNames { get; set; }

        internal Metadata? Metadata { get; set; }

        internal string? Parse { get; set; }

        internal bool? ReplyBroadcast { get; set; }

        internal string Text { get; set; }

        internal string? ThreadId { get; set; }

        internal bool? UnfurlLinks { get; set; }

        internal bool? UnfurlMedia { get; set; }

        internal string? Username
        {
            get { return _username; }
            set
            {
                _asUser = false;
                _username = value;
            }
        }

        internal int? PostAt { get; set; }

        private bool IsApiMessage
        {
            get { return _channel is not null; }
        }

        internal Func<IMessageBuilderContext, T>? InstanceFactory { get; set; }

        /// <summary>
        /// Builds a new Slack Message from the builder.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Build()
        {
            var type = typeof(T);
            SlackMessageBase message;
            if (type == typeof(SlackApiMessage))
            {
                if (!IsApiMessage)
                {
                    throw new InvalidOperationException($"Unable to build api message as {typeof(T).Name}.");
                }
                if (Channel is null)
                {
                    throw new InvalidOperationException("Channel is required to build a SlackMessage.");
                }

                message = new SlackApiMessage(
                    Channel,
                    Text,
                    IsMarkdown,
                    _blocks,
                    _attachments,
                    ThreadId,
                    AsUser,
                    IconEmoji,
                    IconUrl,
                    LinkNames,
                    Metadata,
                    Parse,
                    ReplyBroadcast,
                    UnfurlLinks,
                    UnfurlMedia,
                    Username,
                    PostAt);

                return (T)message;
            }

            if (InstanceFactory is null)
            {
                throw new InvalidOperationException($"Unable to construct instance of {type.Name}. InstanceFactory is null.");
            }

            var context = new MessageBuilderContext(Text, IsMarkdown, _attachments, _blocks, ThreadId);

            message = InstanceFactory(context);

            return (T)message;
        }

        internal void AddAttachment(AttachmentBase attachment)
        {
            _attachments ??= new List<AttachmentBase>();
            _attachments.Add(attachment);
        }

        internal void AddBlock(IBlockElement slackBlock)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.Add(slackBlock);
        }

        internal void AddBlocks(IEnumerable<IBlockElement> slackBlocks)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.AddRange(slackBlocks);
        }
    }
}