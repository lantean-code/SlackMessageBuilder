using System.Text.Json.Serialization;

namespace SlackMessageBuilder
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
        [JsonPropertyName("image_url")]
        public string Url { get; }

        /// <summary>
        /// A plain-text summary of the image. This should not contain any markup.
        /// </summary>
        [JsonPropertyName("alt_text")]
        public string AlternativeText { get; }
    }
}