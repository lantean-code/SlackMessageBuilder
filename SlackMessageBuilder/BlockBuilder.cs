using System.Collections.Generic;

namespace SlackMessageBuilder
{
    internal class BlocksBuilder : IBlocksBuilder
    {
        private readonly List<IBlockElement> _blocks = new List<IBlockElement>();

        internal IReadOnlyList<IBlockElement> Build()
        {
            return _blocks.AsReadOnly();
        }

        public IBlocksBuilder AddBlock(IBlockElement block)
        {
            _blocks.Add(block);
            return this;
        }
    }
}