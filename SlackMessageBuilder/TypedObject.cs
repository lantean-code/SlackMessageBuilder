using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// The base of all typed objects.
    /// </summary>
    public abstract class TypedObject
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="TypedObject"/> class.
        /// </summary>
        /// <param name="type">The type of element.</param>
        protected TypedObject(string type)
        {
            Type = type;
        }

        /// <summary>
        /// The type of element.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonPropertyOrder(-1)]
        public string Type { get; }
    }
}