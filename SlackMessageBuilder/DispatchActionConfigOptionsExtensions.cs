using System.Collections.Generic;

namespace SlackMessageBuilder
{
    public static class DispatchActionConfigOptionsExtensions
    {
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