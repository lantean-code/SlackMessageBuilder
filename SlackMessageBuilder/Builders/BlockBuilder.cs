using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    internal class BlocksBuilder : IBlocksBuilder
    {
        private readonly List<IBlockElement> _blocks = new List<IBlockElement>();

        public IBlocksBuilder AddBlock(IBlockElement block)
        {
            _blocks.Add(block);
            return this;
        }

        internal IReadOnlyList<IBlockElement> Build()
        {
            return _blocks.AsReadOnly();
        }
    }
}