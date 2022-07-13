using System.Collections.Generic;

namespace SlackMessageBuilder.Builders
{
    internal class OptionsGroupsBuilder<T> : IOptionsGroupsBuilder<T>
    {
        private readonly List<OptionsGroup> _optionsGroups = new List<OptionsGroup>();

        public IOptionsGroupsBuilder<T> AddOptionsGroup(OptionsGroup optionsGroup)
        {
            _optionsGroups.Add(optionsGroup);
            return this;
        }

        internal IReadOnlyList<OptionsGroup> Build()
        {
            return _optionsGroups.AsReadOnly();
        }
    }
}