using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    public class Attachment
    {
        public Attachment(
            string text,
            string? color = null,
            IEnumerable<IBlockElement>? blocks = null)
        {
            Text = text;
            Color = color;
            Blocks = blocks;
        }

        [JsonPropertyName("text")]
        public string Text { get; }

        [JsonPropertyName("blocks")]
        public IEnumerable<IBlockElement>? Blocks { get; }

        [JsonPropertyName("color")]
        public string? Color { get; }
    }
}