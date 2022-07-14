namespace Slack.MessageBuilder.Objects
{
    public class Metadata
    {
        public Metadata(string eventType, string eventPayload)
        {
            EventType = eventType;
            EventPayload = eventPayload;
        }

        public string EventType { get; }

        public string EventPayload { get; }
    }
}
