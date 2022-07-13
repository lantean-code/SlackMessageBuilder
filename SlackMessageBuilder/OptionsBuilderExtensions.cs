namespace SlackMessageBuilder
{
    /// <summary>
    /// Options Builder Extensions
    /// </summary>
    public static class OptionsBuilderExtensions
    {
        /// <summary>
        /// Adds an option with markdown text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<Checkboxes> AddOptionMarkdown(this IOptionsBuilder<Checkboxes> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new MarkdownText(text), value, description is null ? null : new PlainText(description)));
        }

        /// <summary>
        /// Adds an option with markdown text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<RadioButtons> AddOptionMarkdown(this IOptionsBuilder<RadioButtons> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new MarkdownText(text), value, description is null ? null : new PlainText(description)));
        }

        /// <summary>
        /// Adds an option with plain text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<Checkboxes> AddOption(this IOptionsBuilder<Checkboxes> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }

        /// <summary>
        /// Adds an option with plain text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<RadioButtons> AddOption(this IOptionsBuilder<RadioButtons> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }

        /// <summary>
        /// Adds an option with plain text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <param name="url">A URL to load in the user's browser when the option is clicked. The url attribute is only available in overflow menus. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.</param>
        /// <returns></returns>
        public static IOptionsBuilder<Overflow> AddOption(this IOptionsBuilder<Overflow> builder, string text, string value, string? description = null, string? url = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description), url));
        }

        /// <summary>
        /// Adds an option with plain text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<StaticSelect> AddOption(this IOptionsBuilder<StaticSelect> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }

        /// <summary>
        /// Adds an option with plain text.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the text shown in the option on the menu. Overflow, select, and multi-select menus can only use <see cref="PlainText"/> objects, while radio buttons and checkboxes can use <see cref="MarkdownText"/> objects. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="value">A unique string value that will be passed to your app when this option is chosen.Maximum length for this field is 75 characters.</param>
        /// <param name="description">A <see cref="PlainText"/> object that defines a line of descriptive text shown below the text field beside the radio button. Maximum length for the text object within this field is 75 characters.</param>
        /// <returns></returns>
        public static IOptionsBuilder<StaticMultiSelect> AddOption(this IOptionsBuilder<StaticMultiSelect> builder, string text, string value, string? description = null)
        {
            return builder.AddOption(new Option(new PlainText(text), value, description is null ? null : new PlainText(description)));
        }
    }
}