using Slack.MessageBuilder;
using Slack.MessageBuilder.Objects;

namespace Slack.MessageBuilder.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var smb = SlackMessageBuilder
                .CreateApiMessage("global-be", "This is some fallback text", true)
                //.CreateMessage("This is some fallback text", true)
                //.ForChannel("global-platform-be")
                .WithBlocks(builder =>
                {
                    builder.AddTextSectionBlock("This is a plain text section block.");
                    builder.AddMarkdownSectionBlock("This is a mrkdwn section block :ghost: *this is bold*, and ~this is crossed out~, and <https://google.com|this is a link>");
                    builder.AddTextFieldsSectionBlock(Enumerable.Repeat(new PlainText("*this is plain_text text*"), 5));
                    builder.AddMarkdownSectionBlock("Test block with users select", b => b.AddUsersSelect("Select a user", "users_select-action"));
                    builder.AddMarkdownSectionBlock("Test block with multi users select", b => b.AddUsersMultiSelect("Select a user", "users_multi_select-action"));

                    builder.AddActionsBlock(a =>
                    {
                        a.AddButton(new Button(new PlainText("Button"), "action-button"));
                        a.AddButton("Button Text", "action-button-2", null, null, ButtonStyle.Default);
                        a.AddUsersSelect(new UsersSelect(new PlainText("Placeholder"), "action-users"));
                        a.AddUsersSelect("Placeholder 2", "action-users-2");
                        a.AddConversationsSelect("Placeholder", "action-conversations");

                        a.AddStaticSelect("Plan", "action-static-select-groups", b =>
                        {
                            b.AddOptionsGroup("name", builders =>
                            {
                                builders.AddOption("Option1", "option-1");
                                builders.AddOption("Option2", "option-2");
                            });
                        });
                    });

                    builder.AddImageBlock("https://ichef.bbci.co.uk/news/976/cpsprodpb/15C3F/production/_125815198_hi077208539.jpg", "alt text", "Title");

                    builder.AddInputBlock("input-block-1", b => b.AddUsersSelect("Placeholder", "action-users-input"));

                    builder.AddInputBlock("input-block-2", b => b.AddStaticSelect("Plan", "action-static-select", b =>
                    {
                        b.AddOption("Option1", "option-1");
                        b.AddOption("Option2", "option-2");
                    }));

                    builder.AddInputBlock("input-block-3", b => b.AddStaticMultiSelect("Plan", "action-static-select-groups", b =>
                    {
                        b.AddOptionsGroup("name", builders =>
                        {
                            builders.AddOption("Option1", "option-1");
                            builders.AddOption("Option2", "option-2");
                        });
                    }));

                    builder.AddInputBlock("input-block-4", b => b.AddStaticMultiSelect("Plan", "action-static-multi-select", b =>
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

            smb.WithAttachment(a => a.WithBlocks(b => b.AddHeaderBlock("Header")));

            var message = smb.Build();

            Assert.NotNull(message);

            try
            {
                var m = message.ToJson();

                Assert.NotNull(m);
            }
            catch (Exception ex)
            {
                var x = ex;
            }
        }
    }
}