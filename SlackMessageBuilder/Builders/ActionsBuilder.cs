using Slack.MessageBuilder;
using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    internal class ActionsBuilder : IElementsBuilder<IActionsElement>
    {
        private readonly List<IActionsElement> _elements = new List<IActionsElement>();

        internal IReadOnlyList<IActionsElement> Build()
        {
            return _elements.AsReadOnly();
        }

        public IElementsBuilder<IActionsElement> AddElement(IActionsElement element)
        {
            _elements.Add(element);
            return this;
        }
    }
}