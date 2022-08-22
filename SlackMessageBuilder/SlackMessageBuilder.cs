﻿using Slack.MessageBuilder.Builders;
using Slack.MessageBuilder.Objects;

namespace Slack.MessageBuilder
{
    /// <summary>
    /// Fluent builder for <see cref="SlackMessage"/>s.
    /// </summary>
    public static class SlackMessageBuilder
    {
        /// <summary>
        /// Creates a new instance of the fluent message builder for API style messages.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackApiMessage> CreateApiMessage(string channel, string text, bool? isMarkdown = null)
        {
            var slackMessageBuilder = new MessageBuilder<SlackApiMessage>(text, isMarkdown);
            slackMessageBuilder.Channel = channel;
            return slackMessageBuilder;
        }

        /// <summary>
        /// Creates a new instance of the fluent message builder.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <returns></returns>
        public static MessageBuilder<SlackMessage> CreateMessage(string text, bool? isMarkdown = null)
        {
            return new MessageBuilder<SlackMessage>(text, isMarkdown);
        }

        /// <summary>
        /// Creates a new instance of the fluent message builder.
        /// </summary>
        /// <param name="text">The usage of this field changes depending on whether you're using blocks or not. If you are, this is used as a fallback string to display in notifications. If you aren't, this is the main body text of the message. It can be formatted as plain text, or with mrkdwn. This field is not enforced as required when using blocks, however it is highly recommended that you include it as the aforementioned fallback.</param>
        /// <param name="isMarkdown">Determines whether the text field is rendered according to mrkdwn formatting or not. Defaults to true.</param>
        /// <returns></returns>
        public static MessageBuilder<T> CreateMessage<T>(string text, bool? isMarkdown = null) where T : SlackMessageBase
        {
            return new MessageBuilder<T>(text, isMarkdown);
        }
    }
}