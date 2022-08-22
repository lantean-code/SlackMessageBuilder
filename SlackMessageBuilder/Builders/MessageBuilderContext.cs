using Slack.MessageBuilder.Objects;
using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    internal class MessageBuilderContext : IMessageBuilderContext
    {
        public MessageBuilderContext(string text, bool? isMarkdown, List<AttachmentBase>? attachments, List<IBlockElement>? blocks, string? threadId)
        {
            Text = text;
            IsMarkdown = isMarkdown;
            Attachments = attachments;
            Blocks = blocks;
            ThreadId = threadId;
        }

        public string Text { get; internal set; }
        public bool? IsMarkdown { get; internal set; }
        public List<AttachmentBase>? Attachments { get; internal set; }
        public List<IBlockElement>? Blocks { get; internal set; }
        public string? ThreadId { get; internal set; }
    }
}