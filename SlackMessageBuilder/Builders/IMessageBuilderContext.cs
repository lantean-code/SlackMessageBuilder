using Slack.MessageBuilder.Objects;
using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    public interface IMessageBuilderContext
    {
        List<AttachmentBase>? Attachments { get; }
        List<IBlockElement>? Blocks { get; }
        bool? IsMarkdown { get; }
        string Text { get; }
        string? ThreadId { get; }
    }
}