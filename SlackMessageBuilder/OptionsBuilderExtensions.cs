namespace SlackMessageBuilder
{
    public static class OptionsBuilderExtensions
    {
        public static IOptionsBuilder<Checkboxes> AddOptionMarkdown(this IOptionsBuilder<Checkboxes> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new MarkdownText(text), value, description is null ? null : new PlainText(description)));
        }

        public static IOptionsBuilder<RadioButtons> AddOptionMarkdown(this IOptionsBuilder<RadioButtons> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new MarkdownText(text), value, description is null ? null : new PlainText(description)));
        }

        public static IOptionsBuilder<Checkboxes> AddOption(this IOptionsBuilder<Checkboxes> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }

        public static IOptionsBuilder<RadioButtons> AddOption(this IOptionsBuilder<RadioButtons> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }

        public static IOptionsBuilder<Overflow> AddOption(this IOptionsBuilder<Overflow> builder, string text, string value, string? description = null, string? url = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description), url));
        }

        public static IOptionsBuilder<StaticSelectBase> AddOption(this IOptionsBuilder<StaticSelectBase> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }
    }
}