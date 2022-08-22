using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="SlackMessageBase"/>s.
    /// </summary>
    public static class MessageBuilderExtensions
    {
        /// <summary>
        /// Sets the thread id. This will replace any existing value.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="threadId">The ID of another un-threaded message to reply to.</param>
        /// <param name="broadcast">Indicates whether reply should be made visible to everyone in the channel or conversation. Defaults to false.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> AsReply(this MessageBuilder<SlackApiMessage> builder, string threadId, bool? broadcast = null)
        {
            builder.ThreadId = threadId;
            builder.ReplyBroadcast = broadcast;
            return builder;
        }

        /// <summary>
        /// Disable unfurling of media content.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> DisableUnfurlMedia(this MessageBuilder<SlackApiMessage> builder)
        {
            builder.UnfurlMedia = false;
            return builder;
        }

        /// <summary>
        /// Enable unfurling of primarily text-based content
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> EnableUnfurlLinks(this MessageBuilder<SlackApiMessage> builder)
        {
            builder.UnfurlLinks = true;
            return builder;
        }

        /// <summary>
        /// Sets the channel. This will replace any existing value.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> ForChannel(this MessageBuilder<SlackApiMessage> builder, string channel)
        {
            builder.Channel = channel;
            return builder;
        }

        /// <summary>
        /// Adds an attachement to the message using the <see cref="AttachmentBuilder"/>. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachmentBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder<T> WithAttachment<T>(this MessageBuilder<T> builder, Action<AttachmentBuilder> attachmentBuilderAction) where T : SlackMessageBase
        {
            var attachmentBuilder = new AttachmentBuilder();
            attachmentBuilderAction(attachmentBuilder);
            var attachment = attachmentBuilder.Build();
            return builder.WithAttachment(attachment);
        }

        /// <summary>
        /// Adds an attachment to the message. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachment"></param>
        /// <returns></returns>
        public static MessageBuilder<T> WithAttachment<T>(this MessageBuilder<T> builder, AttachmentBase attachment) where T : SlackMessageBase
        {
            builder.AddAttachment(attachment);
            return builder;
        }

        /// <summary>
        /// Adds blocks to the message using the <see cref="BlocksBuilder"/>. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blocksBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder<T> WithBlocks<T>(this MessageBuilder<T> builder, Action<IBlocksBuilder> blocksBuilderAction) where T : SlackMessageBase
        {
            var blocksBuilder = new BlocksBuilder();
            blocksBuilderAction(blocksBuilder);
            var blocks = blocksBuilder.Build();
            return builder.WithBlocks(blocks);
        }

        /// <summary>
        /// Adds blocks to the message. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blocks"></param>
        /// <returns></returns>
        public static MessageBuilder<T> WithBlocks<T>(this MessageBuilder<T> builder, IEnumerable<IBlockElement> blocks) where T : SlackMessageBase
        {
            builder.AddBlocks(blocks);
            return builder;
        }

        /// <summary>
        /// Emoji to use as the icon for this message.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="iconEmoji">Ses emoji to use as the icon for this message.e. as_user will be set to false and icon_url will be set to null.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithIconEmoji(this MessageBuilder<SlackApiMessage> builder, string iconEmoji)
        {
            builder.IconEmoji = iconEmoji;
            return builder;
        }

        /// <summary>
        /// Emoji to use as the icon for this message.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="iconUrl">Ses emoji to use as the icon for this message.e. as_user will be set to false and icon_url will be set to null.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithIconUrl(this MessageBuilder<SlackApiMessage> builder, string iconUrl)
        {
            builder.IconUrl = iconUrl;
            return builder;
        }

        /// <summary>
        /// Metadata you post to Slack is accessible to any app or user who is a member of that workspace.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="eventType">Event type</param>
        /// <param name="eventPayload">Event payload</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithMetadata(this MessageBuilder<SlackApiMessage> builder, string eventType, string eventPayload)
        {
            builder.Metadata = new Metadata(eventType, eventPayload);
            return builder;
        }

        /// <summary>
        /// Change how messages are treated.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="parseOptions">Options to configure text parsing.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithParse(this MessageBuilder<SlackApiMessage> builder, ParseOptions parseOptions)
        {
            builder.Parse = parseOptions.ToValue();
            return builder;
        }

        /// <summary>
        /// Set your bot's user name.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="username">Set your bot's user name. as_user will be set to false.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithUsername(this MessageBuilder<SlackApiMessage> builder, string username)
        {
            builder.Username = username;
            return builder;
        }

        /// <summary>
        /// Set your bot's user name.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="postAt">The date for which the message should be scheduled.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithScheduledDate(this MessageBuilder<SlackApiMessage> builder, int postAt)
        {
            builder.PostAt = postAt;
            return builder;
        }
    }
}