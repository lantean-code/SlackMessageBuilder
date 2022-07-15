namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Parse options extensions.
    /// </summary>
    public static class ParseOptionsExtensions
    {
        /// <summary>
        /// Converts <see cref="ParseOptions"/> to the Slack API value.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string? ToValue(this ParseOptions options)
        {
            return options switch
            {
                ParseOptions.None => "none",
                ParseOptions.Full => "full",
                _ => null
            };
        }
    }
}