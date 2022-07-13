namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    public interface IBlocksBuilder
    {
        /// <summary>
        /// Adds a block element to the array.
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        IBlocksBuilder AddBlock(IBlockElement block);
    }
}