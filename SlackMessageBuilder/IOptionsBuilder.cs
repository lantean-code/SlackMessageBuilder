namespace SlackMessageBuilder
{
    public interface IOptionsBuilder<in T>
    {
        IOptionsBuilder<T> AddOption(Option option);
    }
}