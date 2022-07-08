using SlackMessageBuilder.Builders;
using System;
using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="Block"/>s.
    /// </summary>
    public static class BlockBuilderExtensions
    {
        /// <summary>
        /// Adds an image block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public static IBlocksBuilder AddImageBlock(this IBlocksBuilder builder, ImageBlock image)
        {
            return builder.AddBlock(image);
        }

        /// <summary>
        /// Adds an image block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="url">The URL of the image to be displayed.</param>
        /// <param name="altText">A plain-text summary of the image. This should not contain any markup. Maximum length for this field is 2000 characters.</param>
        /// <param name="title">An optional title for the image in the form of a text object that can only be of type: plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddImageBlock(this IBlocksBuilder builder, string url, string altText = "", string? title = null, string? blockId = null)
        {
            return builder.AddImageBlock(new ImageBlock(url, altText, title is null ? null : new PlainText(title), blockId));
        }

        public static IBlocksBuilder AddHeaderBlock(this IBlocksBuilder builder, HeaderBlock header)
        {
            return builder.AddBlock(header);
        }

        public static IBlocksBuilder AddHeaderBlock(this IBlocksBuilder builder, string headerText)
        {
            return builder.AddHeaderBlock(new HeaderBlock(new PlainText(headerText)));
        }

        public static IBlocksBuilder AddDividerBlock(this IBlocksBuilder builder, DividerBlock divider)
        {
            return builder.AddBlock(divider);
        }

        public static IBlocksBuilder AddDividerBlock(this IBlocksBuilder builder)
        {
            return builder.AddDividerBlock(new DividerBlock());
        }

        public static IBlocksBuilder AddContextBlock(this IBlocksBuilder builder, IEnumerable<IContextElement> elements)
        {
            return builder.AddBlock(new ContextBlock(elements));
        }

        public static IBlocksBuilder AddContextBlock(this IBlocksBuilder builder, Action<SlackContextBuilder> contextBuilderAction)
        {
            var contextBuilder = new SlackContextBuilder();
            contextBuilderAction(contextBuilder);
            var elements = contextBuilder.Build();
            return builder.AddContextBlock(elements);
        }

        public static IBlocksBuilder AddActionsBlock(this IBlocksBuilder builder, IEnumerable<IActionsElement> elements)
        {
            return builder.AddBlock(new ActionsBlock(elements));
        }

        public static IBlocksBuilder AddActionsBlock(this IBlocksBuilder builder, Action<IElementsBuilder<IActionsElement>> actionsBuilderAction)
        {
            var actionsBuilder = new ActionsBuilder();
            actionsBuilderAction(actionsBuilder);
            var elements = actionsBuilder.Build();
            return builder.AddActionsBlock(elements);
        }

        public static IBlocksBuilder AddInputBlock(this IBlocksBuilder builder, InputBlock inputBlock)
        {
            return builder.AddBlock(inputBlock);
        }

        public static IBlocksBuilder AddInputBlock(this IBlocksBuilder builder, string label, Func<IElementBuilder<IInputElement>, IInputElement> inputBuilderAction)
        {
            var inputBuilder = new SlackInputBuilder();
            var element = inputBuilderAction(inputBuilder);
            return builder.AddInputBlock(new InputBlock(new PlainText(label), element));
        }

        public static IBlocksBuilder AddSectionBlock(this IBlocksBuilder builder, SectionBlock inputBlock)
        {
            return builder.AddBlock(inputBlock);
        }

        public static IBlocksBuilder AddSectionBlock(this IBlocksBuilder builder, TextObject label, Func<IElementBuilder<ISectionElement>, ISectionElement>? sectionBuilderAction = null)
        {
            ISectionElement? element = null;
            if (sectionBuilderAction is not null)
            {
                var sectionBuilder = new SectionBuilder();
                element = sectionBuilderAction(sectionBuilder);
            }
            return builder.AddSectionBlock(new TextSectionBlock(label, element));
        }

        public static IBlocksBuilder AddTextSectionBlock(this IBlocksBuilder builder, string text, Func<IElementBuilder<ISectionElement>, ISectionElement>? sectionBuilderAction = null)
        {
            return builder.AddSectionBlock(new PlainText(text), sectionBuilderAction);
        }

        public static IBlocksBuilder AddMarkdownSectionBlock(this IBlocksBuilder builder, string text, Func<IElementBuilder<ISectionElement>, ISectionElement>? sectionBuilderAction = null)
        {
            return builder.AddSectionBlock(new MarkdownText(text), sectionBuilderAction);
        }

        public static IBlocksBuilder AddTextFieldsSectionBlock(this IBlocksBuilder builder, IEnumerable<PlainText> fields, Func<IElementBuilder<ISectionElement>, ISectionElement>? sectionBuilderAction = null)
        {
            ISectionElement? element = null;
            if (sectionBuilderAction is not null)
            {
                var sectionBuilder = new SectionBuilder();
                element = sectionBuilderAction(sectionBuilder);
            }
            return builder.AddSectionBlock(new TextFieldsSectionBlock(fields, element));
        }
    }
}