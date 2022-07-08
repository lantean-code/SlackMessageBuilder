using System.Collections.Generic;

namespace SlackMessageBuilder.Builders
{
    internal class OptionsBuilder<T> : IOptionsBuilder<T>
    {
        private readonly List<Option> _options = new List<Option>();

        public IOptionsBuilder<T> AddOption(Option option)
        {
            _options.Add(option);
            return this;
        }

        internal IReadOnlyList<Option> Build()
        {
            return _options.AsReadOnly();
        }
    }
}