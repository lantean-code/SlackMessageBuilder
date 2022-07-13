using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <inheritdoc />
    [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
    public class LegacyAttachment : Attachment
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="authorIcon">A valid URL that displays a small 16px by 16px image to the left of the author_name text. Will only work if author_name is present.</param>
        /// <param name="authorLink">A valid URL that will hyperlink the author_name text. Will only work if author_name is present.</param>
        /// <param name="authorName">Small text used to display the author's name.</param>
        /// <param name="fallback">A plain text summary of the attachment used in clients that don't show formatted text (eg. IRC, mobile notifications).</param>
        /// <param name="fields">An array of field objects that get displayed in a table-like way (See the example above). For best results, include no more than 2-3 field objects.</param>
        /// <param name="footer">Some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.</param>
        /// <param name="footerIcon">A valid URL to an image file that will be displayed beside the footer text. Will only work if author_name is present. We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.</param>
        /// <param name="imageUrl">A valid URL to an image file that will be displayed at the bottom of the attachment. We support GIF, JPEG, PNG, and BMP formats.</param>
        /// <param name="markdownIn">An array of field names that should be formatted by mrkdwn syntax.</param>
        /// <param name="pretext">Text that appears above the message attachment block. It can be formatted as plain text, or with mrkdwn by including it in the mrkdwn_in field.</param>
        /// <param name="text">The main body text of the attachment. It can be formatted as plain text, or with mrkdwn by including it in the mrkdwn_in field. The content will automatically collapse if it contains 700+ characters or 5+ line breaks, and will display a "Show more..." link to expand the content.</param>
        /// <param name="thumbnailUrl">A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.</param>
        /// <param name="title">Large title text near the top of the attachment.</param>
        /// <param name="titleLink">A valid URL that turns the title text into a hyperlink.</param>
        /// <param name="timestamp">An integer Unix timestamp that is used to related your attachment to a specific time. The attachment will display the additional timestamp value as part of the attachment's footer.</param>
        /// <param name="color">Changes the color of the border on the left side of this attachment from the default gray. Can either be one of good (green), warning (yellow), danger (red), or any hex color code (eg. #439FE0)</param>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        public LegacyAttachment(
            string? authorIcon = null,
            string? authorLink = null,
            string? authorName = null,
            string? fallback = null,
            IEnumerable<Field>? fields = null,
            string? footer = null,
            string? footerIcon = null,
            string? imageUrl = null,
            IEnumerable<string>? markdownIn = null,
            string? pretext = null,
            string? text = null,
            string? thumbnailUrl = null,
            string? title = null,
            string? titleLink = null,
            int? timestamp = null,
            string? color = null) : base(color)
        {
            AuthorIcon = authorIcon;
            AuthorLink = authorLink;
            AuthorName = authorName;
            Fallback = fallback;
            Fields = fields;
            Footer = footer;
            FooterIcon = footerIcon;
            ImageUrl = imageUrl;
            MarkdownIn = markdownIn;
            Pretext = pretext;
            Text = text;
            ThumbnailUrl = thumbnailUrl;
            Title = title;
            TitleLink = titleLink;
            Timestamp = timestamp;
        }

        /// <summary>
        /// A valid URL that displays a small 16px by 16px image to the left of the author_name text. Will only work if author_name is present.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("author_icon")]
        public string? AuthorIcon { get; }

        /// <summary>
        /// A valid URL that will hyperlink the author_name text. Will only work if author_name is present.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("author_icon")]
        public string? AuthorLink { get; }

        /// <summary>
        /// Small text used to display the author's name.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("author_name")]
        public string? AuthorName { get; }

        /// <summary>
        /// A plain text summary of the attachment used in clients that don't show formatted text (eg. IRC, mobile notifications).
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("fallback")]
        public string? Fallback { get; }

        /// <summary>
        /// An array of field objects that get displayed in a table-like way (See the example above). For best results, include no more than 2-3 field objects.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("fields")]
        public IEnumerable<Field>? Fields { get; }

        /// <summary>
        /// Some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("footer")]
        public string? Footer { get; }

        /// <summary>
        /// A valid URL to an image file that will be displayed beside the footer text. Will only work if author_name is present. We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("footer_icon")]
        public string? FooterIcon { get; }

        /// <summary>
        /// A valid URL to an image file that will be displayed at the bottom of the attachment. We support GIF, JPEG, PNG, and BMP formats.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; }

        /// <summary>
        /// An array of field names that should be formatted by mrkdwn syntax.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("mrkdwn_in")]
        public IEnumerable<string>? MarkdownIn { get; }

        /// <summary>
        /// Text that appears above the message attachment block. It can be formatted as plain text, or with mrkdwn by including it in the mrkdwn_in field.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("pretext")]
        public string? Pretext { get; }

        /// <summary>
        /// The main body text of the attachment. It can be formatted as plain text, or with mrkdwn by including it in the mrkdwn_in field. The content will automatically collapse if it contains 700+ characters or 5+ line breaks, and will display a "Show more..." link to expand the content.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("text")]
        public string? Text { get; }

        /// <summary>
        /// A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("thumb_url")]
        public string? ThumbnailUrl { get; }

        /// <summary>
        /// Large title text near the top of the attachment.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("title")]
        public string? Title { get; }

        /// <summary>
        /// A valid URL that turns the title text into a hyperlink.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("title_link")]
        public string? TitleLink { get; }

        /// <summary>
        /// An integer Unix timestamp that is used to related your attachment to a specific time. The attachment will display the additional timestamp value as part of the attachment's footer.
        /// </summary>
        [Obsolete("This is a legacy field. Legacy options may be subject to reductions in visibility or functionality.")]
        [JsonPropertyName("ts")]
        public int? Timestamp { get; }
    }
}