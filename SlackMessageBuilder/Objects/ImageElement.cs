namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// An element to insert an image as part of a larger block of content.
    /// </summary>
    public class ImageElement : TypedObject, IContextElement, ISectionElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageElement"/> class.
        /// </summary>
        /// <param name="url">The URL of the image to be displayed.</param>
        /// <param name="alternativeText">A plain-text summary of the image. This should not contain any markup.</param>
        public ImageElement(string url, string alternativeText = "") : base("image")
        {
            Url = url;
            AlternativeText = alternativeText ?? "";
        }

        /// <summary>
        /// The URL of the image to be displayed.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("image_url")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
#endif
        public string Url { get; }

        /// <summary>
        /// A plain-text summary of the image. This should not contain any markup.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("alt_text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("alt_text")]
#endif
        public string AlternativeText { get; }
    }
}