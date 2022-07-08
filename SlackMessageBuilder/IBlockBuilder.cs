namespace SlackMessageBuilder
{
    public interface IBlocksBuilder
    {
        IBlocksBuilder AddBlock(IBlockElement block);
    }
}