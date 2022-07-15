namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Url encoded metadata for the message.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata"/> class.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventPayload">The event payload.</param>
        public Metadata(string eventType, string eventPayload)
        {
            EventType = eventType;
            EventPayload = eventPayload;
        }

        /// <summary>
        /// The event type.
        /// </summary>
        public string EventType { get; }

        /// <summary>
        /// The event payload.
        /// </summary>
        public string EventPayload { get; }
    }
}
