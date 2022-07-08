using System.Text.Json;

namespace SlackMessageBuilder.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new TimePicker("action-id", new PlainText("placeholder-text"), focusOnLoad: true, initialTime: new TimeSpan(15, 55, 11));

            var str = JsonSerializer.Serialize(sut, SlackJsonSerializerOptions.Options);

            var smb = SlackMessageBuilder.Create("This is some fallback text").WithBlocks(builder =>
            {
                builder.AddTextSectionBlock("This is a plain text section block.");
                builder.AddMarkdownSectionBlock("This is a mrkdwn section block :ghost: *this is bold*, and ~this is crossed out~, and <https://google.com|this is a link>");
                builder.AddTextFieldsSectionBlock(Enumerable.Repeat(new PlainText("*this is plain_text text*"), 5));
                builder.AddMarkdownSectionBlock("Test block with users select", b => b.AddUsersSelect("Select a user", "users_select-action"));
                builder.AddMarkdownSectionBlock("Test block with multi users select", b => b.AddUsersMultiSelect("Select a user", "users_multi_select-action"));

                builder.AddActionsBlock(a =>
                {
                    a.AddButton(new Button(new PlainText("Button"), "action-button"));
                    a.AddUsersSelect(new UsersSelect(new PlainText("Placeholder"), "action-users"));
                    a.AddConversationsSelect("Placeholder", "action-conversations");
                });

                builder.AddImageBlock("https://ichef.bbci.co.uk/news/976/cpsprodpb/15C3F/production/_125815198_hi077208539.jpg", "alt text", "Title");

                builder.AddInputBlock("label", b => b.AddUsersSelect("Placeholder", "action-users-input"));

                builder.AddInputBlock("test", b => b.AddStaticSelect("Plan", "action-static-select", b =>
                {
                    b.AddOption("Option1", "option-1");
                    b.AddOption("Option2", "option-2");
                }));

                builder.AddInputBlock("test2", b => b.AddStaticMultiSelect("Plan", "action-static-multi-select", b =>
                {
                    b.AddOption("Option1", "option-1");
                    b.AddOption("Option2", "option-2");
                }, maxSelectedItems: 2));

                builder.AddTextSectionBlock("sec", b => b.AddUsersSelect("Placeholder", "action-users-again"));

                builder.AddDividerBlock();

                builder.AddHeaderBlock("Header");

                builder.AddContextBlock(c =>
                {
                    c.AddText("Plain text");
                    c.AddImage("https://google.com/uima.png", "alt text");
                    c.AddMarkdown("*Bold text*");
                });
            });

            smb.WithAttachment(a => a.WithMarkdown("This is an attachment").WithBlocks(b => b.AddHeaderBlock("Header")));

            var message = smb.Build();

            var m = JsonSerializer.Serialize(smb.Build().Blocks, SlackJsonSerializerOptions.Options);
        }
    }
}