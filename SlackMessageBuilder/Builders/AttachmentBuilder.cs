using System;
using System.Collections.Generic;

namespace SlackMessageBuilder.Builders
{
    /// <summary>
    ///
    /// </summary>
    public class AttachmentBuilder
    {
        private List<IBlockElement>? _blocks;

        private string? _text;
        private string? _thumbnailUrl;
        private string? _title;
        private string? _titleLink;
        private int? _timestamp;
        private string? _color;
        private string? _authorIcon;
        private string? _authorLink;
        private string? _authorName;
        private string? _fallback;
        private IEnumerable<Field>? _fields;
        private string? _footer;
        private string? _footerIcon;
        private string? _imageUrl;
        private IEnumerable<string>? _markdownIn;
        private string? _pretext;

        /// <summary>
        /// Configures the attachment to use blocks using the action.
        /// </summary>
        /// <param name="blockBuilderAction"></param>
        /// <returns></returns>
        public AttachmentBuilder WithBlocks(Action<IBlocksBuilder> blockBuilderAction)
        {
            var blockBuilder = new BlocksBuilder();
            blockBuilderAction(blockBuilder);
            var blocks = blockBuilder.Build();
            return WithBlocks(blocks);
        }

        /// <summary>
        /// Configures the attachment to use blocks.
        /// </summary>
        /// <param name="blocks"></param>
        /// <returns></returns>
        public AttachmentBuilder WithBlocks(IEnumerable<IBlockElement> blocks)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.AddRange(blocks);

            return this;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public AttachmentBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }

        /// <summary>
        /// Configures the attachment to use legacy options.
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
        /// <returns></returns>
        public AttachmentBuilder WithLegacyOptions(
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
            string? color = null)
        {
            _authorIcon = authorIcon;
            _authorLink = authorLink;
            _authorName = authorName;
            _fallback = fallback;
            _fields = fields;
            _footer = footer;
            _footerIcon = footerIcon;
            _imageUrl = imageUrl;
            _markdownIn = markdownIn;
            _pretext = pretext;
            _text = text;
            _thumbnailUrl = thumbnailUrl;
            _title = title;
            _titleLink = titleLink;
            _timestamp = timestamp;
            _color = color;

            return this;
        }

        internal AttachmentBase Build()
        {
            if (_blocks is not null)
            {
                return new Attachment(_blocks, _color);
            }

#pragma warning disable CS0618 // Type or member is obsolete
            var attachment = new LegacyAttachment(
                _authorIcon,
                _authorLink,
                _authorName,
                _fallback,
                _fields,
                _footer,
                _footerIcon,
                _imageUrl,
                _markdownIn,
                _pretext,
                _text,
                _thumbnailUrl,
                _title,
                _titleLink,
                _timestamp,
                _color);
#pragma warning restore CS0618 // Type or member is obsolete
            return attachment;
        }
    }
}