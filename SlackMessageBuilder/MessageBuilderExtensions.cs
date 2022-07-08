using SlackMessageBuilder.Builders;
using System;
using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="SlackMessage"/>s.
    /// </summary>
    public static class MessageBuilderExtensions
    {
        /// <summary>
        /// Sets the thread id. Output: sets `thread_ts` property to the value.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="threadId"></param>
        /// <returns></returns>
        public static MessageBuilder AsReply(this MessageBuilder builder, string threadId)
        {
            builder.SetThread(threadId);

            return builder;
        }

        /// <summary>
        /// Sets the text of the message. Output: sets `text` property to the value and `mrkdwn` to 'false'.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static MessageBuilder WithText(this MessageBuilder builder, string text)
        {
            builder.SetText(text, false);

            return builder;
        }

        /// <summary>
        /// Sets the text of the message. Output: sets `text` property to the value and `mrkdwn` to 'true' on the JSON.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="markdownText"></param>
        /// <returns></returns>
        public static MessageBuilder WithMarkdown(this MessageBuilder builder, string markdownText)
        {
            builder.SetText(markdownText, true);

            return builder;
        }

        /// <summary>
        /// Adds an attachement to the message using the <see cref="AttachmentBuilder"/>.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="attachmentBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder WithAttachment(this MessageBuilder builder, Action<AttachmentBuilder> attachmentBuilderAction)
        {
            var attachmentBuilder = new AttachmentBuilder();
            attachmentBuilderAction(attachmentBuilder);
            var attachment = attachmentBuilder.Build();
            return builder.WithAttachment(attachment);
        }

        /// <summary>
        /// Adds an attachment to the message.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="slackAttachment"></param>
        /// <returns></returns>
        public static MessageBuilder WithAttachment(this MessageBuilder builder, Attachment slackAttachment)
        {
            builder.AddAttachment(slackAttachment);
            return builder;
        }

        /// <summary>
        /// Adds blocks to the message using the <see cref="BlocksBuilder"/>.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blocksBuilderAction"></param>
        /// <returns></returns>
        public static MessageBuilder WithBlocks(this MessageBuilder builder, Action<IBlocksBuilder> blocksBuilderAction)
        {
            var blocksBuilder = new BlocksBuilder();
            blocksBuilderAction(blocksBuilder);
            var blocks = blocksBuilder.Build();
            return builder.WithBlocks(blocks);
        }

        public static MessageBuilder WithBlocks(this MessageBuilder builder, IEnumerable<IBlockElement> blocks)
        {
            builder.AddBlocks(blocks);
            return builder;
        }
    }
}