namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// A simple image block, designed to make those cat photos really pop.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/blocks#image">https://api.slack.com/reference/block-kit/blocks#image</a>
    /// </summary>
    public class ImageBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlock"/> class.
        /// </summary>
        /// <param name="url">The URL of the image to be displayed.</param>
        /// <param name="alternativeText">A plain-text summary of the image. This should not contain any markup. Maximum length for this field is 2000 characters.</param>
        /// <param name="title">An optional title for the image in the form of a text object that can only be of type: plain_text. Maximum length for the text in this field is 2000 characters.</param>
        /// <param name="blockId">A string acting as a unique identifier for a block. If not specified, one will be generated. Maximum length for this field is 255 characters. block_id should be unique for each message and each iteration of a message. If a message is updated, use a new block_id.</param>
        public ImageBlock(string url, string alternativeText = "", PlainText? title = null, string? blockId = null) : base("image", blockId)
        {
            Url = url;
            AlternativeText = alternativeText;
            Title = title;
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
        /// A plain-text summary of the image. This should not contain any markup. Maximum length for this field is 2000 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("alt_text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("alt_text")]
#endif
        public string AlternativeText { get; }

        /// <summary>
        /// An optional title for the image in the form of a text object that can only be of type: plain_text. Maximum length for the text in this field is 2000 characters.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("title")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("title")]
#endif
        public PlainText? Title { get; }
    }
}