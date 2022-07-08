namespace SlackMessageBuilder
{
    /// <summary>
    /// A builder that can create a list of elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IElementsBuilder<in T>
    {
        /// <summary>
        /// Adds an element to the builder.
        /// </summary>
        /// <param name="element">The element to be added.</param>
        /// <returns></returns>
        IElementsBuilder<T> AddElement(T element);
    }
}