using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="Block"/>s.
    /// </summary>
    public static class BlockBuilderExtensions
    {
        /// <summary>
        /// Adds an actions block with the provided elements.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="elements">An array of interactive element objects - buttons, select menus, overflow menus, or date pickers. There is a maximum of 25 elements in each action block.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddActionsBlock(this IBlocksBuilder builder, IEnumerable<IActionsElement> elements, string? blockId = null)
        {
            return builder.AddBlock(new ActionsBlock(elements, blockId));
        }

        /// <summary>
        /// Adds an actions block using a <see cref="IElementsBuilder{IActionsElement}"/> to configure the elements.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="elementsBuilder">A builder to build a <see cref="IInputElement"/>.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddActionsBlock(this IBlocksBuilder builder, Action<IElementsBuilder<IActionsElement>> elementsBuilder, string? blockId = null)
        {
            var actionsBuilder = new ActionsBuilder();
            elementsBuilder(actionsBuilder);
            var elements = actionsBuilder.Build();
            return builder.AddActionsBlock(elements, blockId);
        }

        /// <summary>
        /// Adds a context block with the provided elements.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="elements">An array of image elements and text objects. Maximum number of items is 10.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddContextBlock(this IBlocksBuilder builder, IEnumerable<IContextElement> elements, string? blockId = null)
        {
            return builder.AddBlock(new ContextBlock(elements, blockId));
        }

        /// <summary>
        /// Adds a context block using a <see cref="IElementsBuilder{IContextElement}"/> to configure the elements.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="elementsBuilder">A <see cref="IElementsBuilder{IContextElement}"/> to configure the elements</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddContextBlock(this IBlocksBuilder builder, Action<IElementsBuilder<IContextElement>> elementsBuilder, string? blockId = null)
        {
            var contextBuilder = new ContextBuilder();
            elementsBuilder(contextBuilder);
            var elements = contextBuilder.Build();
            return builder.AddContextBlock(elements, blockId);
        }

        /// <summary>
        /// Adds a divider block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddDividerBlock(this IBlocksBuilder builder, string? blockId = null)
        {
            return builder.AddBlock(new DividerBlock(blockId));
        }

        /// <summary>
        /// Adds a header block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="headerText">The text for the block, in the form of a plain_text text object. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddHeaderBlock(this IBlocksBuilder builder, string headerText, string? blockId = null)
        {
            return builder.AddBlock(new HeaderBlock(new PlainText(headerText), blockId));
        }

        /// <summary>
        /// Adds an image block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        public static IBlocksBuilder AddImageBlock(this IBlocksBuilder builder, ImageBlock block)
        {
            return builder.AddBlock(block);
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
        /// <summary>
        /// Adds an input block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="block">An input block.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddInputBlock(this IBlocksBuilder builder, InputBlock block)
        {
            return builder.AddBlock(block);
        }

        /// <summary>
        /// Adds an input block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A label that appears above an input element in the form of a text object that must have type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="element">A <see cref="PlainTextInput"/> element, a <see cref="Checkboxes"/> element, a <see cref="RadioButtons"/> element, a <see cref="SelectMenu"/> element, a <see cref="DatePicker"/> or a <see cref="TimePicker"/>.</param>
        /// <param name="dispatchAction">A boolean that indicates whether or not the use of elements in this block should dispatch a block_actions payload. Defaults to false.</param>
        /// <param name="hint">An optional hint that appears below an input element in a lighter grey. It must be a text object with a type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="optional">A boolean that indicates whether the input element may be empty when a user submits the modal. Defaults to false.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddInputBlock(this IBlocksBuilder builder, string label, IInputElement element, bool? dispatchAction = null, PlainText? hint = null, bool? optional = null, string? blockId = null)
        {
            return builder.AddInputBlock(new InputBlock(new PlainText(label), element, dispatchAction, hint, optional, blockId));
        }

        /// <summary>
        /// Adds an input block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A label that appears above an input element in the form of a text object that must have type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="elementBuilder">A builder to build a <see cref="IInputElement"/>.</param>
        /// <param name="dispatchAction">A boolean that indicates whether or not the use of elements in this block should dispatch a block_actions payload. Defaults to false.</param>
        /// <param name="hint">An optional hint that appears below an input element in a lighter grey. It must be a text object with a type of plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="optional">A boolean that indicates whether the input element may be empty when a user submits the modal. Defaults to false.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddInputBlock(this IBlocksBuilder builder, string label, Func<IElementBuilder<IInputElement>, IInputElement> elementBuilder, bool? dispatchAction = null, PlainText? hint = null, bool? optional = null, string? blockId = null)
        {
            var inputBuilder = new InputBuilder();
            var element = elementBuilder(inputBuilder);
            return builder.AddInputBlock(label, element, dispatchAction, hint, optional, blockId);
        }

        /// <summary>
        /// Adds a markdown section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.</param>
        /// <param name="elementBuilder">A builder to build a <see cref="ISectionElement"/>.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddMarkdownSectionBlock(this IBlocksBuilder builder, string text, Func<IElementBuilder<ISectionElement>, ISectionElement>? elementBuilder = null, string? blockId = null)
        {
            return builder.AddSectionBlock(new MarkdownText(text), elementBuilder, blockId);
        }

        /// <summary>
        /// Adds a section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="block">A section block.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddSectionBlock(this IBlocksBuilder builder, SectionBlock block)
        {
            return builder.AddBlock(block);
        }

        /// <summary>
        /// Adds a section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.</param>
        /// <param name="element">One of the available element objects.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddSectionBlock(this IBlocksBuilder builder, TextObject text, ISectionElement? element = null, string? blockId = null)
        {
            return builder.AddSectionBlock(new TextSectionBlock(text, element, blockId));
        }

        /// <summary>
        /// Adds a section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.</param>
        /// <param name="elementBuilder">One of the available element objects.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddSectionBlock(this IBlocksBuilder builder, TextObject text, Func<IElementBuilder<ISectionElement>, ISectionElement>? elementBuilder = null, string? blockId = null)
        {
            ISectionElement? element = null;
            if (elementBuilder is not null)
            {
                var sectionBuilder = new SectionBuilder();
                element = elementBuilder(sectionBuilder);
            }
            return builder.AddSectionBlock(text, element, blockId);
        }

        /// <summary>
        /// Adds a text fields section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="fields">An array of text objects. Any text objects included with fields will be rendered in a compact format that allows for 2 columns of side-by-side text. Maximum number of items is 10. Maximum length for the text in each item is 2000 characters.</param>
        /// <param name="elementBuilder">A builder to build a <see cref="ISectionElement"/>.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddTextFieldsSectionBlock(this IBlocksBuilder builder, IEnumerable<PlainText> fields, Func<IElementBuilder<ISectionElement>, ISectionElement>? elementBuilder = null, string? blockId = null)
        {
            ISectionElement? element = null;
            if (elementBuilder is not null)
            {
                var sectionBuilder = new SectionBuilder();
                element = elementBuilder(sectionBuilder);
            }
            return builder.AddSectionBlock(new TextFieldsSectionBlock(fields, element, blockId));
        }

        /// <summary>
        /// Adds a text fields section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="fields">An array of text objects. Any text objects included with fields will be rendered in a compact format that allows for 2 columns of side-by-side text. Maximum number of items is 10. Maximum length for the text in each item is 2000 characters.</param>
        /// <param name="elementBuilder">A builder to build a <see cref="ISectionElement"/>.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddTextFieldsSectionBlock(this IBlocksBuilder builder, IEnumerable<string> fields, Func<IElementBuilder<ISectionElement>, ISectionElement>? elementBuilder = null, string? blockId = null)
        {
            ISectionElement? element = null;
            if (elementBuilder is not null)
            {
                var sectionBuilder = new SectionBuilder();
                element = elementBuilder(sectionBuilder);
            }

            var plainTextFields = fields.Select(f => new PlainText(f)).ToList();
            return builder.AddSectionBlock(new TextFieldsSectionBlock(plainTextFields, element, blockId));
        }

        /// <summary>
        /// Adds a plain text section block.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block, in the form of a text object. Maximum length for the text in this field is 3000 characters.</param>
        /// <param name="elementBuilder">A builder to build a <see cref="ISectionElement"/>.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, a block_id will be generated. You can use this block_id when you receive an interaction payload to identify the source of the action. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        /// <returns></returns>
        public static IBlocksBuilder AddTextSectionBlock(this IBlocksBuilder builder, string text, Func<IElementBuilder<ISectionElement>, ISectionElement>? elementBuilder = null, string? blockId = null)
        {
            return builder.AddSectionBlock(new PlainText(text), elementBuilder, blockId);
        }
    }
}