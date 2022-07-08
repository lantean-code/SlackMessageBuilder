using SlackMessageBuilder.Builders;

namespace SlackMessageBuilder
{
    public static class SlackMessageBuilder
    {
        public static MessageBuilder Create(string text)
        {
            return new MessageBuilder(text);
        }
    }
}