using SlackMessageBuilder.Builders;
using System;
using System.Collections.Generic;

namespace SlackMessageBuilder
{
    public static class SlackElementsBuilderExtensions
    {
        public static IElementsBuilder<Button> AddButton(this IElementsBuilder<Button> builder, Button element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<Button> AddButton(this IElementsBuilder<Button> builder, string text, string actionId, string? url = null, string? value = null, ButtonStyle? style = null, Confirm? confirmDialog = null, string? accessibilityLabel = null)
        {
            return builder.AddButton(new Button(new PlainText(text), actionId, url, value, style, confirmDialog, accessibilityLabel));
        }

        public static Button AddButton(this IElementBuilder<Button> builder, Button element)
        {
            return element;
        }

        public static Button AddButton(this IElementBuilder<Button> builder, string text, string actionId, string? url = null, string? value = null, ButtonStyle? style = null, Confirm? confirmDialog = null, string? accessibilityLabel = null)
        {
            return builder.AddButton(new Button(new PlainText(text), actionId, url, value, style, confirmDialog, accessibilityLabel));
        }

        public static IElementsBuilder<Checkboxes> AddCheckboxes(this IElementsBuilder<Checkboxes> builder, Checkboxes element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<Checkboxes> AddCheckboxes(this IElementsBuilder<Checkboxes> builder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<Checkboxes> AddCheckboxes(this IElementsBuilder<Checkboxes> builder, string actionId, Action<IOptionsBuilder<Checkboxes>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<Checkboxes>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, Checkboxes element)
        {
            return element;
        }

        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, string actionId, Action<IOptionsBuilder<Checkboxes>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<Checkboxes>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<DatePicker> AddDatePicker(this IElementsBuilder<DatePicker> builder, DatePicker element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<DatePicker> AddDatePicker(this IElementsBuilder<DatePicker> builder, string actionId, string? placeholder = null, DateTime? initialDate = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddDatePicker(new DatePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialDate, confirmDialog, focusOnLoad));
        }

        public static DatePicker AddDatePicker(this IElementBuilder<DatePicker> builder, DatePicker element)
        {
            return element;
        }

        public static DatePicker AddDatePicker(this IElementBuilder<DatePicker> builder, string actionId, string? placeholder = null, DateTime? initialDate = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddDatePicker(new DatePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialDate, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<ImageElement> AddImage(this IElementsBuilder<ImageElement> builder, ImageElement element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<ImageElement> AddImage(this IElementsBuilder<ImageElement> builder, string url, string alternativeText = "")
        {
            return builder.AddImage(new ImageElement(url, alternativeText));
        }

        public static ImageElement AddImage(this IElementBuilder<ImageElement> builder, ImageElement element)
        {
            return element;
        }

        public static ImageElement AddImage(this IElementBuilder<ImageElement> builder, string url, string alternativeText = "")
        {
            return builder.AddImage(new ImageElement(url, alternativeText));
        }

        public static IElementsBuilder<Overflow> AddOverflow(this IElementsBuilder<Overflow> builder, Overflow element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<Overflow> AddOverflow(this IElementsBuilder<Overflow> builder, string actionId, IEnumerable<Option> options, Confirm? confirmDialog = null)
        {
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        public static IElementsBuilder<Overflow> AddOverflow(this IElementsBuilder<Overflow> builder, string actionId, Action<IOptionsBuilder<Overflow>> optionsBuilderAction, Confirm? confirmDialog = null)
        {
            var optionsBuilder = new OptionsBuilder<Overflow>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, Overflow element)
        {
            return element;
        }

        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, string actionId, IEnumerable<Option> options, Confirm? confirmDialog = null)
        {
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, string actionId, Action<IOptionsBuilder<Overflow>> optionsBuilderAction, Confirm? confirmDialog = null)
        {
            var optionsBuilder = new OptionsBuilder<Overflow>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        public static IElementsBuilder<TextObject> AddText(this IElementsBuilder<TextObject> builder, TextObject element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<TextObject> AddText(this IElementsBuilder<TextObject> builder, string text, bool? emoji = null)
        {
            return builder.AddText(new PlainText(text, emoji));
        }

        public static TextObject AddText(this IElementBuilder<TextObject> builder, TextObject element)
        {
            return element;
        }

        public static TextObject AddText(this IElementBuilder<TextObject> builder, string text, bool? emoji = null)
        {
            return builder.AddText(new PlainText(text, emoji));
        }

        public static IElementsBuilder<TextObject> AddMarkdown(this IElementsBuilder<TextObject> builder, string text, bool? verbatim = null)
        {
            return builder.AddText(new MarkdownText(text, verbatim));
        }

        public static TextObject AddMarkdown(this IElementBuilder<TextObject> builder, string text, bool? verbatim = null)
        {
            return builder.AddText(new MarkdownText(text, verbatim));
        }

        public static IElementsBuilder<PlainTextInput> AddTextInput(this IElementsBuilder<PlainTextInput> builder, PlainTextInput element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<PlainTextInput> AddTextInput(this IElementsBuilder<PlainTextInput> builder, string actionId, string? placeholder = null, string? initialValue = null, bool? multiline = null, int? minLength = null, int? maxLength = null, DispatchActionConfig? dispatchActionConfig = null, bool? focusOnLoad = null)
        {
            return builder.AddTextInput(new PlainTextInput(actionId, placeholder is null ? null : new PlainText(placeholder), initialValue, multiline, minLength, maxLength, dispatchActionConfig, focusOnLoad));
        }

        public static PlainTextInput AddTextInput(this IElementBuilder<PlainTextInput> builder, PlainTextInput element)
        {
            return element;
        }

        public static PlainTextInput AddTextInput(this IElementBuilder<PlainTextInput> builder, string actionId, string? placeholder = null, string? initialValue = null, bool? multiline = null, int? minLength = null, int? maxLength = null, DispatchActionConfig? dispatchActionConfig = null, bool? focusOnLoad = null)
        {
            return builder.AddTextInput(new PlainTextInput(actionId, placeholder is null ? null : new PlainText(placeholder), initialValue, multiline, minLength, maxLength, dispatchActionConfig, focusOnLoad));
        }

        public static IElementsBuilder<RadioButtons> AddRadioButtons(this IElementsBuilder<RadioButtons> builder, RadioButtons element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<RadioButtons> AddRadioButtons(this IElementsBuilder<RadioButtons> builder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<RadioButtons> AddRadioButtons(this IElementsBuilder<RadioButtons> builder, string actionId, Action<IOptionsBuilder<RadioButtons>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<RadioButtons>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, RadioButtons element)
        {
            return element;
        }

        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, string actionId, Action<IOptionsBuilder<RadioButtons>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<RadioButtons>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<TimePicker> AddTimePicker(this IElementsBuilder<TimePicker> builder, TimePicker element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<TimePicker> AddTimePicker(this IElementsBuilder<TimePicker> builder, string actionId, string? placeholder = null, TimeSpan? initialTime = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddTimePicker(new TimePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialTime, confirmDialog, focusOnLoad));
        }

        public static TimePicker AddTimePicker(this IElementBuilder<TimePicker> builder, TimePicker element)
        {
            return element;
        }

        public static TimePicker AddTimePicker(this IElementBuilder<TimePicker> builder, string actionId, string? placeholder = null, TimeSpan? initialTime = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddTimePicker(new TimePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialTime, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticSelect> AddStaticSelect(this IElementsBuilder<StaticSelect> builder, StaticSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<StaticSelect> AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initalOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticSelect> AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticSelect>> optionsBuilderAction, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initalOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticSelect> AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initalOption, confirmDialog, focusOnLoad));
        }

        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, StaticSelect element)
        {
            return element;
        }

        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initalOption, confirmDialog, focusOnLoad));
        }

        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticSelectBase>> optionsBuilderAction, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelectBase>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initalOption, confirmDialog, focusOnLoad));
        }

        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initalOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticMultiSelect> AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, StaticMultiSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<StaticMultiSelect> AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticMultiSelect> AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticMultiSelect>> optionsBuilderAction, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticMultiSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<StaticMultiSelect> AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, StaticMultiSelect element)
        {
            return element;
        }

        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticSelectBase>> optionsBuilderAction, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelectBase>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<ExternalDataSelect> AddExternalDataSelect(this IElementsBuilder<ExternalDataSelect> builder, ExternalDataSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<ExternalDataSelect> AddExternalDataSelect(this IElementsBuilder<ExternalDataSelect> builder, string placeholder, string actionId, int? minQueryLength = null, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataSelect(new ExternalDataSelect(new PlainText(placeholder), actionId, minQueryLength, initalOption, confirmDialog, focusOnLoad));
        }

        public static ExternalDataSelect AddExternalDataSelect(this IElementBuilder<ExternalDataSelect> builder, ExternalDataSelect element)
        {
            return element;
        }

        public static ExternalDataSelect AddExternalDataSelect(this IElementBuilder<ExternalDataSelect> builder, string placeholder, string actionId, int? minQueryLength = null, Option? initalOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataSelect(new ExternalDataSelect(new PlainText(placeholder), actionId, minQueryLength, initalOption, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<ExternalDataMultiSelect> AddExternalDataMultiSelect(this IElementsBuilder<ExternalDataMultiSelect> builder, ExternalDataMultiSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<ExternalDataMultiSelect> AddExternalDataMultiSelect(this IElementsBuilder<ExternalDataMultiSelect> builder, string placeholder, string actionId, int? minQueryLength = null, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataMultiSelect(new ExternalDataMultiSelect(new PlainText(placeholder), actionId, minQueryLength, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static ExternalDataMultiSelect AddExternalDataMultiSelect(this IElementBuilder<ExternalDataMultiSelect> builder, ExternalDataMultiSelect element)
        {
            return element;
        }

        public static ExternalDataMultiSelect AddExternalDataMultiSelect(this IElementBuilder<ExternalDataMultiSelect> builder, string placeholder, string actionId, int? minQueryLength = null, IEnumerable<Option>? initalOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataMultiSelect(new ExternalDataMultiSelect(new PlainText(placeholder), actionId, minQueryLength, initalOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<UsersSelect> AddUsersSelect(this IElementsBuilder<UsersSelect> builder, UsersSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<UsersSelect> AddUsersSelect(this IElementsBuilder<UsersSelect> builder, string placeholder, string actionId, string? initialUser = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersSelect(new UsersSelect(new PlainText(placeholder), actionId, initialUser, confirmDialog, focusOnLoad));
        }

        public static UsersSelect AddUsersSelect(this IElementBuilder<UsersSelect> builder, UsersSelect element)
        {
            return element;
        }

        public static UsersSelect AddUsersSelect(this IElementBuilder<UsersSelect> builder, string placeholder, string actionId, string? initialUser = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersSelect(new UsersSelect(new PlainText(placeholder), actionId, initialUser, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<UsersMultiSelect> AddUsersMultiSelect(this IElementsBuilder<UsersMultiSelect> builder, UsersMultiSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<UsersMultiSelect> AddUsersMultiSelect(this IElementsBuilder<UsersMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialUsers = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersMultiSelect(new UsersMultiSelect(new PlainText(placeholder), actionId, initialUsers, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static UsersMultiSelect AddUsersMultiSelect(this IElementBuilder<UsersMultiSelect> builder, UsersMultiSelect element)
        {
            return element;
        }

        public static UsersMultiSelect AddUsersMultiSelect(this IElementBuilder<UsersMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialUsers = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersMultiSelect(new UsersMultiSelect(new PlainText(placeholder), actionId, initialUsers, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<ConversationsSelect> AddConversationsSelect(this IElementsBuilder<ConversationsSelect> builder, ConversationsSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<ConversationsSelect> AddConversationsSelect(this IElementsBuilder<ConversationsSelect> builder, string placeholder, string actionId, string? initialConversation = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsSelect(new ConversationsSelect(new PlainText(placeholder), actionId, initialConversation, filter, defaultToCurrentConversation, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        public static ConversationsSelect AddConversationsSelect(this IElementBuilder<ConversationsSelect> builder, ConversationsSelect element)
        {
            return element;
        }

        public static ConversationsSelect AddConversationsSelect(this IElementBuilder<ConversationsSelect> builder, string placeholder, string actionId, string? initialConversation = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsSelect(new ConversationsSelect(new PlainText(placeholder), actionId, initialConversation, filter, defaultToCurrentConversation, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<ConversationsMultiSelect> AddConversationsMultiSelect(this IElementsBuilder<ConversationsMultiSelect> builder, ConversationsMultiSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<ConversationsMultiSelect> AddConversationsMultiSelect(this IElementsBuilder<ConversationsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialConversations = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsMultiSelect(new ConversationsMultiSelect(new PlainText(placeholder), actionId, initialConversations, filter, defaultToCurrentConversation, responseUrlEnabled, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static ConversationsMultiSelect AddConversationsMultiSelect(this IElementBuilder<ConversationsMultiSelect> builder, ConversationsMultiSelect element)
        {
            return element;
        }

        public static ConversationsMultiSelect AddConversationsMultiSelect(this IElementBuilder<ConversationsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialConversations = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsMultiSelect(new ConversationsMultiSelect(new PlainText(placeholder), actionId, initialConversations, filter, defaultToCurrentConversation, responseUrlEnabled, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        //

        public static IElementsBuilder<PublicChannelsSelect> AddPublicChannelsSelect(this IElementsBuilder<PublicChannelsSelect> builder, PublicChannelsSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<PublicChannelsSelect> AddPublicChannelsSelect(this IElementsBuilder<PublicChannelsSelect> builder, string placeholder, string actionId, string? initialChannel = null, bool? responseUrlEnabled = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsSelect(new PublicChannelsSelect(new PlainText(placeholder), actionId, initialChannel, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        public static PublicChannelsSelect AddPublicChannelsSelect(this IElementBuilder<PublicChannelsSelect> builder, PublicChannelsSelect element)
        {
            return element;
        }

        public static PublicChannelsSelect AddPublicChannelsSelect(this IElementBuilder<PublicChannelsSelect> builder, string placeholder, string actionId, string? initialChannel = null, bool? responseUrlEnabled = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsSelect(new PublicChannelsSelect(new PlainText(placeholder), actionId, initialChannel, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        public static IElementsBuilder<PublicChannelsMultiSelect> AddPublicChannelsMultiSelect(this IElementsBuilder<PublicChannelsMultiSelect> builder, PublicChannelsMultiSelect element)
        {
            return builder.AddElement(element);
        }

        public static IElementsBuilder<PublicChannelsMultiSelect> AddPublicChannelsMultiSelect(this IElementsBuilder<PublicChannelsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialChannels = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsMultiSelect(new PublicChannelsMultiSelect(new PlainText(placeholder), actionId, initialChannels, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        public static PublicChannelsMultiSelect AddPublicChannelsMultiSelect(this IElementBuilder<PublicChannelsMultiSelect> builder, PublicChannelsMultiSelect element)
        {
            return element;
        }

        public static PublicChannelsMultiSelect AddPublicChannelsMultiSelect(this IElementBuilder<PublicChannelsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialChannels = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsMultiSelect(new PublicChannelsMultiSelect(new PlainText(placeholder), actionId, initialChannels, maxSelectedItems, confirmDialog, focusOnLoad));
        }
    }
}