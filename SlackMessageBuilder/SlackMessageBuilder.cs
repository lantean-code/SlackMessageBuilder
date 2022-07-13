using SlackMessageBuilder.Builders;

namespace SlackMessageBuilder
{
    /// <summary>
    /// Message builder factory.
    /// </summary>
    public static class SlackMessageBuilder
    {
        /// <summary>
        /// Creates a new instance of the fluent message builder.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isMarkdown"></param>
        /// <returns></returns>
        public static MessageBuilder Create(string text, bool? isMarkdown = null)
        {
            return new MessageBuilder(text, isMarkdown);
        }
    }
}