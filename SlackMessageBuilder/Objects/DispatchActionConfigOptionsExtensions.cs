using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Dispatch action config option extensions.
    /// </summary>
    public static class DispatchActionConfigOptionsExtensions
    {
        /// <summary>
        /// Creates a <see cref="DispatchActionConfig"/> from the <see cref="DispatchActionConfigOptions"/>.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static DispatchActionConfig ToDispatchActionConfig(this DispatchActionConfigOptions options)
        {
            var include = new List<string>(2);
            if (options.HasFlag(DispatchActionConfigOptions.OnCharacterEntered))
            {
                include.Add("on_character_entered");
            }
            if (options.HasFlag(DispatchActionConfigOptions.OnEnterPressed))
            {
                include.Add("on_enter_pressed");
            }
            var config = new DispatchActionConfig(include);
            return config;
        }
    }
}