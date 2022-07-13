
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
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("type", Order = -1)]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonPropertyOrder(-1)]
#endif
        public string Type { get; }
    }
}