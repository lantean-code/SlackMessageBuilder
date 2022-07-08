using System;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    [Flags]
    public enum ConversationFilterOptions
    {
        /// <summary>
        /// im
        /// </summary>
        IncludeIm = 1,

        /// <summary>
        /// mpim
        /// </summary>
        IncludeMpim = 2,

        /// <summary>
        /// private
        /// </summary>
        IncludePrivate = 4,

        /// <summary>
        /// public
        /// </summary>
        IncludePublic = 8,

        /// <summary>
        /// exclude_external_shared_channels
        /// </summary>
        ExcludeExternalSharedChannels = 16,

        /// <summary>
        /// exclude_bot_users
        /// </summary>
        ExcludeBotUsers = 32,
    }
}