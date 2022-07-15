using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Options Groups Builder Extensions
    /// </summary>
    public static class OptionsGroupsBuilderExtensions
    {
        /// <summary>
        /// Adds an options group.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects that belong to this specific group. Maximum of 100 items.</param>
        /// <returns></returns>
        public static IOptionsGroupsBuilder<StaticSelect> AddOptionsGroup(this IOptionsGroupsBuilder<StaticSelect> builder, string label, IEnumerable<Option> options)
        {
            return builder.AddOptionsGroup(new OptionsGroup(new PlainText(label), options));
        }

        /// <summary>
        /// Adds an options group.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <returns></returns>
        public static IOptionsGroupsBuilder<StaticSelect> AddOptionsGroup(this IOptionsGroupsBuilder<StaticSelect> builder, string label, Action<IOptionsBuilder<StaticSelect>> optionsBuilderAction)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddOptionsGroup(new OptionsGroup(new PlainText(label), options));
        }

        /// <summary>
        /// Adds an options group.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects that belong to this specific group. Maximum of 100 items.</param>
        /// <returns></returns>
        public static IOptionsGroupsBuilder<StaticMultiSelect> AddOptionsGroup(this IOptionsGroupsBuilder<StaticMultiSelect> builder, string label, IEnumerable<Option> options)
        {
            return builder.AddOptionsGroup(new OptionsGroup(new PlainText(label), options));
        }

        /// <summary>
        /// Adds an options group.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="label">A <see cref="PlainText"/> object that defines the label shown above this group of options. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <returns></returns>
        public static IOptionsGroupsBuilder<StaticMultiSelect> AddOptionsGroup(this IOptionsGroupsBuilder<StaticMultiSelect> builder, string label, Action<IOptionsBuilder<StaticMultiSelect>> optionsBuilderAction)
        {
            var optionsBuilder = new OptionsBuilder<StaticMultiSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddOptionsGroup(new OptionsGroup(new PlainText(label), options));
        }
    }
}