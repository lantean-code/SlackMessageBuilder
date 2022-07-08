using System;
using System.Collections.Generic;

namespace SlackMessageBuilder.Builders
{
    public class AttachmentBuilder
    {
        private HashSet<string>? _markdownIn;
        private List<IBlockElement>? _blocks;

        private string? _text;
        private string? _color;

        internal void SetText(string text)
        {
            _text = text;
        }

        internal void SetColor(string color)
        {
            _color = color;
        }

        internal void AddMarkdownIn(string field)
        {
            _markdownIn ??= new HashSet<string>();
            _markdownIn.Add(field);
        }

        internal void AddBlocks(IEnumerable<IBlockElement> blocks)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.AddRange(blocks);
        }

        internal void AddBlock(IBlockElement block)
        {
            _blocks ??= new List<IBlockElement>();
            _blocks.Add(block);
        }

        internal Attachment Build()
        {
            if (_text is null)
            {
                throw new InvalidOperationException("Text is required to build an Attachment.");
            }

            var attachment = new Attachment(_text, _color, _blocks);
            return attachment;
        }
    }
}