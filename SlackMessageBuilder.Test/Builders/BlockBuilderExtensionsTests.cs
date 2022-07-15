using FluentAssertions;
using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;

namespace Slack.MessageBuilder.Test.Builders
{
    public class BlocksBuilderExtensionsTests
    {
        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingActionBlock_THEN()
        {
            var builder = new BlocksBuilder();
            builder.AddActionsBlock(b => b.AddElement(new Button("Button Text", "action-id")));

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var actionBlock = blocks[0].Should().BeOfType<ActionsBlock>().Subject;
            actionBlock.Elements.Should().HaveCount(1);

            var button = actionBlock.Elements.First();
            button.Should().BeOfType<Button>();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingMarkdownSectionBlockWithNoAccessory_THEN_BuilderShouldHave1BlockOfTypeTextSectionBlockWithMarkdownText()
        {
            var builder = new BlocksBuilder();
            builder.AddMarkdownSectionBlock("markdown");

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextSectionBlock>().Subject;

            var markdownText = sectionBlock.Text.Should().BeOfType<MarkdownText>().Subject;
            markdownText.Text.Should().Be("markdown");

            sectionBlock.Accessory.Should().BeNull();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingMarkdownSectionBlockWithAccessory_THEN_BuilderShouldHave1BlockOfTypeTextSectionBlockWithMarkdownText()
        {
            var builder = new BlocksBuilder();
            builder.AddMarkdownSectionBlock("markdown", b => b.AddButton("Button Text", "action-id"));

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextSectionBlock>().Subject;

            var markdownText = sectionBlock.Text.Should().BeOfType<MarkdownText>().Subject;
            markdownText.Text.Should().Be("markdown");

            sectionBlock.Accessory.Should().NotBeNull();
            sectionBlock.Accessory.Should().BeOfType<Button>();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextSectionBlockWithNoAccessory_THEN_BuilderShouldHave1BlockOfTypeTextSectionBlockWithPlainText()
        {
            var builder = new BlocksBuilder();
            builder.AddTextSectionBlock("plaintext");

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextSectionBlock>().Subject;
            var markdownText = sectionBlock.Text.Should().BeOfType<PlainText>().Subject;
            markdownText.Text.Should().Be("plaintext");

            sectionBlock.Accessory.Should().BeNull();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextSectionBlockWithAccessory_THEN_BuilderShouldHave1BlockOfTypeTextSectionBlockWithPlainText()
        {
            var builder = new BlocksBuilder();
            builder.AddTextSectionBlock("plaintext", b => b.AddButton("Button Text", "action-id"));

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextSectionBlock>().Subject;
            var markdownText = sectionBlock.Text.Should().BeOfType<PlainText>().Subject;
            markdownText.Text.Should().Be("plaintext");

            sectionBlock.Accessory.Should().NotBeNull();
            sectionBlock.Accessory.Should().BeOfType<Button>();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextFieldsSectionBlockWithStringsAndWithNoAccessory_THEN_BuilderShouldHave1BlockOfTypeTextFieldsSectionBlock()
        {
            var builder = new BlocksBuilder();
            builder.AddTextFieldsSectionBlock(new[]
            {
                "Field 1",
                "Field 2"
            });

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextFieldsSectionBlock>().Subject;
            var fields = sectionBlock.Fields.Should().BeAssignableTo<IEnumerable<PlainText>>().Subject;
            fields.Should().HaveCount(2);

            sectionBlock.Accessory.Should().BeNull();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextFieldsSectionBlockWithStringsAndWithAccessory_THEN_BuilderShouldHave1BlockOfTypeTextFieldsSectionBlock()
        {
            var builder = new BlocksBuilder();
            builder.AddTextFieldsSectionBlock(new[]
            {
                "Field 1",
                "Field 2"
            }, b => b.AddButton("Button Text", "action-id"));

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextFieldsSectionBlock>().Subject;
            var fields = sectionBlock.Fields.Should().BeAssignableTo<IEnumerable<PlainText>>().Subject;
            fields.Should().HaveCount(2);

            sectionBlock.Accessory.Should().NotBeNull();
            sectionBlock.Accessory.Should().BeOfType<Button>();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextFieldsSectionBlockWithPlainTextsAndWithNoAccessory_THEN_BuilderShouldHave1BlockOfTypeTextFieldsSectionBlock()
        {
            var builder = new BlocksBuilder();
            builder.AddTextFieldsSectionBlock(new[]
            {
                new PlainText("Field 1"),
                new PlainText("Field 2")
            });

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextFieldsSectionBlock>().Subject;
            var fields = sectionBlock.Fields.Should().BeAssignableTo<IEnumerable<PlainText>>().Subject;
            fields.Should().HaveCount(2);

            sectionBlock.Accessory.Should().BeNull();
        }

        [Fact]
        public void GIVEN_EmptyBuilder_WHEN_AddingTextFieldsSectionBlockWithPlainTextsAndWithAccessory_THEN_BuilderShouldHave1BlockOfTypeTextFieldsSectionBlock()
        {
            var builder = new BlocksBuilder();
            builder.AddTextFieldsSectionBlock(new[]
            {
                new PlainText("Field 1"),
                new PlainText("Field 2")
            }, b => b.AddButton("Button Text", "action-id"));

            var blocks = builder.Build();

            blocks.Should().HaveCount(1);

            var sectionBlock = blocks[0].Should().BeOfType<TextFieldsSectionBlock>().Subject;
            var fields = sectionBlock.Fields.Should().BeAssignableTo<IEnumerable<PlainText>>().Subject;
            fields.Should().HaveCount(2);

            sectionBlock.Accessory.Should().NotBeNull();
            sectionBlock.Accessory.Should().BeOfType<Button>();
        }
    }
}