using SlackMessageBuilder.Builders;
using System;
using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="Attachment"/>s.
    /// </summary>
    public static class AttachmentBuilderExtensions
    {
        public static AttachmentBuilder WithBlocks(this AttachmentBuilder builder, Action<IBlocksBuilder> blockBuilderAction)
        {
            var blockBuilder = new BlocksBuilder();
            blockBuilderAction(blockBuilder);
            var blocks = blockBuilder.Build();
            return builder.WithBlocks(blocks);
        }

        public static AttachmentBuilder WithBlocks(this AttachmentBuilder builder, IEnumerable<IBlockElement> blocks)
        {
            builder.AddBlocks(blocks);
            return builder;
        }

        public static AttachmentBuilder WithText(this AttachmentBuilder builder, string text)
        {
            builder.SetText(text);

            return builder;
        }

        public static AttachmentBuilder WithMarkdown(this AttachmentBuilder builder, string markdownText)
        {
            builder.SetText(markdownText);
            builder.AddMarkdownIn("text");

            return builder;
        }
    }
}