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
        /// <param name="threadId"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackMessage> AsReply(this MessageBuilder<SlackMessage> builder, string threadId)
        {
            builder.SetThread(threadId);

            return builder;
        }

        /// <summary>
        /// Sets the thread id. This will replace any existing value.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="threadId"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> AsReply(this MessageBuilder<SlackApiMessage> builder, string threadId)
        {
            builder.SetThread(threadId);

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
            builder.SetChannel(channel);

            return builder;
        }

        /// <summary>
        /// Adds an attachement to the message using the <see cref="AttachmentBuilder"/>. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachmentBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackMessage> WithAttachment(this MessageBuilder<SlackMessage> builder, Action<AttachmentBuilder> attachmentBuilderAction)
        {
            var attachmentBuilder = new AttachmentBuilder();
            attachmentBuilderAction(attachmentBuilder);
            var attachment = attachmentBuilder.Build();
            return builder.WithAttachment(attachment);
        }

        /// <summary>
        /// Adds an attachement to the message using the <see cref="AttachmentBuilder"/>. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachmentBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithAttachment(this MessageBuilder<SlackApiMessage> builder, Action<AttachmentBuilder> attachmentBuilderAction)
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
        public static MessageBuilder<SlackMessage> WithAttachment(this MessageBuilder<SlackMessage> builder, AttachmentBase attachment)
        {
            builder.AddAttachment(attachment);
            return builder;
        }

        /// <summary>
        /// Adds an attachment to the message. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachment"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithAttachment(this MessageBuilder<SlackApiMessage> builder, AttachmentBase attachment)
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
        public static MessageBuilder<SlackMessage> WithBlocks(this MessageBuilder<SlackMessage> builder, Action<IBlocksBuilder> blocksBuilderAction)
        {
            var blocksBuilder = new BlocksBuilder();
            blocksBuilderAction(blocksBuilder);
            var blocks = blocksBuilder.Build();
            return builder.WithBlocks(blocks);
        }

        /// <summary>
        /// Adds blocks to the message using the <see cref="BlocksBuilder"/>. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blocksBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithBlocks(this MessageBuilder<SlackApiMessage> builder, Action<IBlocksBuilder> blocksBuilderAction)
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
        public static MessageBuilder<SlackMessage> WithBlocks(this MessageBuilder<SlackMessage> builder, IEnumerable<IBlockElement> blocks)
        {
            builder.AddBlocks(blocks);
            return builder;
        }

        /// <summary>
        /// Adds blocks to the message. This method is cumulative and can be called multiple times.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blocks"></param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> WithBlocks(this MessageBuilder<SlackApiMessage> builder, IEnumerable<IBlockElement> blocks)
        {
            builder.AddBlocks(blocks);
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
            builder.SetAsUser(false);
            builder.SetUsername(username);
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
            builder.SetAsUser(false);
            builder.SetIconUrl(null);
            builder.SetIconEmoji(iconEmoji);
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
            builder.SetAsUser(false);
            builder.SetIconEmoji(null);
            builder.SetIconUrl(iconUrl);
            return builder;
        }
    }
}