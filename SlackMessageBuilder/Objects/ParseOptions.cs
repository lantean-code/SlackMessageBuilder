namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Options for parsing message text.
    /// </summary>
    public enum ParseOptions
    {
        /// <summary>
        /// Uses the default parsing based on the text type.
        /// </summary>
        Default,
        /// <summary>
        /// Removes hyperlinks in plain_text message formatting.
        /// </summary>
        None,

        /// <summary>
        /// Ignores markdown formatting for mrkdwn text.
        /// </summary>
        Full
    }
}