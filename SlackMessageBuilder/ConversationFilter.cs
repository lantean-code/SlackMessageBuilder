using System;
using System.Collections.Generic;

namespace SlackMessageBuilder
{
    /// <summary>
    /// Provides a way to filter the list of options in a conversations select menu or conversations multi-select menu.
    ///
    /// Please note that while none of the fields are individually required, you must supply at least one of these fields.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#filter_conversations">https://api.slack.com/reference/block-kit/composition-objects#filter_conversations</a>
    /// </summary>
    public class ConversationFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFilter"/> class.
        /// </summary>
        /// <param name="include">Indicates which type of conversations should be included in the list. When this field is provided, any conversations that do not match will be excluded. You should provide an array of strings from the following options: im, mpim, private, and public. The array cannot be empty.</param>
        /// <param name="excludeExternalSharedChannels">Indicates whether to exclude external <a href="https://api.slack.com/enterprise/shared-channels">shared channels</a> from conversation lists. Defaults to false.</param>
        /// <param name="excludeBotUsers">Indicates whether to exclude bot users from conversation lists. Defaults to false.</param>
        public ConversationFilter(IEnumerable<string>? include, bool? excludeExternalSharedChannels = null, bool? excludeBotUsers = null)
        {
            if (include is null && excludeExternalSharedChannels is null && excludeBotUsers is null)
            {
                throw new ArgumentException($"At least one of {nameof(include)}, {nameof(excludeExternalSharedChannels)} or {nameof(excludeBotUsers)} must be provided.");
            }
            Include = include;
            ExcludeExternalSharedChannels = excludeExternalSharedChannels;
            ExcludeBotUsers = excludeBotUsers;
        }

        /// <summary>
        /// Indicates which type of conversations should be included in the list. When this field is provided, any conversations that do not match will be excluded. You should provide an array of strings from the following options: im, mpim, private, and public. The array cannot be empty.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("include")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("include")]
#endif
        public IEnumerable<string>? Include { get; }

        /// <summary>
        /// Indicates whether to exclude external <a href="https://api.slack.com/enterprise/shared-channels">shared channels</a> from conversation lists. Defaults to false.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("exclude_external_shared_channels")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("exclude_external_shared_channels")]
#endif
        public bool? ExcludeExternalSharedChannels { get; }

        /// <summary>
        /// Indicates whether to exclude bot users from conversation lists. Defaults to false.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("exclude_bot_users")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("exclude_bot_users")]
#endif
        public bool? ExcludeBotUsers { get; }
    }
}