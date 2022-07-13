using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;
using System;
using System.Collections.Generic;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Element(s) builder extensions.
    /// </summary>
    public static class ElementsBuilderExtensions
    {
        /// <summary>
        /// Adds a button element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The button element.</param>
        /// <returns></returns>
        public static void AddButton(this IElementsBuilder<Button> builder, Button element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a button element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the button's text. Can only be of type: plain_text. text may truncate with ~30 characters. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when the button is clicked. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="url">A URL to load in the user's browser when the button is clicked. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.</param>
        /// <param name="value">The value to send along with the interaction payload. Maximum length for this field is 2000 characters.</param>
        /// <param name="style">Decorates buttons with alternative visual color schemes. Use this option with restraint.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog after the button is clicked.</param>
        /// <param name="accessibilityLabel">A label for longer descriptive text about a button element. This label will be read out by screen readers instead of the button text object. Maximum length for this field is 75 characters.</param>
        /// <returns></returns>
        public static void AddButton(this IElementsBuilder<Button> builder, string text, string actionId, string? url = null, string? value = null, ButtonStyle? style = null, Confirm? confirmDialog = null, string? accessibilityLabel = null)
        {
            builder.AddButton(new Button(new PlainText(text), actionId, url, value, style, confirmDialog, accessibilityLabel));
        }

        /// <summary>
        /// Adds a button element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The button element.</param>
        /// <returns></returns>
        public static Button AddButton(this IElementBuilder<Button> builder, Button element)
        {
            return element;
        }

        /// <summary>
        /// Adds a button element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">A text object that defines the button's text. Can only be of type: plain_text. text may truncate with ~30 characters. Maximum length for the text in this field is 75 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when the button is clicked. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="url">A URL to load in the user's browser when the button is clicked. Maximum length for this field is 3000 characters. If you're using url, you'll still receive an interaction payload and will need to send an acknowledgement response.</param>
        /// <param name="value">The value to send along with the interaction payload. Maximum length for this field is 2000 characters.</param>
        /// <param name="style">Decorates buttons with alternative visual color schemes. Use this option with restraint.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog after the button is clicked.</param>
        /// <param name="accessibilityLabel">A label for longer descriptive text about a button element. This label will be read out by screen readers instead of the button text object. Maximum length for this field is 75 characters.</param>
        public static Button AddButton(this IElementBuilder<Button> builder, string text, string actionId, string? url = null, string? value = null, ButtonStyle? style = null, Confirm? confirmDialog = null, string? accessibilityLabel = null)
        {
            return builder.AddButton(new Button(new PlainText(text), actionId, url, value, style, confirmDialog, accessibilityLabel));
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The checkboxes element.</param>
        /// <returns></returns>
        public static void AddCheckboxes(this IElementsBuilder<Checkboxes> builder, Checkboxes element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddCheckboxes(this IElementsBuilder<Checkboxes> builder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A build to create options.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddCheckboxes(this IElementsBuilder<Checkboxes> builder, string actionId, Action<IOptionsBuilder<Checkboxes>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<Checkboxes>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The checkboxes element.</param>
        /// <returns></returns>
        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, Checkboxes element)
        {
            return element;
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a checkboxes element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when the checkbox group is changed. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A build to create options.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly matches one or more of the options within options. These options will be selected when the checkbox group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static Checkboxes AddCheckboxes(this IElementBuilder<Checkboxes> builder, string actionId, Action<IOptionsBuilder<Checkboxes>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<Checkboxes>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddCheckboxes(new Checkboxes(actionId, options, initialOptions, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a date picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The date picker element.</param>
        /// <returns></returns>
        public static void AddDatePicker(this IElementsBuilder<DatePicker> builder, DatePicker element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a date picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the datepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialDate">The initial date that is selected when the element is loaded. This should be in the format YYYY-MM-DD.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a date is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddDatePicker(this IElementsBuilder<DatePicker> builder, string actionId, string? placeholder = null, DateTime? initialDate = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddDatePicker(new DatePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialDate, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a date picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The date picker element.</param>
        /// <returns></returns>
        public static DatePicker AddDatePicker(this IElementBuilder<DatePicker> builder, DatePicker element)
        {
            return element;
        }

        /// <summary>
        /// Adds a date picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the datepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialDate">The initial date that is selected when the element is loaded. This should be in the format YYYY-MM-DD.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a date is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static DatePicker AddDatePicker(this IElementBuilder<DatePicker> builder, string actionId, string? placeholder = null, DateTime? initialDate = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddDatePicker(new DatePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialDate, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds an image element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The image element.</param>
        /// <returns></returns>
        public static void AddImage(this IElementsBuilder<ImageElement> builder, ImageElement element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds an image element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="url">The URL of the image to be displayed.</param>
        /// <param name="alternativeText">A plain-text summary of the image. This should not contain any markup.</param>
        /// <returns></returns>
        public static void AddImage(this IElementsBuilder<ImageElement> builder, string url, string alternativeText = "")
        {
            builder.AddImage(new ImageElement(url, alternativeText));
        }

        /// <summary>
        /// Adds an image element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The image element.</param>
        /// <returns></returns>
        public static ImageElement AddImage(this IElementBuilder<ImageElement> builder, ImageElement element)
        {
            return element;
        }

        /// <summary>
        /// Adds an image element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="url">The URL of the image to be displayed.</param>
        /// <param name="alternativeText">A plain-text summary of the image. This should not contain any markup.</param>
        /// <returns></returns>
        public static ImageElement AddImage(this IElementBuilder<ImageElement> builder, string url, string alternativeText = "")
        {
            return builder.AddImage(new ImageElement(url, alternativeText));
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The overflow element.</param>
        /// <returns></returns>
        public static void AddOverflow(this IElementsBuilder<Overflow> builder, Overflow element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of up to five option objects to display in the menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <returns></returns>
        public static void AddOverflow(this IElementsBuilder<Overflow> builder, string actionId, IEnumerable<Option> options, Confirm? confirmDialog = null)
        {
            builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A builder for the options.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <returns></returns>
        public static void AddOverflow(this IElementsBuilder<Overflow> builder, string actionId, Action<IOptionsBuilder<Overflow>> optionsBuilderAction, Confirm? confirmDialog = null)
        {
            var optionsBuilder = new OptionsBuilder<Overflow>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The overflow element.</param>
        /// <returns></returns>
        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, Overflow element)
        {
            return element;
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of up to five option objects to display in the menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <returns></returns>
        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, string actionId, IEnumerable<Option> options, Confirm? confirmDialog = null)
        {
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        /// <summary>
        /// Adds an overflow element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A builder for the options.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <returns></returns>
        public static Overflow AddOverflow(this IElementBuilder<Overflow> builder, string actionId, Action<IOptionsBuilder<Overflow>> optionsBuilderAction, Confirm? confirmDialog = null)
        {
            var optionsBuilder = new OptionsBuilder<Overflow>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddOverflow(new Overflow(actionId, options, confirmDialog));
        }

        /// <summary>
        /// Adds a text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The text element.</param>
        /// <returns></returns>
        public static void AddText(this IElementsBuilder<TextObject> builder, TextObject element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="emoji">Indicates whether emojis in a text field should be escaped into the colon emoji format.</param>
        /// <returns></returns>
        public static void AddText(this IElementsBuilder<TextObject> builder, string text, bool? emoji = null)
        {
            builder.AddText(new PlainText(text, emoji));
        }

        /// <summary>
        /// Adds a text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The text element.</param>
        /// <returns></returns>
        public static TextObject AddText(this IElementBuilder<TextObject> builder, TextObject element)
        {
            return element;
        }

        /// <summary>
        /// Adds a text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="emoji">Indicates whether emojis in a text field should be escaped into the colon emoji format.</param>
        /// <returns></returns>
        public static TextObject AddText(this IElementBuilder<TextObject> builder, string text, bool? emoji = null)
        {
            return builder.AddText(new PlainText(text, emoji));
        }

        /// <summary>
        /// Adds a markdown text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="verbatim">When set to false (as is default) URLs will be auto-converted into links, conversation names will be link-ified, and certain mentions will be <a href="https://api.slack.com/reference/surfaces/formatting#automatic-parsing">automatically parsed</a>. Using a value of true will skip any preprocessing of this nature, although you can still include manual parsing strings.</param>
        /// <returns></returns>
        public static void AddMarkdown(this IElementsBuilder<TextObject> builder, string text, bool? verbatim = null)
        {
            builder.AddText(new MarkdownText(text, verbatim));
        }

        /// <summary>
        /// Adds a markdown text element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn. The maximum length is 3000 characters.</param>
        /// <param name="verbatim">When set to false (as is default) URLs will be auto-converted into links, conversation names will be link-ified, and certain mentions will be <a href="https://api.slack.com/reference/surfaces/formatting#automatic-parsing">automatically parsed</a>. Using a value of true will skip any preprocessing of this nature, although you can still include manual parsing strings.</param>
        /// <returns></returns>
        public static TextObject AddMarkdown(this IElementBuilder<TextObject> builder, string text, bool? verbatim = null)
        {
            return builder.AddText(new MarkdownText(text, verbatim));
        }

        /// <summary>
        /// Adds a text input elemment.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The text input element.</param>
        /// <returns></returns>
        public static void AddTextInput(this IElementsBuilder<PlainTextInput> builder, PlainTextInput element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a text input elemment.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the input value when the parent modal is submitted. You can use this when you receive a view_submission payload to identify the value of the input element. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown in the plain-text input. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialValue">The initial value in the plain-text input when it is loaded.</param>
        /// <param name="multiline">Indicates whether the input will be a single line (false) or a larger textarea (true). Defaults to false.</param>
        /// <param name="minLength">The minimum length of input that the user must provide. If the user provides less, they will receive an error. Maximum value is 3000.</param>
        /// <param name="maxLength">The maximum length of input that the user can provide. If the user provides more, they will receive an error.</param>
        /// <param name="dispatchActionConfig">A dispatch configuration object that determines when during text input the element returns a block_actions payload.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddTextInput(this IElementsBuilder<PlainTextInput> builder, string actionId, string? placeholder = null, string? initialValue = null, bool? multiline = null, int? minLength = null, int? maxLength = null, DispatchActionConfig? dispatchActionConfig = null, bool? focusOnLoad = null)
        {
            builder.AddTextInput(new PlainTextInput(actionId, placeholder is null ? null : new PlainText(placeholder), initialValue, multiline, minLength, maxLength, dispatchActionConfig, focusOnLoad));
        }

        /// <summary>
        /// Adds a text input elemment.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The text input element.</param>
        /// <returns></returns>
        public static PlainTextInput AddTextInput(this IElementBuilder<PlainTextInput> builder, PlainTextInput element)
        {
            return element;
        }

        /// <summary>
        /// Adds a text input elemment.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the input value when the parent modal is submitted. You can use this when you receive a view_submission payload to identify the value of the input element. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown in the plain-text input. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialValue">The initial value in the plain-text input when it is loaded.</param>
        /// <param name="multiline">Indicates whether the input will be a single line (false) or a larger textarea (true). Defaults to false.</param>
        /// <param name="minLength">The minimum length of input that the user must provide. If the user provides less, they will receive an error. Maximum value is 3000.</param>
        /// <param name="maxLength">The maximum length of input that the user can provide. If the user provides more, they will receive an error.</param>
        /// <param name="dispatchActionConfig">A dispatch configuration object that determines when during text input the element returns a block_actions payload.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static PlainTextInput AddTextInput(this IElementBuilder<PlainTextInput> builder, string actionId, string? placeholder = null, string? initialValue = null, bool? multiline = null, int? minLength = null, int? maxLength = null, DispatchActionConfig? dispatchActionConfig = null, bool? focusOnLoad = null)
        {
            return builder.AddTextInput(new PlainTextInput(actionId, placeholder is null ? null : new PlainText(placeholder), initialValue, multiline, minLength, maxLength, dispatchActionConfig, focusOnLoad));
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The radio buttons element.</param>
        /// <returns></returns>
        public static void AddRadioButtons(this IElementsBuilder<RadioButtons> builder, RadioButtons element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOption">An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddRadioButtons(this IElementsBuilder<RadioButtons> builder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A builder for options.</param>
        /// <param name="initialOption">An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddRadioButtons(this IElementsBuilder<RadioButtons> builder, string actionId, Action<IOptionsBuilder<RadioButtons>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<RadioButtons>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The radio buttons element.</param>
        /// <returns></returns>
        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, RadioButtons element)
        {
            return element;
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOption">An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a radio buttons element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">A builder for options.</param>
        /// <param name="initialOption">An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static RadioButtons AddRadioButtons(this IElementBuilder<RadioButtons> builder, string actionId, Action<IOptionsBuilder<RadioButtons>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<RadioButtons>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddRadioButtons(new RadioButtons(actionId, options, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a time picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The time picker element.</param>
        /// <returns></returns>
        public static void AddTimePicker(this IElementsBuilder<TimePicker> builder, TimePicker element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a time picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the timepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialTime">The initial time that is selected when the element is loaded. This should be in the format HH:mm, where HH is the 24-hour format of an hour (00 to 23) and mm is minutes with leading zeros (00 to 59), for example 22:25 for 10:25pm.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddTimePicker(this IElementsBuilder<TimePicker> builder, string actionId, string? placeholder = null, TimeSpan? initialTime = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddTimePicker(new TimePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialTime, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a time picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The time picker element.</param>
        /// <returns></returns>
        public static TimePicker AddTimePicker(this IElementBuilder<TimePicker> builder, TimePicker element)
        {
            return element;
        }

        /// <summary>
        /// Adds a time picker element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to identify the source of the action. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the timepicker. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialTime">The initial time that is selected when the element is loaded. This should be in the format HH:mm, where HH is the 24-hour format of an hour (00 to 23) and mm is minutes with leading zeros (00 to 59), for example 22:25 for 10:25pm.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the checkboxes in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static TimePicker AddTimePicker(this IElementBuilder<TimePicker> builder, string actionId, string? placeholder = null, TimeSpan? initialTime = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddTimePicker(new TimePicker(actionId, placeholder is null ? null : new PlainText(placeholder), initialTime, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The static select element.</param>
        /// <returns></returns>
        public static void AddStaticSelect(this IElementsBuilder<StaticSelect> builder, StaticSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a static select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticSelect>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsGroupsBuilderAction">An option groups builder action.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticSelect(this IElementsBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsGroupsBuilder<StaticSelect>> optionsGroupsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsGroupBuilder = new OptionsGroupsBuilder<StaticSelect>();
            optionsGroupsBuilderAction(optionsGroupBuilder);
            var optionGroups = optionsGroupBuilder.Build();
            builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The static select element.</param>
        /// <returns></returns>
        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, StaticSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a static select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticSelect>> optionsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, options, null, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsGroupsBuilderAction">An option groups builder action.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within options or option_groups. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static StaticSelect AddStaticSelect(this IElementBuilder<StaticSelect> builder, string placeholder, string actionId, Action<IOptionsGroupsBuilder<StaticSelect>> optionsGroupsBuilderAction, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsGroupBuilder = new OptionsGroupsBuilder<StaticSelect>();
            optionsGroupsBuilderAction(optionsGroupBuilder);
            var optionGroups = optionsGroupBuilder.Build();
            return builder.AddStaticSelect(new StaticSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The static multi select element.</param>
        /// <returns></returns>
        public static void AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, StaticMultiSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a static multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticMultiSelect>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticMultiSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static void AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsGroupsBuilderAction">An option groups builder action.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static void AddStaticMultiSelect(this IElementsBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsGroupsBuilder<StaticMultiSelect>> optionsGroupsBuilderAction, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionGroupsBuilder = new OptionsGroupsBuilder<StaticMultiSelect>();
            optionsGroupsBuilderAction(optionGroupsBuilder);
            var optionGroups = optionGroupsBuilder.Build();
            builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">The static multi select element.</param>
        /// <returns></returns>
        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, StaticMultiSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a static multi select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. Maximum number of options is 100. If option_groups is specified, this field should not be.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<Option> options, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsBuilderAction">An options builder action.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsBuilder<StaticMultiSelect>> optionsBuilderAction, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsBuilder = new OptionsBuilder<StaticMultiSelect>();
            optionsBuilderAction(optionsBuilder);
            var options = optionsBuilder.Build();
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, options, null, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionGroups">An array of <see cref="OptionsGroup"/> objects. Maximum number of option groups is 100. If options is specified, this field should not be.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, IEnumerable<OptionsGroup> optionGroups, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a static multi select element with option groups.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="optionsGroupsBuilderAction">An option groups builder action.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static StaticMultiSelect AddStaticMultiSelect(this IElementBuilder<StaticMultiSelect> builder, string placeholder, string actionId, Action<IOptionsGroupsBuilder<StaticMultiSelect>> optionsGroupsBuilderAction, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            var optionsGroupsBuilder = new OptionsGroupsBuilder<StaticMultiSelect>();
            optionsGroupsBuilderAction(optionsGroupsBuilder);
            var optionGroups = optionsGroupsBuilder.Build();
            return builder.AddStaticMultiSelect(new StaticMultiSelect(new PlainText(placeholder), actionId, null, optionGroups, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds an external data select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">An external data select element.</param>
        /// <returns></returns>
        public static void AddExternalDataSelect(this IElementsBuilder<ExternalDataSelect> builder, ExternalDataSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds an external data select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within the options or option_groups loaded from the external data source. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddExternalDataSelect(this IElementsBuilder<ExternalDataSelect> builder, string placeholder, string actionId, int? minQueryLength = null, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddExternalDataSelect(new ExternalDataSelect(new PlainText(placeholder), actionId, minQueryLength, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds an external data select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">An external data select element.</param>
        /// <returns></returns>
        public static ExternalDataSelect AddExternalDataSelect(this IElementBuilder<ExternalDataSelect> builder, ExternalDataSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds an external data select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOption">A single option that exactly matches one of the options within the options or option_groups loaded from the external data source. This option will be selected when the menu initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public static ExternalDataSelect AddExternalDataSelect(this IElementBuilder<ExternalDataSelect> builder, string placeholder, string actionId, int? minQueryLength = null, Option? initialOption = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataSelect(new ExternalDataSelect(new PlainText(placeholder), actionId, minQueryLength, initialOption, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds an external data multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">An external data multi select element.</param>
        /// <returns></returns>
        public static void AddExternalDataMultiSelect(this IElementsBuilder<ExternalDataMultiSelect> builder, ExternalDataMultiSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds an external data multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddExternalDataMultiSelect(this IElementsBuilder<ExternalDataMultiSelect> builder, string placeholder, string actionId, int? minQueryLength = null, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddExternalDataMultiSelect(new ExternalDataMultiSelect(new PlainText(placeholder), actionId, minQueryLength, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds an external data multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">An external data multi select element.</param>
        /// <returns></returns>
        public static ExternalDataMultiSelect AddExternalDataMultiSelect(this IElementBuilder<ExternalDataMultiSelect> builder, ExternalDataMultiSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds an external data multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="minQueryLength">When the typeahead field is used, a request will be sent on every character change. If you prefer fewer requests or more fully ideated queries, use the min_query_length attribute to tell Slack the fewest number of typed characters required before dispatch. The default value is 3.</param>
        /// <param name="initialOptions">An array of <see cref="Option"/> objects that exactly match one or more of the options within options or option_groups. These options will be selected when the menu initially loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static ExternalDataMultiSelect AddExternalDataMultiSelect(this IElementBuilder<ExternalDataMultiSelect> builder, string placeholder, string actionId, int? minQueryLength = null, IEnumerable<Option>? initialOptions = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddExternalDataMultiSelect(new ExternalDataMultiSelect(new PlainText(placeholder), actionId, minQueryLength, initialOptions, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a user select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A user select element.</param>
        /// <returns></returns>
        public static void AddUsersSelect(this IElementsBuilder<UsersSelect> builder, UsersSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a user select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUser">The user ID of any valid user to be pre-selected when the menu loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddUsersSelect(this IElementsBuilder<UsersSelect> builder, string placeholder, string actionId, string? initialUser = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddUsersSelect(new UsersSelect(new PlainText(placeholder), actionId, initialUser, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a user select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A user select element.</param>
        /// <returns></returns>
        public static UsersSelect AddUsersSelect(this IElementBuilder<UsersSelect> builder, UsersSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a user select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUser">The user ID of any valid user to be pre-selected when the menu loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static UsersSelect AddUsersSelect(this IElementBuilder<UsersSelect> builder, string placeholder, string actionId, string? initialUser = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersSelect(new UsersSelect(new PlainText(placeholder), actionId, initialUser, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a user multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A user multi select element.</param>
        /// <returns></returns>
        public static void AddUsersMultiSelect(this IElementsBuilder<UsersMultiSelect> builder, UsersMultiSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a user multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUsers">An array of user IDs of any valid users to be pre-selected when the menu loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddUsersMultiSelect(this IElementsBuilder<UsersMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialUsers = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddUsersMultiSelect(new UsersMultiSelect(new PlainText(placeholder), actionId, initialUsers, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a user multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A user multi select element.</param>
        /// <returns></returns>
        public static UsersMultiSelect AddUsersMultiSelect(this IElementBuilder<UsersMultiSelect> builder, UsersMultiSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a user multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialUsers">An array of user IDs of any valid users to be pre-selected when the menu loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static UsersMultiSelect AddUsersMultiSelect(this IElementBuilder<UsersMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialUsers = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddUsersMultiSelect(new UsersMultiSelect(new PlainText(placeholder), actionId, initialUsers, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a conversation select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A conversation select element.</param>
        /// <returns></returns>
        public static void AddConversationsSelect(this IElementsBuilder<ConversationsSelect> builder, ConversationsSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a conversation select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialConversation">The ID of any valid conversation to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversation will take precedence.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddConversationsSelect(this IElementsBuilder<ConversationsSelect> builder, string placeholder, string actionId, string? initialConversation = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            builder.AddConversationsSelect(new ConversationsSelect(new PlainText(placeholder), actionId, initialConversation, filter, defaultToCurrentConversation, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a conversation select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A conversation select element.</param>
        /// <returns></returns>
        public static ConversationsSelect AddConversationsSelect(this IElementBuilder<ConversationsSelect> builder, ConversationsSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a conversation select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialConversation">The ID of any valid conversation to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversation will take precedence.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static ConversationsSelect AddConversationsSelect(this IElementBuilder<ConversationsSelect> builder, string placeholder, string actionId, string? initialConversation = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsSelect(new ConversationsSelect(new PlainText(placeholder), actionId, initialConversation, filter, defaultToCurrentConversation, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a conversation multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A conversation multi select element.</param>
        /// <returns></returns>
        public static void AddConversationsMultiSelect(this IElementsBuilder<ConversationsMultiSelect> builder, ConversationsMultiSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a conversation multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialConversations">An array of one or more IDs of any valid conversations to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversations will be ignored.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddConversationsMultiSelect(this IElementsBuilder<ConversationsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialConversations = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            builder.AddConversationsMultiSelect(new ConversationsMultiSelect(new PlainText(placeholder), actionId, initialConversations, filter, defaultToCurrentConversation, responseUrlEnabled, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a conversation multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A conversation multi select element.</param>
        /// <returns></returns>
        public static ConversationsMultiSelect AddConversationsMultiSelect(this IElementBuilder<ConversationsMultiSelect> builder, ConversationsMultiSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a conversation multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialConversations">An array of one or more IDs of any valid conversations to be pre-selected when the menu loads. If default_to_current_conversation is also supplied, initial_conversations will be ignored.</param>
        /// <param name="defaultToCurrentConversation">Pre-populates the select menu with the conversation that the user was viewing when they opened the modal, if available. Default is false.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target conversation for the message will be determined by the value of this select menu.</param>
        /// <param name="filter">A <see cref="ConversationFilter"/> object that reduces the list of available conversations using the specified criteria.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static ConversationsMultiSelect AddConversationsMultiSelect(this IElementBuilder<ConversationsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialConversations = null, ConversationFilter? filter = null, bool defaultToCurrentConversation = false, bool responseUrlEnabled = false, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool focusOnLoad = false)
        {
            return builder.AddConversationsMultiSelect(new ConversationsMultiSelect(new PlainText(placeholder), actionId, initialConversations, filter, defaultToCurrentConversation, responseUrlEnabled, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a public channels select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A public channels select element.</param>
        /// <returns></returns>
        public static void AddPublicChannelsSelect(this IElementsBuilder<PublicChannelsSelect> builder, PublicChannelsSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a public channels select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialChannel">The ID of any valid public channel to be pre-selected when the menu loads.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target channel for the message will be determined by the value of this select menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddPublicChannelsSelect(this IElementsBuilder<PublicChannelsSelect> builder, string placeholder, string actionId, string? initialChannel = null, bool? responseUrlEnabled = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddPublicChannelsSelect(new PublicChannelsSelect(new PlainText(placeholder), actionId, initialChannel, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a public channels select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A public channels select element.</param>
        /// <returns></returns>
        public static PublicChannelsSelect AddPublicChannelsSelect(this IElementBuilder<PublicChannelsSelect> builder, PublicChannelsSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a public channels select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialChannel">The ID of any valid public channel to be pre-selected when the menu loads.</param>
        /// <param name="responseUrlEnabled">When set to true, the view_submission payload from the menu's parent view will contain a response_url. This response_url can be used for message responses. The target channel for the message will be determined by the value of this select menu.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static PublicChannelsSelect AddPublicChannelsSelect(this IElementBuilder<PublicChannelsSelect> builder, string placeholder, string actionId, string? initialChannel = null, bool? responseUrlEnabled = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsSelect(new PublicChannelsSelect(new PlainText(placeholder), actionId, initialChannel, responseUrlEnabled, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a public channels multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A public channels multi select element.</param>
        /// <returns></returns>
        public static void AddPublicChannelsMultiSelect(this IElementsBuilder<PublicChannelsMultiSelect> builder, PublicChannelsMultiSelect element)
        {
            builder.AddElement(element);
        }

        /// <summary>
        /// Adds a public channels multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialChannels">An array of one or more IDs of any valid public channel to be pre-selected when the menu loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static void AddPublicChannelsMultiSelect(this IElementsBuilder<PublicChannelsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialChannels = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            builder.AddPublicChannelsMultiSelect(new PublicChannelsMultiSelect(new PlainText(placeholder), actionId, initialChannels, maxSelectedItems, confirmDialog, focusOnLoad));
        }

        /// <summary>
        /// Adds a public channels multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="element">A public channels multi select element.</param>
        /// <returns></returns>
        public static PublicChannelsMultiSelect AddPublicChannelsMultiSelect(this IElementBuilder<PublicChannelsMultiSelect> builder, PublicChannelsMultiSelect element)
        {
            return element;
        }

        /// <summary>
        /// Adds a public channels multi select element.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown on the menu. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="initialChannels">An array of one or more IDs of any valid public channel to be pre-selected when the menu loads.</param>
        /// <param name="maxSelectedItems">Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after a menu item is selected.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        /// <returns></returns>
        public static PublicChannelsMultiSelect AddPublicChannelsMultiSelect(this IElementBuilder<PublicChannelsMultiSelect> builder, string placeholder, string actionId, IEnumerable<string>? initialChannels = null, int? maxSelectedItems = null, Confirm? confirmDialog = null, bool? focusOnLoad = null)
        {
            return builder.AddPublicChannelsMultiSelect(new PublicChannelsMultiSelect(new PlainText(placeholder), actionId, initialChannels, maxSelectedItems, confirmDialog, focusOnLoad));
        }
    }
}