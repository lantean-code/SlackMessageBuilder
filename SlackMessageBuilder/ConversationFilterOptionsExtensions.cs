using System.Collections.Generic;

namespace SlackMessageBuilder
{
    public static class ConversationFilterOptionsExtensions
    {
        public static ConversationFilter ToConversationFilter(this ConversationFilterOptions options)
        {
            var include = new List<string>(4);
            if (options.HasFlag(ConversationFilterOptions.IncludeIm))
            {
                include.Add("im");
            }
            if (options.HasFlag(ConversationFilterOptions.IncludeMpim))
            {
                include.Add("mpim");
            }
            if (options.HasFlag(ConversationFilterOptions.IncludePrivate))
            {
                include.Add("private");
            }
            if (options.HasFlag(ConversationFilterOptions.IncludePublic))
            {
                include.Add("public");
            }
            if (options.HasFlag(ConversationFilterOptions.IncludeIm))
            {
                include.Add("im");
            }
            var excludeExternalSharedChannels = options.HasFlag(ConversationFilterOptions.ExcludeExternalSharedChannels);
            var excludeBotUsers = options.HasFlag(ConversationFilterOptions.ExcludeBotUsers);
            var filter = new ConversationFilter(include, excludeExternalSharedChannels, excludeBotUsers);
            return filter;
        }
    }
}