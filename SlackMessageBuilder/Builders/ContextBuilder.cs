using System.Collections.Generic;

namespace Slack.MessageBuilder.Builders
{
    internal class ContextBuilder : IElementsBuilder<IContextElement>
    {
        private readonly List<IContextElement> _elements = new List<IContextElement>();

        internal IReadOnlyList<IContextElement> Build()
        {
            return _elements.AsReadOnly();
        }

        public IElementsBuilder<IContextElement> AddElement(IContextElement element)
        {
            _elements.Add(element);
            return this;
        }
    }
}